using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.Date).IsRequired();
            ToTable("Application");

            HasRequired(m => m.User)
                .WithMany(m => m.Applications)
                .HasForeignKey(m => m.IdUser)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.Client)
                .WithMany(m => m.Applications)
                .HasForeignKey(m => m.IdClient)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.House)
                .WithMany(m => m.Applications)
                .HasForeignKey(m => m.IdHouse)
                .WillCascadeOnDelete(false);
        }
    }
}
