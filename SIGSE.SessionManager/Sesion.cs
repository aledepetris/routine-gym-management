using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE.Bussines;
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

        public Entities.Usuario loguearseConUsuarioContraseña(Context.SigseContext sigseContext, string user, string pass)
        {
            Entities.Usuario userToReturn = sigseContext.Set<Entities.Usuario>()
                                            .Where(u => u.username == user)
                                            .Include(u => u.persona)
                                            .Include(u => u.roles.Select(r => r.permisos))
                                            .SingleOrDefault();
            if (userToReturn != null)
            {
                cerrarSesionAnterior(sigseContext, userToReturn);

                if (Encrypter.Decrypt(userToReturn.password) == pass)
                    return userToReturn;
            }

            return null;

        }

        public void registrarSesion(Context.SigseContext sigseContext, Usuario usuario)
        {
            Entities.Auditoria.AuditoriaLogin auditoriaLogin = new Entities.Auditoria.AuditoriaLogin(usuario.username);

            sigseContext.auditoria_login.Add(auditoriaLogin);
            sigseContext.SaveChanges();
            currentUser = usuario;
        }

        public void cerrarSesion(Context.SigseContext sigseContext)
        {
            Entities.Auditoria.AuditoriaLogin auditoriaLogin = sigseContext.auditoria_login
                                                                .FirstOrDefault(u => u.username == currentUser.username && u.sesionActiva);

            auditoriaLogin.fechaHoraDesconexion = DateTime.Now;
            auditoriaLogin.sesionActiva = false;

            sigseContext.Entry(auditoriaLogin).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();

            currentUser = null;

        }

        public void cerrarSesionAnterior(Context.SigseContext sigseContext, Usuario usuario)
        {
            Entities.Auditoria.AuditoriaLogin auditoriaLogin = sigseContext.auditoria_login
                                                    .FirstOrDefault(u => u.username == usuario.username && u.sesionActiva);

            if (auditoriaLogin != null)
            { 
                auditoriaLogin.fechaHoraDesconexion = DateTime.Now;
                auditoriaLogin.sesionActiva = false;

                sigseContext.Entry(auditoriaLogin).State = System.Data.Entity.EntityState.Modified;
                sigseContext.SaveChanges();
            }
        }


    }
}
