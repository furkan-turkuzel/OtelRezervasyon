using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    interface IUpdate<T> where T : class
    {
        void Güncelle(T parametre);
    }
}
