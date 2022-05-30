using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kiralama
    {
        [Key]
        public int kiralamaID { get; set; }
        [StringLength(500)]
        public string kiralamaAlisYeri { get; set; }
        [StringLength(500)]
        public string kiralamaTeslimYeri { get; set; }
        public DateTime kiralamaAlisTarihi { get; set; }
        public DateTime kiralamaTeslimTarihi { get; set; }
        public DateTime kiralamaAlisSaati { get; set; }
        public DateTime kiralamaTeslimSaati { get; set; }
        public int kiralamaGun { get; set; }
        public bool kiralamaDurum { get; set; }
        public int kullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public int arabaID { get; set; }
        public virtual Araba Araba { get; set; }
    }
}
