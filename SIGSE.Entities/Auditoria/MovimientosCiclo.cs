using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities.Auditoria
{
    public class MovimientosCiclo
    {
        public int id { get; set; }
        public string acción { get; set; }
        public DateTime fecha_actividad { get; set; }
        public string objetivo { get; set; }
        public DateTime fecha_inicio { get; set; }
        public EstadoCiclo estado { get; set; }
        public TipoEntrenamiento tipo_entrenamiento { get; set; }
        public int cant_semanas { get; set; }
        public int cant_dias { get; set; }
        public string usuario { get; set; }

        public MovimientosCiclo ()
        {

        }

    }
}
