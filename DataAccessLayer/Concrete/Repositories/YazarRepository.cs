using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class YazarRepository : IYazarDLL
    {
        Context c=new Context();
        DbSet<Yazar> _object;
        public void Delete(Yazar p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Yazar p)
        {
           _object.Add(p);
            c.SaveChanges();
        }

        public List<Yazar> Listele()
        {
           return _object.ToList();
            
        }

        public List<Yazar> Listele(Expression<Func<Yazar, bool>> filter)
        {
            return _object.ToList();
        }

        public void Update(Yazar p)
        {
            c.SaveChanges();
        }
    }
}
