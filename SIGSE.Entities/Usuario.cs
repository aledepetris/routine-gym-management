using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
        public Persona persona { get; set; }
        public IList<Rol> roles { get; set; }

    }

}
