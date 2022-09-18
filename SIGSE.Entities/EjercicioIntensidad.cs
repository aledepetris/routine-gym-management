using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class EjercicioIntensidad
    {
        public int idEjercicioIntensidad { get; set; }
        public Ejercicio ejercicio { get; set; }
        public int series { get; set; }
        public int repeticiones { get; set; }
        public float peso { get; set; }
        public int descanso { get; set; } // En minutos
        public string notas { get; set; }

        public EjercicioIntensidad()
        {

        }

    }
}
