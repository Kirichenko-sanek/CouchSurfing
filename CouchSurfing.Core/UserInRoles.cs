namespace CouchSurfing.Core
{
    public class UserInRoles : BaseEntity
    {
        public long IdUser { get; set; }
        public long IdRoles { get; set; }

        public virtual User User { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
