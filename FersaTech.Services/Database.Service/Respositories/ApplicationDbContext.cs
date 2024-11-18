using FersaTech.Domain.Model.Entities;
using FersaTech.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Services.Database.Service.Respositories
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<MovementType> MovementType { get; set; }
        public DbSet<BitacoraIncidencias> BitacoraIncidencias { get; set; }
        public DbSet<Alertas> Alertas { get; set; }
        public DbSet<TransaccionesDetalle> TransaccionesDetalle { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }
    }
}
