
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Enities;
using NLayerApp.DAL.Interfaces;

namespace WebMessenger.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private MessContext db;
        private AdInfoRepository adInfoRepository;
        private MessageRepository messageRepository;
        private MessagesRecRepository messagesRecRepository;
        private PhoneRepository phoneRepository;
        private UserRepository userRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new MessContext(connectionString);
        }

        public IRepository<AdInfo> AdInfos
        {
            get
            {
                if (adInfoRepository==null)
                {
                    adInfoRepository = new AdInfoRepository(db);
                }
                return adInfoRepository;
            }
        }
        public IRepository<Message> Messages
        {
            get
            {
                if (messageRepository==null)
                {
                    messageRepository = new MessageRepository(db);
                }
                return messageRepository;
            }
        }
        public IRepository<MessagesRecipient> MessagesRec
        {
            get
            {
                if (messagesRecRepository == null)
                {
                    messagesRecRepository = new MessagesRecRepository(db);
                }
                return messagesRecRepository;

            }
        }
        public IRepository<Phone> Phones
        {
            get
            {
                if (phoneRepository == null)
                {
                    phoneRepository = new PhoneRepository(db);
                }
                return phoneRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}