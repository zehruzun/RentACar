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
        public int yorumID { get; set; }
        [StringLength(500)]
        public string yorumKonu { get; set; }
        [StringLength(2500)]
        public string yorumIcerik { get; set; }
    }
}
