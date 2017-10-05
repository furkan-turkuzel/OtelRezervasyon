using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MüşteriOdaRezervasyon
    {

        public int MüşteriID { get; set; }

        public int OdaNumarası { get; set; }

        public int RezervasyonID { get; set; }
        public virtual Müşteri müşteri { get; set; }

        public virtual Oda oda { get; set; }

        public virtual Rezervasyon Rezervasyon { get; set; }

        


    }
}
