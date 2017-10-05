using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class OdaTipiMap : EntityTypeConfiguration<OdaTipi>
    {
        public OdaTipiMap()
        {
            ToTable("OdaTipi");
            HasKey(x => x.OdaTipiID);

            Property(x => x.OdaTipiID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.OdaTipleri).HasMaxLength(10).IsRequired();

            Property(x => x.OdaFiyatı).IsRequired();
            Property(x => x.Açıklama).IsRequired();
        }
    }
}
