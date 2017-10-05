using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    interface IAdd<T> where T : class
    {
        void Ekle(T parametre);
    }
}
