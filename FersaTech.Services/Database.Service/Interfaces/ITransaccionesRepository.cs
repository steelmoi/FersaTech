using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Interfaces
{
    public interface ITransaccionesRepository: IDbManager<Transacciones>
    {
        Transacciones AddTransaction(Transacciones tran);
        Transacciones AddTransaction(string Path);
    }
}
