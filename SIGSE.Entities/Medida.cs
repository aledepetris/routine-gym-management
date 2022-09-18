using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Medida
    {
        public int IdMedida { get; set; }
        public DateTime fecha { get; set; }
        public int altura { get; set; } // cm
        public int peso { get; set; } // kg
        public int hombro { get; set; }
        public int pecho { get; set; }
        public int brazo { get; set; }
        public int cintura { get; set; }
        public int cadera { get; set; }
        public int pierna { get; set; }
    }
}
