using Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application.Queries.Authentication;
using Application.Response.Authentication;
using LanguageExt;

namespace Application.Handlers.QHandlers.Authentication
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery,Option<AuthenticationResponse>>
    {
        private readonly IAuthentication _authentication;
        public LoginQueryHandler(IAuthentication authentication) => _authentication = authentication;
        public async Task<Option<AuthenticationResponse>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            return await _authentication.LoginAsync(request);
        }

    }
}
