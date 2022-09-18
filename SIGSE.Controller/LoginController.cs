using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE.Bussines;
using SIGSE.Context;
using SIGSE.Entities;
using SIGSE.SessionManager;

namespace SIGSE.Controller
{
    public class LoginController
    {

        private static LoginController instancia;
        public static LoginController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new LoginController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private LoginController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario realizarLogin(string user, string pass)
        {
            Usuario usuario = UsuarioManager.loguearseConUsuarioContraseña(context, user, pass);
            if (usuario != null && usuario.activo)
                sesion.currentUser = usuario;
            return usuario;
        }

    }
}
