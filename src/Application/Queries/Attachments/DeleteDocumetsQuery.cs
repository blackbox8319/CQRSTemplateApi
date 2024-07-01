using Application.Response;
using LanguageExt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Attachments
{
    public class DeleteDocumetsQuery : IRequest<Option<GenericPairResponse>>
    {
        public string DocumentName { get; set; }
    }
}
