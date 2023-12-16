using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Baslik
    {
        [Key]
        public int BaslikID { get; set; }

        [StringLength(50)]
        public string BaslikAdi { get; set; }
        public DateTime BaslikTarihi { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }//Başlık ve kategori arasında 1 e çok ilişkide kategori 1 tarafında başlık ise çok tarafında olacaktır yani bir kategorinin birden fazla başlığı olabilir.
        public ICollection<Icerik> Icerikler { get; set; }//İçerik ile başlık arasında 1 e çok ilişkide içerik  çok tarafında başlık ise 1 tarafında olacaktır.Yani bir başlığın birden fazla içeriği olur.
        public int YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }//Yazar ile başlık arasında 1 e çok ilişkide yazar 1 tarafında başlık ise çok tarafında olacaktır.Yani bir yazarın birden fazla başlığı olabilir.
    }
}
