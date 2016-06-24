using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.AccountPhoto).IsRequired();
            Property(m => m.Email).IsRequired();
            Property(m => m.FirstName).IsRequired();
            Property(m => m.IsActivated).IsRequired();
            Property(m => m.IsDeleted).IsRequired();
            Property(m => m.LastName).IsRequired();
            Property(m => m.Password).IsRequired();
            Property(m => m.PasswordSalt).IsRequired();
            Property(m => m.PersonalInfo).IsRequired();
            ToTable("User");
        }
    }
}
