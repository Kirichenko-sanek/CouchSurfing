using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class PhotoMap : EntityTypeConfiguration<Photo>
    {
        public PhotoMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.Url).IsRequired();
            Property(m => m.Date).IsRequired();
            ToTable("Photo");
        }
    }
}
