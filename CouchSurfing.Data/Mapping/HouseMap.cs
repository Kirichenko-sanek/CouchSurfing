using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class HouseMap : EntityTypeConfiguration<House>
    {
        public HouseMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.City).IsRequired();
            Property(m => m.Country).IsRequired();
            Property(m => m.Description).IsRequired();
            Property(m => m.NumberHouse).IsRequired();
            Property(m => m.Street).IsRequired();
            ToTable("House");

            HasRequired(m => m.User).WithMany(m => m.Houses).HasForeignKey(m => m.IdUser).WillCascadeOnDelete(false);          
        }
    }
}
