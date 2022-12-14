using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SIGSE.Bussines;
using SIGSE.Context;
using SIGSE.Entities;
using SIGSE.Entities.Auditoria;
using SIGSE.SessionManager;

namespace SIGSE.Controller
{
    public class AuditoriaController
    {

        private static AuditoriaController instancia;
        public static AuditoriaController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new AuditoriaController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private AuditoriaController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<AuditoriaLogin> obtenerListaAuditoriaLogin()
        {
            return context.auditoria_login.ToList();
        }

        public List<AuditoriaCiclos> obtenerListaAuditoriaCiclos()
        {
            return context.auditoria_ciclos.ToList();
        }

        public AuditoriaCiclos obtenerCicloAuditado(int id)
        {
            return context.auditoria_ciclos
                .Where(x => x.idAuditoria == id)
                .Include(x => x.movimientosCiclo)
                .FirstOrDefault();                
        }
    }
}
