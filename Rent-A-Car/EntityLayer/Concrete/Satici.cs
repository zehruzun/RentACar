using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Satici
    {
        [Key]
        public int saticiID { get; set; }
        [StringLength(500)]
        public string saticiAd { get; set; }
        [StringLength(500)]
        public string saticiMail { get; set; }
        [StringLength(500)]
        public string saticiSifre { get; set; }
        public int saticiTel { get; set; }
        public bool saticiDurum { get; set; }
        public ICollection<Araba> Arabas { get; set; }
    }
}
