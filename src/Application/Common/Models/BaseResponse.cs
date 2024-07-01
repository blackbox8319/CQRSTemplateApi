using Application.Models;
using System;

namespace Application.Common.Models
{
    public abstract class BaseResponse : AuditableResponse
    {
        public Guid Id { get; set; }
    }
}
