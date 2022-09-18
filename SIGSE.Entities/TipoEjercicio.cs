using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class TipoEjercicio
    {
        public int idTipoEjercicio { get; set; }
        public string nombre { get; set; }


        public TipoEjercicio()
        {

        }

        public TipoEjercicio(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
