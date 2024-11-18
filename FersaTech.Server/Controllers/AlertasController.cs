using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using FersaTech.Services.Database.Service.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace FersaTech.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlertasController : ControllerBase
    {
        private readonly IAlertasRepository alertasRepository;

        public AlertasController(IAlertasRepository _alertasRepository) => alertasRepository = _alertasRepository;

        [HttpGet("{transaccionesId}")]
        public List<Alertas> GetAlertsByTransaction(long transaccionesId)
        {
            try
            {
                return alertasRepository.GetAlertsByTransaction(transaccionesId);
            }
            catch (Exception ex)
            {
                return new List<Alertas>();
            }
        }
    }
}
