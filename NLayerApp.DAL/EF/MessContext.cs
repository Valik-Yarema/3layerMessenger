using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NLayerApp.DAL.Enities;


namespace NLayerApp.DAL.EF
{
    public class MessContext : DbContext
    {
        public DbSet<AdInfo> AdInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessagesRecipient> MessagesRecipients { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<User> Users { get; set; }

        static MessContext()
        {
            Database.SetInitializer<MessContext>(new StoreDbInitializer());
        }
        public MessContext(string connectionString)
             : base(connectionString)
        {
        }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<MessContext>
    {
        protected override void Seed(MessContext db)
        {
            User user = new User { Name = "Piter", Login = "pit007", Password = "1111", Adress = "valik5597@gmail.com" };
            db.Users.Add(new User { Name = "David", Login = "David007", Password = "1111", Adress = "davi5597@gmail.com" });
            db.Users.Add(new User { Name = "Inna", Login = "Inna007", Password = "1111", Adress = "inna5597@gmail.com" });

            db.Users.Add(user);
            db.SaveChanges();
            

        }
    }
}
