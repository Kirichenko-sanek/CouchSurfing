using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class DialogMap : EntityTypeConfiguration<Dialog>
    {
        public DialogMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Dialog");

            HasRequired(m => m.User).WithMany(m => m.Dialogs).HasForeignKey(m => m.IdUser).WillCascadeOnDelete(false);
            HasRequired(m => m.Companion)
                .WithMany(m => m.Dialogs)
                .HasForeignKey(m => m.IdCompanion)
                .WillCascadeOnDelete(false);
        }
    }
}
