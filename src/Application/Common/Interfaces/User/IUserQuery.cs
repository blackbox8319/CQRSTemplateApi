using Application.Queries.User;
using Domain.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.User
{
    public interface IUserQuery
    {
        Task<UserAuth> FindUserByIdAsync(string userId);
        //Task<Users> UserByNameAsync(string userName);
        //Task<IList<Users>> FetchUserAsync(string role);
    }
}
