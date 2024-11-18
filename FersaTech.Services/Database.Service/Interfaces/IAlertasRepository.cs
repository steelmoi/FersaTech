using FersaTech.Domain.dtos;
using FersaTech.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Interfaces
{
    public interface IAlertasRepository: IDbManager<Alertas>
    {
        int AddAlertas(List<ExcelTransaction> transactionList, Transacciones trans);
        List<Alertas> GetAlertsByTransaction(long TransactionId);
    }
}
