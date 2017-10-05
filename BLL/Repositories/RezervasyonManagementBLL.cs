using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RezervasyonManagementBLL
    {
        RezervasyonManagement rm = new RezervasyonManagement();

        public void Ekle(Model.Rezervasyon parametre)
        {
            rm.Ekle(parametre);
        }

        public void Güncelle(Model.Rezervasyon parametre)
        {
            rm.Güncelle(parametre);
        }

        public void Sil(Model.Rezervasyon parametre)
        {
            rm.Sil(parametre);
        }

        public Model.Rezervasyon Getir(int ID)
        {
            return rm.Getir(ID);
        }

        public ICollection<Model.Rezervasyon> HepisiniGetir()
        {
            return rm.HepisiniGetir();
        }
    }
}
