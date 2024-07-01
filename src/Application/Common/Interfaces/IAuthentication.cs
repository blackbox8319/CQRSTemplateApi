using Application.Queries.Authentication;
using Application.Response.Authentication;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IAuthentication
    {
        Task<AuthenticationResponse> LoginAsync(LoginQuery user);
    }
}
