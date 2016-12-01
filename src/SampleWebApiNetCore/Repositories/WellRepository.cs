using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApiNetCore.Models;

namespace SampleWebApiNetCore.Repositories
{
    public class WellRepository : IWellRepository
    {
        private DataBaseContext db;

        public WellRepository(DataBaseContext context)
        {
            db = context;
        }

        public IEnumerable<Well> GetAll()
        {
            return db.Wells.ToList();
        }

        public Well Find(int id)
        {
            return db.Wells.FirstOrDefault(well => well.Id == id);
        }

        public void Add(Well well)
        {
            db.Wells.Add(well);
            db.SaveChanges();
        }

        public Well Remove(int id)
        {
            var well = Find(id);
            if(well == null)
            {
                return null;
            }

            db.Wells.Remove(well);
            db.SaveChanges();
            return well;
        }

        public void Update(Well well)
        {
            db.Wells.Update(well);
            db.SaveChanges();
        }
    }
}
