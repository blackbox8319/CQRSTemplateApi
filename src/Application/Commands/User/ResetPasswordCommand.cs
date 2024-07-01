using Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.User
{
    public class ResetPasswordCommand : IRequest<GenericPairResponse>
    {
        public string UserName { get; set; }
        public string Password { set; get; }
    }
}
