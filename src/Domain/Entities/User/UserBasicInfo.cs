using System;

namespace Domain.Entities.User
{
    public class UserBasicInfo
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Byte[] Photo { get; set; }
    }
}
