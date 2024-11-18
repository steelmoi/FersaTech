using FersaTech.Domain.Model.Entities;
using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Respositories
{
    public class TransaccionesRepository : DbManager<Transacciones>, ITransaccionesRepository
    {
        public TransaccionesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Transacciones AddTransaction(Transacciones tran)
        {
            return this.AddEntity(tran);
        }

        public Transacciones AddTransaction(string Path)
        {
            Transacciones transacciones = new Transacciones()
            {
                FechaCarga = DateTime.Now,
                NombreArchivo = Path,
                TotalAlertas = 0,
                TotalIncidencias= 0,
                TotalProcesados= 0,
            };
            return this.AddEntity(transacciones);
        }
    }
}
