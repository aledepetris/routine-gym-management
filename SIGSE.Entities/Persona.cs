using System;
using System.Collections.Generic;
using System.Linq;

namespace SIGSE.Entities
{
    public abstract class Persona
    {
        public int idPersona { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }

    }

    public class Alumno : Persona
    {
        public DateTime fechaInicio { get; set; }
        public bool activo { get; set; }
        public List<Medida> medidas { get; set; }
        public List<Ciclo> planEntrenamiento { get; set; }

    }

    public class Profesor : Persona
    {
        public List<Alumno> alumnos { get; set; }

        public void crearListaAlumnos()
        {
            alumnos = new List<Alumno>();
        }

        public void agregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public IList<Alumno> obtenerAlumnos()
        {
            return alumnos.ToArray();
        }
    }
}
