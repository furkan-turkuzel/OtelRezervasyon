using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository.Interface
{
    interface IÜyeler : IAdd<Üye>, IUpdate<Üye>, IDelete<Üye>, IGet<Üye>, IGetAll<Üye>
    {
        int KullanıcıAdıŞifre(string kullanıcıAdı,string şifre);
    }
}
