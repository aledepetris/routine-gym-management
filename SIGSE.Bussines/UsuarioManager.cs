using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Bussines
{
    public class UsuarioManager
    {
        public static List<Entities.Usuario> obtenerUsuarios(Context.SigseContext sigseContext)
        {
            return sigseContext.usuarios.ToList();
        }

        public static Entities.Usuario obtenerUsuario(Context.SigseContext sigseContext, string user)
        {
            return sigseContext.Set<Entities.Usuario>().SingleOrDefault(u => u.username == user);
        }

        public static Entities.Usuario loguearseConUsuarioContraseña(Context.SigseContext sigseContext, string user, string pass)
        {

            return sigseContext.Set<Entities.Usuario>()
                .Where(u => u.username == user && u.password == pass)
                .Include(u => u.persona)
                .Include(u => u.roles.Select(r => r.permisos))
                .SingleOrDefault();
        }

        public static void agregarUsuario(Context.SigseContext sigseContext, Entities.Usuario usuario)
        {
            sigseContext.usuarios.Add(usuario);
            sigseContext.SaveChanges();
        }

        public static void modificarUsuario(Context.SigseContext sigseContext, Entities.Usuario usuario)
        {
            sigseContext.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarUsuario(Context.SigseContext sigseContext, Entities.Usuario usuario)
        {
            sigseContext.usuarios.Remove(usuario);
            sigseContext.SaveChanges();
        }
    }
}
