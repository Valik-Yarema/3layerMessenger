using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Enities;
using NLayerApp.DAL.Interfaces;

namespace WebMessenger.Repositories
{
    public class AdInfoRepository  : IRepository<AdInfo>
    {
        private MessContext db;

        public AdInfoRepository(MessContext context)
        {
            this.db = context;
        }

        public IEnumerable<AdInfo> GetAll()
        {
            return db.AdInfos;
        }

        public AdInfo Get(int id)
        {
            return db.AdInfos.Find(id);
        }

        public void Create(AdInfo adInfo)
        {
            db.AdInfos.Add(adInfo);
        }

        public void Update(AdInfo adInfo)
        {
            db.Entry(adInfo).State = EntityState.Modified;
        }

        public IEnumerable<AdInfo> Find(Func<AdInfo, Boolean> predicate)
        {
            return db.AdInfos.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            AdInfo adInfo = db.AdInfos.Find(id);
            if (adInfo != null)
                db.AdInfos.Remove(adInfo);
        }
    }
}