using DAL.IRepository.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MüşteriOdaRezervasyonManagement:IMüşteriOdaRezervasyon
    {
        OtelRezervasyonDBContext db = new OtelRezervasyonDBContext();
        public void Ekle(Model.MüşteriOdaRezervasyon parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        public void Güncelle(Model.MüşteriOdaRezervasyon parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(Model.MüşteriOdaRezervasyon parametre)
        {
            db.Entry(parametre).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public Model.MüşteriOdaRezervasyon Getir(int ID)
        {
            return db.müşteriodarezervasyon.Find(ID);
        }

        public ICollection<Model.MüşteriOdaRezervasyon> HepisiniGetir()
        {
            return db.müşteriodarezervasyon.ToList();
        }
    }
}
