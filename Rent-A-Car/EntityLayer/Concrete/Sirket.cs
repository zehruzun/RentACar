using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sirket
    {
        [Key]
        public int sirketID { get; set; }
        [StringLength(500)]
        public string sirketAd { get; set; }
        [StringLength(500)]
        public string sirketSehir { get; set; }
        public int sirketAracSayisi { get; set; }
        public int sirketPuan { get; set; }
        [StringLength(500)]
        public string sirketMail { get; set; }
        [StringLength(500)]
        public string sirketSifre { get; set; }
        public bool sirketDurum { get; set; }
        public ICollection<Araba> Arabas { get; set; }
    }
}
