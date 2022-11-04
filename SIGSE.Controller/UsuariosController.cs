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
    public class UsuariosController
    {

        private static UsuariosController instancia;
        public static UsuariosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new UsuariosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private UsuariosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Usuario> obtenerListaUsuarios()
        {
            return UsuarioManager.obtenerUsuarios(context);
        }

        public Usuario obtenerUsuario(int id)
        {
            return UsuarioManager.obtenerUsuarioPorId(context, id);
        }


        public Usuario obtenerUsuario(string email)
        {
            return UsuarioManager.obtenerUsuarioPorEmail(context, email);
        }

        public void guardarUsuario(Usuario user)
        {
            if (user.idUsuario != 0)
                UsuarioManager.modificarUsuario(context, user);
            else
                UsuarioManager.agregarUsuario(context, user);
        }

        public void eliminarUsuario(Usuario user)
        {
            UsuarioManager.eliminarUsuario(context, user);
        }

        public List<Rol> obtenerListaRoles()
        {
            return RolesManager.obtenerRoles(context);
        }

        public Rol obtenerRolPorNombre(string nombre)
        {
            return RolesManager.obtenerRolPorNombre(context, nombre);
        }

        public List<Persona> obtenerListaPersonas()
        {
            return PersonaManager.obtenerPesonas(context);
        }
    }
}
