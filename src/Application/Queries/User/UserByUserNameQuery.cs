using Application.Response.User;
using LanguageExt;
using MediatR;

namespace Application.Queries.User
{
    public class UserByUserNameQuery : IRequest<Option<UsersResponse>>
    {
        public string UserName { get; set; }
    }
}
