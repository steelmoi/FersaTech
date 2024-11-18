using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FersaTech.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransaccionesController : ControllerBase
    {
        private readonly ITransaccionesRepository transaccionesRepository;
        private readonly ITransaccionesDetalleRepository transaccionesDetalleRepository;
        public TransaccionesController(ITransaccionesRepository transaccionesRepository, ITransaccionesDetalleRepository transaccionesDetalleRepository)
        {
            this.transaccionesRepository = transaccionesRepository;
            this.transaccionesDetalleRepository = transaccionesDetalleRepository;
        }

        [HttpGet]
        public List<Transacciones> GetAll()
        {
            try
            {
                return transaccionesRepository.GetAll().ToList();
            }catch(Exception ex)
            {
                return new List<Transacciones>();
            }
        }

        [HttpGet("Detalle/{transactionId}")]
        public List<TransaccionesDetalle> GetDetail(long transactionId)
        {
            try
            {
                return transaccionesDetalleRepository.GetDetails(transactionId);
            }
            catch(Exception ex)
            {
                return new List<TransaccionesDetalle>();
            }
        }
    }
}
