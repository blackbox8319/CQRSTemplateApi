using Application.Commands.Attachments;
using Application.Common.Constants;
using Application.Response;
using Application.Response.Attachments;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CHandlers.Attachments
{
    public class AttachDocumentCommandHandler : IRequestHandler<AttachCommand, Option<GenericPairResponse>>
    {
        private readonly IConfiguration _config;

        public AttachDocumentCommandHandler(IConfiguration config)
        {
            _config = config;
        }

        public async Task<Option<GenericPairResponse>> Handle(AttachCommand request, CancellationToken cancellationToken)
        {
            var userName = _config.GetSection("FtpCredentials").GetSection("UserName").Value;
            var password = _config.GetSection("FtpCredentials").GetSection("Password").Value;
            var networkCredential = new NetworkCredential(userName, password);
            var fileName = Path.GetFileNameWithoutExtension(request.File.FileName.Replace(" ", "_")) + "_" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + Path.GetExtension(request.File.FileName);

            var ftpUri = _config.GetSection("FtpSettings").GetSection("FtpUrl").Value;
            var uploadPath = Path.Combine(ftpUri);

            using (new NetworkConnection(uploadPath, networkCredential))
            {
                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                var filePath = Path.Combine(uploadPath, fileName);
                if (request.File.FileName != null)
                {
                    var ExistPath = Path.Combine(ftpUri, fileName);
                    if (File.Exists(ExistPath)) File.Delete(ExistPath);
                }
                using var stream = new FileStream(filePath, FileMode.Create);
                await request.File.CopyToAsync(stream);

                var httpUri = _config.GetSection("FtpSettings").GetSection("HttpUrl").Value;
                var attachmentResponse = new AttachmentResponse();
                attachmentResponse.DocumentName = fileName;
                attachmentResponse.DocumentPath = new Uri($"{httpUri}{fileName}").ToString();

                return new GenericPairResponse() { Key = true, Value = attachmentResponse };
            }
        }
    }
}
