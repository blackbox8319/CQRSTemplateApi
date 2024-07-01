using System.Collections.Generic;
using Application.Response.User;
using LanguageExt;
using MediatR;

namespace Application.Queries.User
{
    public class FetchUserQuery : IRequest<Option<IList<FetchUserResponse>>>
    {
        public string Role { get; set; }
    }

}
