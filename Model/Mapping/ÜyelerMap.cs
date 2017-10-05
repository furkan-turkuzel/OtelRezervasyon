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
    public class ÜyelerMap:EntityTypeConfiguration<Üye>
    {
        public ÜyelerMap()
        {
            ToTable("Üyeler");

            HasKey(x=>x.ÜyeID);
            Property(x => x.ÜyeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.KullanıcıAdı).HasMaxLength(20).IsRequired();
            Property(x => x.İsim).HasMaxLength(15).IsRequired();
            Property(x => x.Soyisim).HasMaxLength(20).IsRequired();
            Property(x => x.Parola).HasMaxLength(20).IsRequired();
            Property(x => x.AktifMi).IsRequired();

        }
    }
}
