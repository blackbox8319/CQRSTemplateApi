using Application.Response;
using LanguageExt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Application.Commands.Attachments
{
    public class AttachCommand : IRequest<Option<GenericPairResponse>>
    {
        public IFormFile? File { get; set; }
    }
}
