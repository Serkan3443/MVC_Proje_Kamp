using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; }
        
        [StringLength(1000)]
        public string HakkimizdaDetay1 { get; set; }

        [StringLength(1000)]
        public string HakkimizdaDetay2 { get; set; }

        [StringLength(100)]
        public string HakkimizdaResim1 { get; set; }

        [StringLength(100)]
        public string HakkimizdaResim2 { get; set; }
    }
}
