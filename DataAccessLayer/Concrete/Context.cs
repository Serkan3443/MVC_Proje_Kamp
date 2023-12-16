using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Hakkimizda> Hakkimizdalar {get;set;}
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Iletisim> Iletisimler { get; set; }
        public DbSet<Icerik> Icerikler { get; set; }
        public DbSet<Baslik> Basliklar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

    }
}
