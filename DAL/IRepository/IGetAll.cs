using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    interface IGetAll<T> where T : class
    {
        ICollection<T> HepisiniGetir();
    }
}
