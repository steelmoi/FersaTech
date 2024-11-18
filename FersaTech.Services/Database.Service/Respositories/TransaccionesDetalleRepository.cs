using FersaTech.Domain.dtos;
using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Respositories
{
    public class TransaccionesDetalleRepository : DbManager<TransaccionesDetalle>, ITransaccionesDetalleRepository
    {
        public TransaccionesDetalleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public int AddDetails(List<ExcelTransaction> _List, Transacciones trans)
        {
            List<ExcelTransaction> Data  = (from E in _List
                                           where E.EsIncidencia == false && E.IsAlert == false
                                           select E).ToList();
            List<TransaccionesDetalle> Details = new List<TransaccionesDetalle>();
            foreach (ExcelTransaction Tran in Data)
            {
                Details.Add(
                    new TransaccionesDetalle()
                    {
                        Fecha = DateTime.Now,
                        Monto = Tran.RealAmount,
                        NumLinea = Tran.NumLinea,
                        Tipo = Tran.Type,
                        TransaccionesId = trans.TransaccionesId
                    }    
                );
            }

            this.AddRange(Details);
            return Data.Count;
        }

        public List<TransaccionesDetalle> GetDetails(long transactionId)
        {
            return  this.GetAll()
                    .Where(D => D.TransaccionesId ==  transactionId)
                    .ToList();
        }
    }
}
