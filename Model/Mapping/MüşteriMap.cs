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
    public class MüşteriMap : EntityTypeConfiguration<Müşteri>
    {
        public MüşteriMap()
        {
            ToTable("Müşteri");

            HasKey(x => x.MüşteriID);
            Property(x => x.MüşteriID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.MüşteriAdı).HasMaxLength(15).IsRequired();
            Property(x => x.MüşteriSoyadı).HasMaxLength(20).IsRequired();

            Property(x => x.TC).HasMaxLength(11).IsRequired();
            Property(x => x.Cinsiyet).HasMaxLength(5).IsRequired();
            
        }
    }
}
