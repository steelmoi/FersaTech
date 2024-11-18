using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.Models.Entities
{
    public class Transacciones
    {
        public long TransaccionesId { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime FechaCarga {  get; set; }
        public int TotalProcesados { get; set; }
        public int TotalAlertas { get; set; }
        public int TotalIncidencias { get; set; }
    }
}
