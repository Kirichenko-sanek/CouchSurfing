using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class UserInRolesMap : EntityTypeConfiguration<UserInRoles>
    {
        public UserInRolesMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("UserInRoles");

            HasRequired(m => m.User)
                .WithMany(m => m.UserInRoles)
                .HasForeignKey(m => m.IdUser)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.Roles)
                .WithMany(m => m.UserInRoleses)
                .HasForeignKey(m => m.IdRoles)
                .WillCascadeOnDelete(false);
        }
    }
}
