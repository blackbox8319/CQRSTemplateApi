
using Domain.Common;
using System;

namespace Domain.Entities.User
{
    public class UserAuth : EntityBase
    {
        public string user_name { get; set; }
        public string password { get; set; }
        public string password_token_salt { get; set; }
        public string role_name { get; set; }
        public Byte[] user_photo { set; get; }
    }
}
