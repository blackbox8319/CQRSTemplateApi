using Application.Response;
using MediatR;

namespace Application.Commands.User
{
    public class DeleteUserCommand : IRequest<GenericPairResponse>
    {
        public string LoginId { set; get; }
        //public string UserName { set; get; }
        public string ModifiedBy { set; get; }
    }
}
