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
    public class TableroController
    {

        private static TableroController instancia;
        public static TableroController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new TableroController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private TableroController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }


        public List<Ciclo> obtenerCiclos()
        {
            return CicloManager.obtenerCiclos(context);
        }

        public List<Alumno> obtenerAlumnos()
        {
            return PersonaManager.obtenerTodosAlumnos(context);
        }

        public List<Alumno> obtenerAlumnosPorProfesor(Profesor profe)
        {
            return PersonaManager.obtenerAlumnosDelProfesor(context, profe);
        }

        public List<Profesor> obtenerProfesores()
        {
            return PersonaManager.obtenerProfesores(context);
        }

        public Alumno obtenerAlumno(Alumno alum)
        {
            return PersonaManager.obtenerAlumnoPorId(context, alum.idPersona);
        }



    }
}
