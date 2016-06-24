using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class MassageMap : EntityTypeConfiguration<Massage>
    {
        public MassageMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.TextMassage).IsRequired();
            ToTable("Massage");

            HasRequired(m => m.Dialog)
                .WithMany(m => m.Massages)
                .HasForeignKey(m => m.IdDialog)
                .WillCascadeOnDelete(false);
        }
    }
}
