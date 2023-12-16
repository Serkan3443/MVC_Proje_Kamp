using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Icerik
    {
        [Key]
        public int IcerikID { get; set; }

        [StringLength(1000)]
        public string IcerikDegeri { get; set; }
        public DateTime IcerikTarihi { get; set; }
        public int BaslikID { get; set; }
        public virtual Baslik Baslik{ get; set; }//İçerik ve başlık arasında 1`e çok ilişkide başlık 1 tarafında içerik ise çok tarafında bulunacaktır

        public int? YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }//Yazar ve içerik arasında bire çok ilişkide yazar 1 tarafında içerik ise çok tarafında yer alır
    }
}
