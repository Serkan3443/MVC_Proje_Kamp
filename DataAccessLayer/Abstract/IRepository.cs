using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> Listele();//Listeleme işlemi yapar 

        void Insert(T p);//Ekleme işlemi yapar

        void Delete(T p);//Silme işlemi yapar

        void Update(T p);//Güncelleme işlemi yapar

        List<T> Listele(Expression<Func<T, bool>> filter);//Bu ise normal listelemeden farklı olarak şartlı listeleme yapar yani kullanıcının isteğine göre listeleme yapar.
    }
}
