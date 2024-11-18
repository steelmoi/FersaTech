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
    public class BitacoraIncidenciasRepository : DbManager<BitacoraIncidencias>, IBitacoraIncidenciasRepository
    {
        public BitacoraIncidenciasRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public int AddIncidencias(List<ExcelTransaction> txs, Transacciones trans)
        {
            List<ExcelTransaction> result = (from tx in txs
                                            where tx.EsIncidencia == true
                                            select tx).ToList();
            List<BitacoraIncidencias> Incidencias = new List<BitacoraIncidencias>();
            foreach (ExcelTransaction tx in result)
            {
                Incidencias.Add(
                    new BitacoraIncidencias()
                    {
                        FechaCarga = DateTime.Now,
                        Incidencia = tx.Message,
                        NombreArchivo = trans.NombreArchivo,
                        NumLinea = tx.NumLinea,
                        TransaccionesId = trans.TransaccionesId
                    }
                );
            }
            this.AddRange(Incidencias);
            return result.Count;
        }

        public List<BitacoraIncidencias> GetIncidentsByTransaction(long TransactionId)
        {
            return
                    this.GetAll()
                    .Where(I => I.TransaccionesId == TransactionId)
                    .ToList();
        }
    }
}
