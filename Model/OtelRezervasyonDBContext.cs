using Model.Entity;
using Model.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OtelRezervasyonDBContext:DbContext
    {


        public OtelRezervasyonDBContext():base("otel")
        {
            Database.SetInitializer<OtelRezervasyonDBContext>(new VeriTabaniOlusturucu());
        }

        public DbSet<Üye> üyeler { get; set; }
        public DbSet<Rezervasyon> rezervasyon { get; set; }

        public DbSet<RezervasyonTipi> rezervasyontipi { get; set; }

        public DbSet<Müşteri> müşteri { get; set; }

        public DbSet<MüşteriOdaRezervasyon> müşteriodarezervasyon { get; set; }

        public DbSet<Oda> oda { get; set; }

        public DbSet<OdaTipi> odatipi { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ÜyelerMap());
            modelBuilder.Configurations.Add(new MüşteriMap());
            modelBuilder.Configurations.Add(new RezervasyonMap());
            modelBuilder.Configurations.Add(new RezervasyonTipiMap());
            modelBuilder.Configurations.Add(new MüşteriOdaRezervasyonMap());
            modelBuilder.Configurations.Add(new OdaMap());
            modelBuilder.Configurations.Add(new OdaTipiMap());
        }
    }

    public class VeriTabaniOlusturucu : DropCreateDatabaseAlways<OtelRezervasyonDBContext>
    {
        protected override void Seed(OtelRezervasyonDBContext context)
        {
            OdaTipi odatipi = new OdaTipi();

            odatipi.OdaTipiID = 1;
            odatipi.OdaTipleri = "Standart";
            odatipi.OdaFiyatı = 0;
            odatipi.Açıklama = "Standart oda tipidir.";
            context.odatipi.Add(odatipi);

            OdaTipi odatipi1 = new OdaTipi();

            odatipi1.OdaTipiID = 2;
            odatipi1.OdaTipleri = "Suit";
            odatipi1.OdaFiyatı = 200;
            odatipi1.Açıklama = "Suit oda tipidir.";
            context.odatipi.Add(odatipi1);

            OdaTipi odatipi2 = new OdaTipi();

            odatipi2.OdaTipiID = 3;
            odatipi2.OdaTipleri = "Lux";
            odatipi2.OdaFiyatı = 300;
            odatipi2.Açıklama = "Lux oda tipidir.";
            context.odatipi.Add(odatipi2);

            RezervasyonTipi rezTip = new RezervasyonTipi();

            rezTip.RezervasyonTipiID = 1;
            rezTip.RezervasyonTip = "Standart";
            rezTip.EkstraFiyat = 0;
            rezTip.Açıklama = "Oda ve kahvaltı dahildir";
            context.rezervasyontipi.Add(rezTip);

            RezervasyonTipi rezTip1 = new RezervasyonTipi();

            rezTip1.RezervasyonTipiID = 2;
            rezTip1.RezervasyonTip = "Full";
            rezTip1.EkstraFiyat = 100;
            rezTip1.Açıklama = "Oda ve yemek dahildir";
            context.rezervasyontipi.Add(rezTip1);

            RezervasyonTipi rezTip2 = new RezervasyonTipi();

            rezTip2.RezervasyonTipiID = 3;
            rezTip2.RezervasyonTip = "Full+Full";
            rezTip2.EkstraFiyat = 200;
            rezTip2.Açıklama = "Oda yemek ve içki dahildir";
            context.rezervasyontipi.Add(rezTip2);

            for (int i = 0; i < 10; i++)
            {
                Oda oda = new Oda();

                oda.OdaTipiID = 1;
                oda.BoşMu = true;
                oda.AktifMi = true;
                context.oda.Add(oda);
            }

            for (int i = 0; i < 6; i++)
            {
                Oda oda1 = new Oda();

                oda1.OdaTipiID = 2;
                oda1.BoşMu = true;
                oda1.AktifMi = true;
                context.oda.Add(oda1);
            }

            for (int i = 0; i < 4; i++)
            {
                Oda oda2 = new Oda();

                oda2.OdaTipiID = 3;
                oda2.BoşMu = true;
                oda2.AktifMi = true;
                context.oda.Add(oda2);
            }

            context.SaveChanges();
        }
    }

}
