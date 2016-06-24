using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class HousePhotoMap : EntityTypeConfiguration<HousePhoto>
    {
        public HousePhotoMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("House");

            HasRequired(m => m.House)
                .WithMany(m => m.HousePhotos)
                .HasForeignKey(m => m.IdHouse)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.Photo)
                .WithMany(m => m.HousePhotos)
                .HasForeignKey(m => m.IdPhoto)
                .WillCascadeOnDelete(false);    
        }
    }
}
