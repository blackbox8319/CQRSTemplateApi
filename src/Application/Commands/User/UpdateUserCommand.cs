using Application.Response;
using MediatR;
namespace Application.Commands.User
{
    public class UpdateUserCommand : IRequest<GenericPairResponse>
    {
        public string Id { get; set; }
        public int EmpNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string Password { set; get; }
        public string Photo { set; get; }
        public string CustomerCode { get; set; }
        public string CompanyCode { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
