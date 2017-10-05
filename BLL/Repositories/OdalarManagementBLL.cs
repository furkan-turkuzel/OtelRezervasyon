using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class OdalarManagementBLL
    {
        OdaManagement om = new OdaManagement();
        public void Ekle(Model.Oda parametre)
        {
            om.Ekle(parametre);
        }

        public void Güncelle(Model.Oda parametre)
        {
            om.Güncelle(parametre);
        }

        public void Sil(Model.Oda parametre)
        {
            om.Sil(parametre);
        }

        public Model.Oda Getir(int ID)
        {
            return om.Getir(ID);
        }

        public ICollection<Model.Oda> HepisiniGetir()
        {
            return om.HepisiniGetir();
        }
    }
}
