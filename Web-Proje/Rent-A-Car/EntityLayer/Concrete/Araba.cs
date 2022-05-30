using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Araba
    {
        [Key]
        public int arabaID { get; set; }
        [StringLength(500)]
        public string arabaImg { get; set; }
        [StringLength(500)]
        public string arabaMarka { get; set; }
        [StringLength(500)]
        public string arabaModel { get; set; }
        [StringLength(500)]
        public string arabaVitesTuru { get; set; }
        [StringLength(500)]
        public string arabaYakitTuru { get; set; }
        public int arabaUcret { get; set; }
        public int arabaEhliyetYasi { get; set; }
        public int arabaYasSiniri { get; set; }
        public int arabaSinirKM { get; set; }
        public int arabaKM { get; set; }
        public bool arabaAirbag { get; set; }
        public int arabaBagajHacmi { get; set; }
        public bool arabaDurum { get; set; }
        public int sirketID { get; set; }
        public virtual Sirket Sirket { get; set; }

        public ICollection<Kiralama> Kiralamas { get; set; }
    }
}
