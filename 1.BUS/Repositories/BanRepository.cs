using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.BUS.Context;
using _1.BUS.DomainClass;
using _1.BUS.IRepositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace _1.BUS.Repositories
{
    public class BanRepository:IBanRepository
    {
        private DBContext _dbContext;

        public BanRepository()
        {
            _dbContext = new DBContext();
        }
        public bool add(Ban obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool delete(Ban obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool udpate(Ban obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Ban> GetAll()
        {
            return _dbContext.Ban.ToList();
        }
    }
}
