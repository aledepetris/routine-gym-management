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
    public class EjerciciosController
    {

        private static EjerciciosController instancia;
        public static EjerciciosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new EjerciciosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private EjerciciosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Ejercicio> obtenerListaEjercicios()
        {
            return EjercicioManager.obtenerEjercicios(context);
        }

        public Ejercicio obtenerEjercicioPorId(int id)
        {
            return EjercicioManager.obtenerEjercicioPorId(context, id);
        }

        public void guardarEjercicio(Ejercicio ejercicio)
        {
            if (ejercicio.idEjercicio != 0)
                EjercicioManager.modificarEjercicio(context, ejercicio);
            else
                EjercicioManager.agregarEjercicios(context, ejercicio);
        }

        public void eliminarEjercicio(Ejercicio ejercicio)
        {
            EjercicioManager.eliminarEjercicio(context, ejercicio);
        }

        public List<Musculo> obtenerListaMusculos()
        {
            return MusculoManager.obtenerMusculos(context);
        }

        public List<TipoEjercicio> obtenerListaTipoEjercicios()
        {
            return TipoEjercicioManager.obtenerTipoEjercicios(context);
        }

        public Musculo obtenerMusculoPorNombre(string nombre)
        {
            return MusculoManager.obtenerMusculoPorNombre(context, nombre);
        }

        public TipoEjercicio obtenerTipoEjercicioPorNombre(string nombre)
        {
            return TipoEjercicioManager.obtenerTipoEjercicioPorNombre(context, nombre);
        }
    }
}
