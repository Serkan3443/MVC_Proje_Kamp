using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class KategoriManager
    {
        GenericRepository<Kategori> repo=new GenericRepository<Kategori>();
        public List<Kategori> GetAll()//toplu listeleme işlemi yapar
        {
            return repo.Listele();//Kategori tablosunu listeler
        }
        public void KategoriEkleBll(Kategori p)
        {
            if (p.KategoriAdi=="" || p.KategoriAdi.Length<=3 || p.KategoriAciklama=="" || p.KategoriAdi.Length>=51)
            {
                //Hata mesajı dönsün
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
