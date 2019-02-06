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
    public class MessageRepository : IRepository<Message>
    {
        private MessContext db;

        public MessageRepository(MessContext context)
        {
            this.db = context;
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages;
        }

        public Message Get(int id)
        {
            return db.Messages.Find(id);
        }

        public void Create(Message message)
        {
            db.Messages.Add(message);
        }

        public void Update(Message message)
        {
            db.Entry(message).State = EntityState.Modified;
        }

        public IEnumerable<Message> Find(Func<Message, Boolean> predicate)
        {
            return db.Messages.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Message message = db.Messages.Find(id);
            if (message != null)
                db.Messages.Remove(message);
        }
    }
    
}