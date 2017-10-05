using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Üye
    {
        public int ÜyeID { get; set; }
        public string KullanıcıAdı { get; set; }

        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Parola { get; set; }

        public bool AktifMi { get; set; }

        public virtual ICollection<Rezervasyon> rezervasyon { get; set; }


    }
}
