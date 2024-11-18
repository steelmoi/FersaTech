using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.Models.Entities
{
    public class BitacoraIncidencias
    {
        public long BitacoraIncidenciasId { get; set; }
        public long TransaccionesId { get; set; }
        public string NombreArchivo  { get; set; }
        public DateTime FechaCarga  { get; set; }
        public string Incidencia  { get; set; }
        public int NumLinea  { get; set; }
}
}
