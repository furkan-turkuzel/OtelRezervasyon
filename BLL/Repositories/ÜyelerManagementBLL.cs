using DAL.Repository;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ÜyelerManagementBLL
    {
        ÜyelerManagement üm;

        public ÜyelerManagementBLL()
        {
            üm = new ÜyelerManagement();
        }

        public void Ekle(Model.Entity.Üye parametre)
        {
            üm.Ekle(parametre);
        }

        public void Güncelle(Model.Entity.Üye parametre)
        {
            üm.Güncelle(parametre);
        }

        public void Sil(Model.Entity.Üye parametre)
        {
            üm.Sil(parametre);
        }

        public ICollection<Model.Entity.Üye> HepisiniGetir()
        {
            return üm.HepisiniGetir();
        }

        public int KullanıcıAdıŞifre(string kullanıcıAdı, string şifre)
        {
            return üm.KullanıcıAdıŞifre(kullanıcıAdı,şifre);
        }

        public Üye Getir(int ID)
        {
            return üm.Getir(ID);
        }

    }
}
