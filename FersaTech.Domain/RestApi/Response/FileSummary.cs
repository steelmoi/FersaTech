using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.RestApi.Response
{
    public class FileSummary
    {
        public int TotalProcesados {  get; set; }
        public int TotalIncidencias {  get; set; }
        public int TotalAlertas {  get; set; }
    }
}
