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
    public class Oda
    {
        public int OdaNumarası { get; set; }

        public int OdaTipiID { get; set; }

        public bool BoşMu { get; set; }

        public bool AktifMi { get; set; }

        public virtual OdaTipi OdaTipi { get; set; }

        public virtual ICollection<MüşteriOdaRezervasyon> MüşteriOdaRezervasyon { get; set; }
    }
}
