using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class OdaTipi
    {
        public int OdaTipiID { get; set; }
        public string OdaTipleri { get; set; }

        public decimal OdaFiyatı { get; set; }
        public string Açıklama { get; set; }

        public virtual ICollection<Oda> oda { get; set; }
    }
}
