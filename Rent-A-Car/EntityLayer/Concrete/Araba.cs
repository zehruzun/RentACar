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
        public string arabaTur { get; set;}
        [StringLength(500)]
        public string arabaMarka { get; set; }
        [StringLength(500)]
        public string arabaModel { get; set; }
        public bool ArbaYakitTuru { get; set; }
        public int arabaUcret { get; set; }
        public int arabaKM { get; set; }
        public int arabaYil { get; set; }
        [StringLength(500)]
        public string arabaMotor { get; set; }
        [StringLength(500)]
        public string arabaSanziman { get; set; }
        public bool arabaDurum { get; set; }

        public bool? ArabaSisFari { get; set; }
        public bool? ArabaKatlanirAyna { get; set; }
        public bool? ArabaParkSensoru { get; set; }
        public bool? ArabaMerkeziKilit { get; set; }
        public bool? ArabaCamTavan { get; set; }

        public int sirketID { get; set; }
        public virtual Satici Satici { get; set; }
    }
}
