using Application.Models;

namespace Application.Response.User
{
    public class FetchUserResponse : BaseResponse
    {
        public string UserName { get; set; }
        public int EmpNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string Photo { set; get; }
        public string CustomerId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerCode { get; set; }
        public string CompanyCode { get; set; }
        public string RoleId { get; set; }
        public string ProjectId { get; set; }
    }
}
