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
            Entities.Usuario userToReturn = sigseContext.Set<Entities.Usuario>().SingleOrDefault(u => u.username == user);

            userToReturn.password = Encrypter.Decrypt(userToReturn.password);

            return userToReturn;
        }

        public static void agregarUsuario(Context.SigseContext sigseContext, Entities.Usuario usuario)
        {
            usuario.password = Encrypter.Encrypt(usuario.password);
            sigseContext.usuarios.Add(usuario);
            sigseContext.SaveChanges();
        }

        public static void modificarUsuario(Context.SigseContext sigseContext, Entities.Usuario usuario)
        {
            usuario.password = Encrypter.Encrypt(usuario.password);
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
