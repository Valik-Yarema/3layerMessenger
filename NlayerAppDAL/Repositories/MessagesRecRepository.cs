using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NLayerAppDAL.EF;
using NLayerAppDAL.Enities;
using NLayerAppDAL.Interfaces;
namespace WebMessenger.Repositories
{
    public class MessagesRecRepository : IRepository<MessagesRecipient>
    {
        private MessContext db;

        public MessagesRecRepository(MessContext context)
        {
            this.db = context;
        }

        public IEnumerable<MessagesRecipient> GetAll()
        {
            return db.MessagesRecipients;
        }

        public MessagesRecipient Get(int id)
        {
            return db.MessagesRecipients.Find(id);
        }

        public void Create(MessagesRecipient messagesRecipient)
        {
            db.MessagesRecipients.Add(messagesRecipient);
        }

        public void Update(MessagesRecipient messagesRecipient)
        {
            db.Entry(messagesRecipient).State = EntityState.Modified;
        }

        public IEnumerable<MessagesRecipient> Find(Func<MessagesRecipient, Boolean> predicate)
        {
            return db.MessagesRecipients.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            MessagesRecipient messagesRecipient = db.MessagesRecipients.Find(id);
            if (messagesRecipient != null)
                db.MessagesRecipients.Remove(messagesRecipient);
        }
    }
}