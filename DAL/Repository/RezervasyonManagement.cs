using DAL.IRepository.Üyeler;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{

    public class RezervasyonManagement:IRezervasyon
    {
        OtelRezervasyonDBContext db = new OtelRezervasyonDBContext();

        public void Ekle(Model.Rezervasyon parametre)
        {
            db.Entry(parametre).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Güncelle(Model.Rezervasyon parametre)
        {
            db.Entry(parametre).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(Model.Rezervasyon parametre)
        {
            db.Entry(parametre).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Model.Rezervasyon Getir(int ID)
        {
            return db.rezervasyon.Find(ID);
        }

        public ICollection<Model.Rezervasyon> HepisiniGetir()
        {
            return db.rezervasyon.ToList();
        }
    }
}
