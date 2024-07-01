using System;

namespace Application.Models
{
    public class AuditableResponse
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

    
        public bool IsActive { get; set; }
    }
}
