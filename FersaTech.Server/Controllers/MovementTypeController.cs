using FersaTech.Domain.Model.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FersaTech.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovementTypeController : ControllerBase
    {
        private readonly IMovementTypeRespository MovementTypeRespository;
        public MovementTypeController(IMovementTypeRespository MovementTypeRespository)
        {
            this.MovementTypeRespository = MovementTypeRespository;
        }

        [HttpGet]
        public List<MovementType> Get()
        {
            return MovementTypeRespository.GetAll().ToList();
        }
    }
}
