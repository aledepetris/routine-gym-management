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
    public class HomeController
    {

        private static HomeController instancia;
        public static HomeController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new HomeController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private HomeController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public void realizarLogOut()
        {
            sesion.cerrarSesion(context);
            
        }

        public bool cambiarPassword(Usuario user, string actualPwd, string nuevaPwd, string repetirPwd)
        {
            actualPwd = Encrypter.Encrypt(actualPwd);
            if (user.password == actualPwd)
            {
                if (nuevaPwd == repetirPwd)
                {
                    user.password = nuevaPwd;
                    UsuarioManager.modificarUsuario(context, user);
                    return true;
                }
            }
            return false;
        }

    }
}
