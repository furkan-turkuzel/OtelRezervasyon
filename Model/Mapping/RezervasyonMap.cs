using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class RezervasyonMap : EntityTypeConfiguration<Rezervasyon>
    {
        public RezervasyonMap()
        {
            ToTable("Rezervasyon");

            HasKey(x=>x.RezervasyonID);
            Property(x => x.RezervasyonID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.rezervasyontipi).WithMany(x => x.rezervasyon).HasForeignKey(x => x.RezervasyonTipiID);
            HasRequired(x => x.üyeler).WithMany(x => x.rezervasyon).HasForeignKey(x => x.ÜyeID);

            Property(x => x.GirişTarihi).IsRequired();
            Property(x => x.ÇıkışTarihi).IsRequired();

            Property(x => x.KişiSayısı).IsRequired();


        }
    }
}
