using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class MüşteriOdaRezervasyonBLL
    {
        MüşteriOdaRezervasyonManagement mor = new MüşteriOdaRezervasyonManagement();
        public void Ekle(Model.MüşteriOdaRezervasyon parametre)
        {
            mor.Ekle(parametre);
        }

        public void Güncelle(Model.MüşteriOdaRezervasyon parametre)
        {
            mor.Güncelle(parametre);
        }

        public void Sil(Model.MüşteriOdaRezervasyon parametre)
        {
            mor.Sil(parametre);
        }

        public Model.MüşteriOdaRezervasyon Getir(int ID)
        {
            return mor.Getir(ID);
        }

        public ICollection<Model.MüşteriOdaRezervasyon> HepisiniGetir()
        {
            return mor.HepisiniGetir();
        }
    }
}
