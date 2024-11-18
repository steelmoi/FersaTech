using FersaTech.Domain.Models.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using FersaTech.Services.Database.Service.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace FersaTech.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncidenciasController : ControllerBase
    {
        private IBitacoraIncidenciasRepository BitacoraIncidenciasRepository;

        public IncidenciasController(IBitacoraIncidenciasRepository bitacoraIncidenciasRepository) => BitacoraIncidenciasRepository = bitacoraIncidenciasRepository;

        [HttpGet("{transaccionesId}")]
        public List<BitacoraIncidencias> Get(int transaccionesId)
        {
            return 
                    BitacoraIncidenciasRepository
                    .GetIncidentsByTransaction(transaccionesId);
        }
    }
}
