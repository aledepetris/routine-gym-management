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
    public class TiposEntrenamientosController
    {

        private static TiposEntrenamientosController instancia;
        public static TiposEntrenamientosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new TiposEntrenamientosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private TiposEntrenamientosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<TipoEntrenamiento> obtenerListaTiposEntrenamientos()
        {
            return TipoEntrenamientoManager.obtenerTipoEntrenamientos(context);
        }

        public TipoEntrenamiento obtenerTiposEntrenamientoPorId(int id)
        {
            return TipoEntrenamientoManager.obtenerTipoEntrenamientoPorId(context, id);
        }

        public void guardarTiposEntrenamiento(TipoEntrenamiento tipoEntrenamiento)
        {
            if (tipoEntrenamiento.idTipoEntrenamiento != 0)
                TipoEntrenamientoManager.modificarTipoEntrenamiento(context, tipoEntrenamiento);
            else
                TipoEntrenamientoManager.agregarTipoEntrenamientos(context, tipoEntrenamiento);
        }

        public void eliminarTiposEntrenamiento(TipoEntrenamiento tipoEntrenamiento)
        {
            TipoEntrenamientoManager.eliminarTipoEntrenamiento(context, tipoEntrenamiento);
        }

        public List<TipoEjercicio> obtenerListaTiposEjercicio()
        {
            return TipoEjercicioManager.obtenerTipoEjercicios(context);
        }

        public TipoEjercicio obtenerTiposEjercicioPorNombre(string name)
        {
            return TipoEjercicioManager.obtenerTiposEjercicioPorNombre(context, name);
        }

    }
}
