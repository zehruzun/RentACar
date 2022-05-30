using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici
    {
        [Key]
        public int kullaniciID { get; set; }
        [StringLength(500)]
        public string kullaniciAd { get; set; }
        [StringLength(500)]
        public string kullaniciSoyad { get; set; }
        [StringLength(500)]
        public string kullaniciMail { get; set; }
    }
}
