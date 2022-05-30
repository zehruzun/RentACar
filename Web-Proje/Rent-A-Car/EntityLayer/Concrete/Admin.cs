using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int adminID { get; set; }
        [StringLength(500)]
        public string adminAd { get; set; }
        [StringLength(500)]
        public string adminSifre { get; set; }
    }
}
