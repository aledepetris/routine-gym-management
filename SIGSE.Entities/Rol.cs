using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Rol
    {
        public int idRol { get; set; }
        public string nombre { get; set; }
        public IList<Permiso> permisos { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
