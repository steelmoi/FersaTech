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
    public class AlertasRepository : DbManager<Alertas>, IAlertasRepository
    {
        public AlertasRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public int AddAlertas(List<ExcelTransaction> transactionList, Transacciones trans)
        {
            List<ExcelTransaction> Data = (from E in transactionList
                                          where E.IsAlert == true
                                          select E).ToList();
            List<Alertas> Details = new List<Alertas>();
            foreach (ExcelTransaction tran in Data)
            {
                Details.Add(new Alertas()
                {
                     Descripcion = tran.Message,
                     FechaCarga = DateTime.Now,
                     NombreArchivo = trans.NombreArchivo,
                     NumLinea= tran.NumLinea,
                     TransaccionesId=trans.TransaccionesId
                });
            }
            this.AddRange(Details);

            return Data.Count;
        }

        public List<Alertas> GetAlertsByTransaction(long TransactionId)
        {
            return this.GetAll()
                .Where(A => A.TransaccionesId == TransactionId)
                .ToList();
        }
    }
}
