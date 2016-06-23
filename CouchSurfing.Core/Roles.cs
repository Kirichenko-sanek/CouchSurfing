using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Roles : BaseEntity
    {
        public string NameRole { get; set; }

        public virtual List<UserInRoles> UserInRoleses { get; set; }

        public Roles()
        {
            UserInRoleses = new List<UserInRoles>();
        }
    }
}
