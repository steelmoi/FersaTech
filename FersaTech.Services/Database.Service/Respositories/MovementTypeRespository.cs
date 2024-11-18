using FersaTech.Domain.Model.Entities;
using FersaTech.Services.Database.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Respositories
{
    public class MovementTypeRespository : DbManager<MovementType>, IMovementTypeRespository
    {
        public MovementTypeRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
