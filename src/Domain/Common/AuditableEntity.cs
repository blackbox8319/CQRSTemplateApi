using System;

namespace Domain.Common
{
    public abstract class AuditableEntity
    {

        public string created_by { set; get; }
        public DateTime created_on { set; get; }
       //public string last_modified_by { set; get; }
        public string modified_by { set; get; }
        public DateTime modified_on { set; get; }
        //public DateTime last_modified_on { set; get; }
        public bool is_active { get; set; }

        public string Created_By { get; set; }
        public DateTime Created_On { get; set; }

        public string Modified_By { get; set; }
        public DateTime Modified_On { get; set; }
    }
}
