using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository.Üyeler
{
    interface IRezervasyon:IAdd<Rezervasyon>,IUpdate<Rezervasyon>,IDelete<Rezervasyon>,IGet<Rezervasyon>,IGetAll<Rezervasyon>
    {
    }
}
