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
    public class TiposEjerciciosController
    {

        private static TiposEjerciciosController instancia;
        public static TiposEjerciciosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new TiposEjerciciosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private TiposEjerciciosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<TipoEjercicio> obtenerListaTiposEjercicios()
        {
            return TipoEjercicioManager.obtenerTipoEjercicios(context);
        }

        public TipoEjercicio obtenerTiposEjercicioPorId(int id)
        {
            return TipoEjercicioManager.obtenerTipoEjercicioPorId(context, id);
        }

        public void guardarTiposEjercicio(TipoEjercicio tipoEjercicio)
        {
            if (tipoEjercicio.idTipoEjercicio != 0)
                TipoEjercicioManager.modificarTipoEjercicio(context, tipoEjercicio);
            else
                TipoEjercicioManager.agregarTipoEjercicios(context, tipoEjercicio);
        }

        public void eliminarTiposEjercicio(TipoEjercicio tipoEjercicio)
        {
            TipoEjercicioManager.eliminarTipoEjercicio(context, tipoEjercicio);
        }

    }
}
