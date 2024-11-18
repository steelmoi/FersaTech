using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.Models.Entities
{
    public class TransaccionesDetalle
    {

        public long TransaccionesDetalleId { get; set; }
        public long TransaccionesId { get; set; }
        public string Tipo { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor fuera de rango {0} debe estar entre {1} y {2}.")]
        public decimal Monto {  get; set; }
        public int NumLinea { get; set; }
        public DateTime Fecha { get; set; }
    }
}
