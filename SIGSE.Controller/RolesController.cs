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
    public class RolesController
    {

        private static RolesController instancia;
        public static RolesController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new RolesController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private RolesController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Rol> obtenerListaRoles()
        {
            return RolesManager.obtenerRoles(context);
        }

        public Rol obtenerRolPorId(int id)
        {
            return RolesManager.obtenerRolPorId(context, id);
        }

        public void agregarRol(Rol rol)
        {
            RolesManager.agregarRol(context, rol);
        }

        public void modificarRol(Rol rol)
        {
            RolesManager.modificarRol(context, rol);
        }

        public void eliminarRol(Rol rol)
        {
            RolesManager.eliminarRol(context, rol);
        }

        public List<Permiso> obtenerListaPermiso()
        {
            return PermisoManager.obtenerPermisos(context);
        }

        public Permiso obtenerUsuario(int id)
        {
            return PermisoManager.obtenerPermisoPorId(context, id);
        }

        public void agregarPermiso(Permiso permiso)
        {
            PermisoManager.agregarPermiso(context, permiso);
        }

        public void eliminarPermiso(Permiso permiso)
        {
            PermisoManager.eliminarPermiso(context, permiso);
        }

        public void guardarRol(Rol rol)
        {
            if (rol.idRol != 0)
                RolesManager.modificarRol(context, rol);
            else
                RolesManager.agregarRol(context, rol);
        }

        public PermisoCompuesto obtenerPermisoCompuestoPorId(int id)
        {
            return PermisoManager.obtenerPermisoCompuestoPorId(context, id);
        }

        public Permiso obtenerPermisoPorNombre(string nombre)
        {
            return PermisoManager.obtenerPermisoPorNombre(context, nombre);
        }

    }
}
