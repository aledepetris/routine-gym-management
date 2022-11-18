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
    public class CiclosController
    {

        private static CiclosController instancia;
        public static CiclosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new CiclosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private CiclosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public Ciclo obtenerCiclo(int id) 
        {
            return CicloManager.obtenerCicloPorId(context, id);
        }

        public bool eliminarCiclo(Ciclo ciclo)
        {
            CicloManager.eliminarCiclo(context, ciclo);
            return true;
        }

        public void modificarCiclo(Alumno alumno, Ciclo oCiclo, DateTime inicio, Objetivo objetivo, int cantSemanas, TipoEntrenamiento tipoEntrenamiento, int cantDias)
        {
            CicloManager.modificarCiclo(context, alumno, oCiclo, inicio, objetivo, cantSemanas, tipoEntrenamiento, cantDias);
            PersonaManager.actualizarCiclosAlumnos();
        }

        public List<TipoEntrenamiento> obtenerListaTiposEntrenamientos(Objetivo objetivo, int cantDias)
        {
            return TipoEntrenamientoManager.obtenerTipoEntrenamientos(context, objetivo, cantDias);
        }

        public List<Objetivo> obtenerListaObjetivos()
        {
            return ObjetivoManager.obtenerObjetivos(context);
        }

        public void modificarAlumno(Alumno alumno)
        {
            PersonaManager.modificarPersona(context, alumno);
        }

        public void agregarNuevoCiclo(Alumno alumno, Ciclo ciclo)
        {
            alumno.planEntrenamiento.Add(ciclo);
            PersonaManager.modificarPersona(context, alumno);
            PersonaManager.actualizarCiclosAlumnos();
        }

        public List<Ejercicio> obtenerEjerciciosSegunTipoEntrenamiento(TipoEntrenamiento tipoEnt)
        {
            return EjercicioManager.obtenerEjerciciosSegunTipoEntrenamiento(context, tipoEnt);
        }

        public void agregarNuevoEjercicioAlCiclo(EjercicioIntensidad ej, Ciclo ciclo, int semana, int dia)
        {
            CicloManager.agregarNuevoEjercicioAlCiclo(context, ej, ciclo, semana, dia);
        }

        public EjercicioIntensidad obtenerEjercicioIntencidad(int id)
        {
            return EjercicioIntensidadManager.obtenerEjercicioIntensidadPorId(context, id);
        }

        public void modificarEjercicioIntensidad(EjercicioIntensidad ej)
        {
            EjercicioIntensidadManager.modificarEjercicioIntensidad(context, ej);
        }

        public void eliminarEjercicioIntensidad(EjercicioIntensidad ej)
        {
            EjercicioIntensidadManager.eliminarEjercicioIntensidad(context, ej);
        }

        public void cambiarEstadoSemana(Ciclo ciclo, Semana semanaActual, EstadoSemana estado) 
        {
            CicloManager.cambiarEstadoSemana(context, ciclo ,semanaActual, estado);
        }

    }
}
