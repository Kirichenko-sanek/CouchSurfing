using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActivated { get; set; }
        public string AccountPhoto { get; set; }
        public string PersonalInfo { get; set; }

        public virtual List<UserInRoles> UserInRoles { get; set; }
        public virtual List<House> Houses { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Dialog> Dialogs { get; set; }
        public virtual List<Application> Applications { get; set; }
        public virtual List<Application> Request { get; set; }

        public User()
        {
            UserInRoles = new List<UserInRoles>();
            Houses = new List<House>();
            Comments = new List<Comment>();
            Dialogs = new List<Dialog>();
            Applications = new List<Application>();
            Request = new List<Application>();
        }
    }
}
