using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE.Entities;
namespace SIGSE.SessionManager
{
    public class Sesion
    {
        public Usuario currentUser { get; set; }

        private Sesion()
        {

        }

        private static Sesion sesion;
        public static Sesion obtenerSesion()
        {
            if (sesion == null)
            {
                sesion = new Sesion();

            }
            return sesion;
        }
    }
}
