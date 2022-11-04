using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class RolesManager
    {
        public static List<Entities.Rol> obtenerRoles(Context.SigseContext sigseContext)
        {
            return sigseContext.roles.ToList();
        }

        public static Entities.Rol obtenerRolPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.roles
                .Where(x => x.idRol == id)
                .Include(x => x.permisos)
                .FirstOrDefault();
        }

        public static Entities.Rol obtenerRolPorNombre(Context.SigseContext sigseContext, string nombre)
        {
            return sigseContext.roles
                .Where(x => x.nombre == nombre)
                .Include(x => x.permisos)
                .FirstOrDefault();
        }

        public static void agregarRol(Context.SigseContext sigseContext, Entities.Rol rol)
        {
            sigseContext.roles.Add(rol);
            sigseContext.SaveChanges();
        }

        public static void agregarListaRoles(Context.SigseContext sigseContext, List<Entities.Rol> roles)
        {
            sigseContext.roles.AddRange(roles);
            sigseContext.SaveChanges();
        }

        public static void modificarRol(Context.SigseContext sigseContext, Entities.Rol rol)
        {
            sigseContext.Entry(rol).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarRol(Context.SigseContext sigseContext, Entities.Rol rol)
        {
            sigseContext.roles.Remove(rol);
            sigseContext.SaveChanges();
        }
    }
}
