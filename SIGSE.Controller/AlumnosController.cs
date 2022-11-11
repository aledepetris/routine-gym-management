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
    public class AlumnosController
    {

        private static AlumnosController instancia;
        public static AlumnosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new AlumnosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private AlumnosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Alumno> obtenerListaAlumnosDelProfesor()
        {
            Profesor profesor = (Profesor) sesion.currentUser.persona;
            return PersonaManager.obtenerAlumnosDelProfesor(context, profesor);
        }

        public bool existeAlumno(string dni)
        {
            Persona pers = PersonaManager.obtenerPesonaPorDni(context, dni);
            if (pers == null)
                return false;
            return true;

        }

        public bool estaAsignado(string dni)
        {
            if (PersonaManager.alumnoEstaAsignadoAProfesor(context, dni) == null)
                return false;
            return true;
        }

        public void asignarAlumno(string dni)
        {
            Profesor profesor = (Profesor) sesion.currentUser.persona;
            Alumno alumno = (Alumno)PersonaManager.obtenerPesonaPorDni(context, dni);
            profesor.agregarAlumno(alumno);
            PersonaManager.modificarPersona(context, profesor);
        }

        public void desasignarAlumno(Alumno alumno)
        {
            Profesor profesor = (Profesor)sesion.currentUser.persona;
            profesor.alumnos.Remove(alumno);
            PersonaManager.modificarPersona(context, profesor);
        }               

        public Alumno obtenerAlumno(int id)
        {
            return (Alumno) PersonaManager.obtenerAlumnoPorId(context, id);
        }

        public void modificarAlumno(Alumno alumno)
        {
            PersonaManager.modificarPersona(context, alumno);
        }

        public void removerMedidaEnAlumno(Alumno alumno, int id)
        {
            PersonaManager.removerMedidaEnAlumno(context, alumno, id);
        }
    }
}
