using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class RezervasyonTipiMap : EntityTypeConfiguration<RezervasyonTipi>
    {
        public RezervasyonTipiMap()
        {
            ToTable("RezervasyonTipi");
            HasKey(x => x.RezervasyonTipiID);

            Property(x => x.RezervasyonTipiID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.RezervasyonTip).HasMaxLength(10).IsRequired();

            Property(x => x.EkstraFiyat).IsRequired();
            Property(x => x.Açıklama).IsRequired();
        }
    }
}
