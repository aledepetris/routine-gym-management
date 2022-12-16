using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities.Auditoria
{
    public class AuditoriaCiclos
    {
        public int idAuditoria { get; set; }
        public int idCiclo { get; set; }
        public string nombreAlumno { get; set; }
        public List<MovimientosCiclo> movimientosCiclo {get; set;}

        public AuditoriaCiclos()
        {
            movimientosCiclo = new List<MovimientosCiclo>();
        }

        public AuditoriaCiclos(int id)
        {
            idCiclo = id;
            movimientosCiclo = new List<MovimientosCiclo>();
        }

    }
}
