﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMessenger.Enities;

namespace WebMessenger.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Phone> Phones { get; }
        IRepository<AdInfo> AdInfos { get; }
        IRepository<Message> Messages { get; }
        IRepository<MessagesRecipient> MessagesRec { get; }

        void Save();
    }
}
