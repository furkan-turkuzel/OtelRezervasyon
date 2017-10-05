using DAL.IRepository.Üyeler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class OdaManagement:IOdalar
    {
        OtelRezervasyonDBContext db = new OtelRezervasyonDBContext();
        public void Ekle(Model.Oda parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        public void Güncelle(Model.Oda parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(Model.Oda parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public Model.Oda Getir(int ID)
        {
            return db.oda.Find(ID);
        }

        public ICollection<Model.Oda> HepisiniGetir()
        {
            return db.oda.ToList();
        }
    }
}
