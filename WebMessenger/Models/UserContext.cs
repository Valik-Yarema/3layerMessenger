using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMessenger.Enities;

namespace WebMessenger.Models
{
    public class UserContext : DbContext
    {
        public DbSet<AdInfo> AdInfos{ get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessagesRecipient> MessagesRecipients { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
