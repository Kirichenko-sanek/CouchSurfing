using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.NameStatus).IsRequired();
            ToTable("Status");
        }
    }
}
