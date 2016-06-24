using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CouchSurfing.Core;

namespace CouchSurfing.Data.Mapping
{
    class HouseStatusMap : EntityTypeConfiguration<HouseStatus>
    {
        public HouseStatusMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(m => m.House)
                .WithMany(m => m.HouseStatuses)
                .HasForeignKey(m => m.IdHouse)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.Status)
                .WithMany(m => m.HouseStatuses)
                .HasForeignKey(m => m.IdStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
