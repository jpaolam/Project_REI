using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomain.Audit
{
    public abstract class AuditableEntity
    {
        //Se extienden por las demas clases para rellenar lo demas
        public string? CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
