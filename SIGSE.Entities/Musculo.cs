using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Musculo
    {
        public int idMusculo { get; set; }
        public string nombre { get; set; }


        public Musculo(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
