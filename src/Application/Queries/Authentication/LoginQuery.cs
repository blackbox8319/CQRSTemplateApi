using Application.Response.Authentication;
using LanguageExt;
using MediatR;

namespace Application.Queries.Authentication
{
    public class LoginQuery : IRequest<Option<AuthenticationResponse>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
