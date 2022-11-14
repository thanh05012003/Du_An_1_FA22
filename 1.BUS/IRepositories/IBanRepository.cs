using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.BUS.Context;
using _1.BUS.DomainClass;

namespace _1.BUS.IRepositories
{
    public interface IBanRepository
    {
        bool add(Ban obj);
        bool delete(Ban obj);
        bool udpate(Ban obj);
        List<Ban> GetAll();
    }
}
