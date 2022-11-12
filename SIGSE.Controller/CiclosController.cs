using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SIGSE.Bussines;
using SIGSE.Context;
using SIGSE.Entities;
using SIGSE.SessionManager;

namespace SIGSE.Controller
{
    public class CiclosController
    {

        private static CiclosController instancia;
        public static CiclosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new CiclosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private CiclosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public Ciclo obtenerCiclo(int id)
        {
            return CicloManager.obtenerCicloPorId(context, id);
        }

        public bool eliminarCiclo(Alumno alumno, Ciclo ciclo)
        {
            // TODO
            return true;
        }

    }
}
