using System.Threading.Tasks;
using Application.Commands.User;
using Application.Response;
using Domain.Entities;

namespace Application.Common.Interfaces.User
{
    public interface IUserCommand
    {
        Task<GenericPair> DeleteUserAsync(DeleteUserCommand deleteUser);
        //Task<GenericPair> UpdateUserAsync(UpdateUserCommand updateUser);
        //Task<GenericPair> AddUserAsync(AddUserCommand addUser);
        //Task<GenericPair> ResetPasswordAsync(ResetPasswordCommand resetPassword);
    }
}
