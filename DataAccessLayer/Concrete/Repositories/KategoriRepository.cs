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
    public class KategoriRepository : IKategoriDLL
    {
        Context c = new Context();
       DbSet<Kategori> _object;
        public void Delete(Kategori p)
        {

            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Kategori p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Kategori> Listele()
        {
            return _object.ToList();
        }

        public List<Kategori> Listele(Expression<Func<Kategori, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Kategori p)
        {
            c.SaveChanges();
        }
    }
}
