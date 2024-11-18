using FersaTech.Domain.dtos;
using FersaTech.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Interfaces
{
    public interface ITransaccionesDetalleRepository: IDbManager<TransaccionesDetalle>
    {
        int AddDetails(List<ExcelTransaction> _List, Transacciones trans);
        List<TransaccionesDetalle> GetDetails(long transactionId);
    }
}
