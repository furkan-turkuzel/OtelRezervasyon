using DAL.IRepository;
using DAL.IRepository.Interface;
using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ÜyelerManagement:IÜyeler
    {
        OtelRezervasyonDBContext db = new OtelRezervasyonDBContext();


        public int KullanıcıAdıŞifre(string kullanıcıAdı, string şifre)
        {
            int üye = (from ü in db.üyeler
                          where ü.KullanıcıAdı == kullanıcıAdı && ü.Parola == şifre && ü.AktifMi == true
                          select ü.ÜyeID).FirstOrDefault();

            return üye;
        }

        public void Ekle(Üye parametre)
        {
            db.Entry(parametre).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Güncelle(Üye parametre)
        {
            db.Entry(parametre).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(Üye parametre)
        {
            db.Entry(parametre).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Üye Getir(int ID)
        {
            return db.üyeler.Find(ID);
        }

        public ICollection<Üye> HepisiniGetir()
        {
            return db.üyeler.ToList();
        }

        
    }
}
