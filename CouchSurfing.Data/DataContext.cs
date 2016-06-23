using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CouchSurfing.Core;

namespace CouchSurfing.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HousePhoto> HousePhotos { get; set; }
        public DbSet<HouseStatus> HouseStatuses { get; set; }
        public DbSet<Massage> Massages { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Roles> Roleses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInRoles> UserInRoleses { get; set; }

        public DataContext() : base("CouchSurfingDB")
        {
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer(new CouchSurfingInitializer());
        }

        private class CouchSurfingInitializer : DropCreateDatabaseAlways<DataContext>
        {
            protected override void Seed(DataContext context)
            {
                var roles = new List<Roles>
                {
                    new Roles()
                    {
                        NameRole = "Admin"
                    },
                    new Roles()
                    {
                        NameRole = "User"
                    }
                };
                foreach (var role in roles) context.Roleses.Add(role);
                context.SaveChanges();



                base.Seed(context);
            }
        }
    }   
}
