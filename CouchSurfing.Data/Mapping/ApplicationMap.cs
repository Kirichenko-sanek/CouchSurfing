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
            //Property(m => m.IdUser).IsRequired();
            //Property(m => m.IdClient).IsRequired();
            //Property(m => m.IdHouse).IsRequired();
            Property(m => m.Date).IsRequired();
            ToTable("Application");
        }
    }
}
