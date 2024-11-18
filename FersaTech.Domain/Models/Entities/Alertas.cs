using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.Models.Entities
{
    public class Alertas
    {

        public long AlertasId { get; set; }
        public long TransaccionesId { get; set; }
        public string NombreArchivo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCarga { get; set; }
        public int NumLinea { get; set; }
    }
}
