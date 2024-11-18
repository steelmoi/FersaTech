using FersaTech.Domain.dtos;
using FersaTech.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Interfaces
{
    public interface IBitacoraIncidenciasRepository: IDbManager<BitacoraIncidencias>
    {
        int AddIncidencias(List<ExcelTransaction> txs, Transacciones trans);
        List<BitacoraIncidencias> GetIncidentsByTransaction(long TransactionId);
    }
}
