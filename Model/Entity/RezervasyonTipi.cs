using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{ 
    public class RezervasyonTipi
    {
        public int RezervasyonTipiID { get; set; }
        public string RezervasyonTip { get; set; }

        public decimal EkstraFiyat { get; set; }

        public string Açıklama { get; set; }

        public virtual ICollection<Rezervasyon> rezervasyon { get; set; }

    }
}
