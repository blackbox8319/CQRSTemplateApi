using Application.Common.Constants;
using Application.Queries.Attachments;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QHandlers.Attachments
{
    public class DeleteDocumentQueryHandler : IRequestHandler<DeleteDocumetsQuery, Option<GenericPairResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public DeleteDocumentQueryHandler(IMapper mapper, IConfiguration config)
        {
            _mapper = mapper;
            _config = config;
        }

        public async Task<Option<GenericPairResponse>> Handle(DeleteDocumetsQuery request, CancellationToken cancellationToken)
        {
            var userName = _config.GetSection("FtpCredentials").GetSection("UserName").Value;
            var password = _config.GetSection("FtpCredentials").GetSection("Password").Value;
            var networkCredential = new NetworkCredential(userName, password);

            var fileName = request.DocumentName;

            var ftpUri = _config.GetSection("FtpSettings").GetSection("FtpUrl").Value;
            var uploadPath = Path.Combine(ftpUri);

            using (new NetworkConnection(uploadPath, networkCredential))
            {
                var filePath = Path.Combine(uploadPath, fileName);
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }

            var genericPairResponse = new GenericPairResponse() { Key = true, Value = "Success" };
            return genericPairResponse;
        }
    }
}
