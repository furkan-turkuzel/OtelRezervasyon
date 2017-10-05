using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class MüşteriOdaRezervasyonMap:EntityTypeConfiguration<MüşteriOdaRezervasyon>
    {
        public MüşteriOdaRezervasyonMap ()
	    {
            ToTable("MüşteriOdaRezervasyon");
    
            HasKey(x=> new {x.MüşteriID,x.OdaNumarası,x.RezervasyonID});

            HasRequired(x=>x.müşteri).WithMany(x=>x.MüşteriOdaRezervasyon).HasForeignKey(x=>x.MüşteriID);
            HasRequired(x=>x.oda).WithMany(x=>x.MüşteriOdaRezervasyon).HasForeignKey(x=>x.OdaNumarası);
            HasRequired(x=>x.Rezervasyon).WithMany(x=>x.MüşteriOdaRezervasyon).HasForeignKey(x=>x.RezervasyonID);
	    }
    }
}
