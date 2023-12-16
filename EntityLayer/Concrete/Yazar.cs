using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }


        [StringLength(50)]
        public string YazarAdi { get; set; }
        [StringLength(50)]
        public string YazarSoyadi { get; set; }

        [StringLength(100)]
        public string YazarResim { get; set; }

        [StringLength(50)]
        public string YazarMail { get; set; }

        [StringLength(20)]
        public string YazarSifre { get; set; }
        public ICollection<Baslik> Basliklar { get; set; }//1`e çok ilişkide başlık çok tarafında yazar 1 tarafında olacaktır.

        public ICollection<Icerik> Icerikler { get; set; }//1 e çok ilişkide içerik ile yazar arasında şöyle ilişki var yazar 1 tarafında içerik ise çok tarafında yer alır yani bir yazar birden fazla içeriğe sahip olabilir.
    }
}
