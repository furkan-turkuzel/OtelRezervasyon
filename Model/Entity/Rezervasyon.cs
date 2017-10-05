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
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }

        public int RezervasyonTipiID { get; set; }

        public int ÜyeID { get; set; }

        public DateTime GirişTarihi { get; set; }

        public DateTime ÇıkışTarihi { get; set; }

        public Int16 KişiSayısı { get; set; }

        public bool AktifMi { get; set; }

        public virtual Üye üyeler { get; set; }

        public virtual RezervasyonTipi rezervasyontipi { get; set; }

        public virtual ICollection<MüşteriOdaRezervasyon> MüşteriOdaRezervasyon { get; set; }
    }
}
