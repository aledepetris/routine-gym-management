using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class PermisoManager
    {
        public static List<Entities.Permiso> obtenerPermisos(Context.SigseContext sigseContext)
        {
            return sigseContext.permisos.ToList();
        }

        public static Entities.Permiso obtenerPermisoPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.permisos.FirstOrDefault(p => p.idPermiso == id);
        }

        public static Entities.PermisoCompuesto obtenerPermisoCompuestoPorId(Context.SigseContext sigseContext, int id)
        {
            Entities.PermisoCompuesto pc = (Entities.PermisoCompuesto) sigseContext.permisos.FirstOrDefault(x => x.idPermiso == id);

            return pc;

        }

        public static Entities.Permiso obtenerPermisoPorNombre(Context.SigseContext sigseContext, string nombre)
        {
            return sigseContext.permisos.SingleOrDefault(p => p.nombre == nombre);
        }

        public static void agregarPermiso(Context.SigseContext sigseContext, Entities.Permiso permiso)
        {
            sigseContext.permisos.Add(permiso);
            sigseContext.SaveChanges();
        }

        public static void agregarListaPermisos(Context.SigseContext sigseContext, List<Entities.Permiso> permisos)
        {
            sigseContext.permisos.AddRange(permisos);
            sigseContext.SaveChanges();
        }

        public static void modificarPermiso(Context.SigseContext sigseContext, Entities.Permiso permiso)
        {
            sigseContext.Entry(permiso).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarPermiso(Context.SigseContext sigseContext, Entities.Permiso permiso)
        {
            sigseContext.permisos.Remove(permiso);
            sigseContext.SaveChanges();
        }
    }
}
