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
    class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.TextComment).IsRequired();
            Property(m => m.Date).IsRequired();
            ToTable("Comment");

            HasRequired(m => m.User).WithMany(m => m.Comments).HasForeignKey(m => m.IdUser).WillCascadeOnDelete(false);
            HasRequired(m => m.House).WithMany(m => m.Comments).HasForeignKey(m => m.IdHouse).WillCascadeOnDelete(false);

        }
    }
}
