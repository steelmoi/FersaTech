using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FersaTech.Domain.Model.Entities
{
    public class MovementType
    {
        public int MovementTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
