
using Application.Common.Interfaces;
using Application.Options;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using CryptoHashVerify;
using Application.Common.Interfaces.User;
using Application.Queries.Authentication;
using Application.Response.Authentication;
using Domain.Entities.User;
using Application.Response.User;
using LanguageExt;

namespace Application.Services
{

    public class AuthenticationService : IAuthentication
    {
        private readonly IUserQuery _userQuery;
        private readonly JwtSettings _jwtSettings;
        public AuthenticationService(IUserQuery userQuery, JwtSettings jwtSettings)
        {
            _userQuery = userQuery;
            _jwtSettings = jwtSettings;
        }

        public async Task<AuthenticationResponse> LoginAsync(LoginQuery user)
        {
            var existingUser = await _userQuery.FindUserByIdAsync(user.UserName);

            if (existingUser == null)
            {
                return new AuthenticationResponse
                {
                    Errors = new[] { "Username / password incorrect" }
                };
            }

            if (!CheckPasswordAsync(existingUser.password, existingUser.password_token_salt, user.Password))
            {
                return new AuthenticationResponse
                {
                    Errors = new[] { "Username / password incorrect" }
                };
            }

            return await GenerateAuthenticationResponseForUserAsync(existingUser, user.Role);
        }

        private bool CheckPasswordAsync(string hashPassword, string salt, string password)
        {
            var plainPassword = ConvertToPlainPassword(password);
            return HashVerify.VerifyHashString(hashPassword, salt, plainPassword);
        }

        private string ConvertToPlainPassword(string encoded)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(encoded));
        }

        private Task<AuthenticationResponse> GenerateAuthenticationResponseForUserAsync(UserAuth user, string role)
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);

            var claims = new List<Claim>
            {
               new Claim("Role", user.role_name),
               new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
               new Claim("UserId", user.Id.ToString()),
               new Claim("UserName", user.user_name),
               //new Claim("Photo",  System.Text.Encoding.UTF8.GetString(user.user_photo)),
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Audience = "https://rectitudecs.com/",
                Expires = DateTime.UtcNow.Add(_jwtSettings.TokenLifetime),
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtHandler.CreateToken(tokenDescriptor);

            return Task.FromResult(new AuthenticationResponse
            {
                IsSuccess = true,
                Token = jwtHandler.WriteToken(token)
            });
        }
    }

}
