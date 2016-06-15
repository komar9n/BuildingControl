using System;

namespace BuildingControl.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserSurName { get; set; }
        public string UserEmailAddress { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public DateTime UserDateRegistration { get; set; }
        public string UserCompany { get; set; }
        public string UserPosition { get; set; }
        public int UserGroupId { get; set; }
        public bool UserActive { get; set; }
    }
}