using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
 
    public class Müşteri
    {
        public int MüşteriID { get; set; }

        public string MüşteriAdı { get; set; }

        public string MüşteriSoyadı { get; set; }

        public string TC { get; set; }

        public string Cinsiyet { get; set; }

        public virtual ICollection<MüşteriOdaRezervasyon> MüşteriOdaRezervasyon { get; set; }


    }
}
