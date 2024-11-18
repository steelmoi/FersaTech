using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.dtos
{
    public class ExcelTransaction
    {
        public string Type { get; set; }

        public string Amount { get; set; }
        public decimal RealAmount { get; set; }
        public string Date { get; set; }
        public string Message { get; set; }

        private bool _IsIncident = false;
        public bool EsIncidencia
        {
            get
            {
                decimal val = 0;
                _IsIncident = false;
                if (string.IsNullOrEmpty(Amount))
                {
                    _IsIncident = true;
                    Message = "El monto no puede estar vacio";
                } else if (!decimal.TryParse(Amount, out val))
                {
                    _IsIncident = true;
                    Message = "El monto debe ser numerico";
                }
                else
                {
                    RealAmount = val;
                }

                if (string.IsNullOrEmpty(Type))
                {
                    _IsIncident = true;
                    Message = "El tipo no debe ser vacio";
                }
                else if (!TypeMovs.Contains(Type))
                {
                    _IsIncident = true;
                    Message = "Tipo de movimiento no valido";
                }

                return _IsIncident;
            }
            set {
                _IsIncident = value;
            }
        }

        private bool _IsAlert = false;
        private string[] TypeMovs =  { "Ingreso", "Egreso"};
        public bool IsAlert
        {
            get
            {
                                                        //15000
                _IsAlert = (!EsIncidencia && RealAmount > 10000);
                if (_IsAlert)
                {
                    Message = "Transacción fuera de rango";
                }
                return _IsAlert;
            }
            set
            {
                _IsAlert = value;
            }
        }
        public int NumLinea { get; set; }

        public ExcelTransaction() { }
    }
}
