using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository.Interface
{
    interface IMüşteriOdaRezervasyon:IAdd<MüşteriOdaRezervasyon>,IUpdate<MüşteriOdaRezervasyon>,IDelete<MüşteriOdaRezervasyon>,IGet<MüşteriOdaRezervasyon>,IGetAll<MüşteriOdaRezervasyon>
    {

    }
}
