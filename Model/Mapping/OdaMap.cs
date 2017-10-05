using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class OdaMap : EntityTypeConfiguration<Oda>
    {
        public OdaMap()
        {
            ToTable("Oda");
            HasKey(x=>x.OdaNumarası);
            Property(x => x.OdaNumarası).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.OdaTipi).WithMany(x => x.oda).HasForeignKey(x => x.OdaTipiID).WillCascadeOnDelete();

            Property(x => x.AktifMi).IsRequired();
            Property(x => x.BoşMu).IsRequired();

        }
    }
}
