using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class PersonaManager
    {

        public static void actualizarCiclosAlumnos()
        {
            SIGSE.Context.SigseContext context = SIGSE.Context.SigseContext.obtenerInstancia();

            List<Entities.Alumno> listaAlumnos = context.personas.OfType<Entities.Alumno>()
                .Include(x => x.medidas)
                .Include(x => x.planEntrenamiento.Select(o => o.tipo_entrenamiento))
                .Include(x => x.planEntrenamiento.Select(o => o.objetivo))
                .Include(x => x.planEntrenamiento
                .Select(p => p.semanas
                .Select(s => s.dias
                .Select(d => d.ejercicios)))).ToList();

            foreach (Entities.Alumno al in listaAlumnos)
            {
                foreach (Entities.Ciclo ciclo in al.planEntrenamiento)
                {
                    if (ciclo.estado == Entities.EstadoCiclo.PENDIENTE) 
                    {
                        if (ciclo.fecha_inicio <= DateTime.Today)
                        {
                            ciclo.estado = Entities.EstadoCiclo.EN_CURSO;
                            context.Entry(al).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                        }

                        if (ciclo.calcularFechaFin() <= DateTime.Today)
                        {
                            ciclo.estado = Entities.EstadoCiclo.COMPLETO;
                            context.Entry(al).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                        }
                    }

                    if (ciclo.estado == Entities.EstadoCiclo.EN_CURSO)
                    {
                        if (ciclo.calcularFechaFin() <= DateTime.Today)
                        {
                            ciclo.estado = Entities.EstadoCiclo.COMPLETO;
                        }
                    }

                    if (ciclo.estado == Entities.EstadoCiclo.CANCELADO)
                    {
                        foreach (Entities.Semana sem in ciclo.semanas)
                        {
                            sem.estado = Entities.EstadoSemana.CANCELADA;
                        }
                    }

                    foreach (Entities.Semana sem in ciclo.semanas)
                    {
                       if (sem.estado == Entities.EstadoSemana.PENDIENTE)
                       {
                            if (sem.fecha_inicio <= DateTime.Today)
                            {
                                sem.estado = Entities.EstadoSemana.EN_CURSO;
                            }                            
                       }

                       if (sem.estado == Entities.EstadoSemana.EN_CURSO)
                       {
                            if (sem.calcularFechaFin() <= DateTime.Today)
                            {
                                sem.estado = Entities.EstadoSemana.COMPLETA;
                            }
                        }

                    }
                }
            }                        
        }

        public static List<Entities.Persona> obtenerPesonas(Context.SigseContext sigseContext)
        {
            return sigseContext.personas.ToList();
        }

        public static Entities.Persona obtenerPesonaPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.personas.SingleOrDefault(p => p.idPersona == id);
        }

        public static Entities.Persona obtenerPesonaPorDni(Context.SigseContext sigseContext, string dni)
        {
            int DNI = int.Parse(dni);
            return sigseContext.personas.SingleOrDefault(p => p.DNI == DNI);
        }

        public static Entities.Persona obtenerPesonaPorEmail(Context.SigseContext sigseContext, string email)
        {
            return sigseContext.personas.SingleOrDefault(p => p.mail == email);
        }

        public static void agregarPersonas(Context.SigseContext sigseContext, Entities.Persona persona)
        {
            sigseContext.personas.Add(persona);
            sigseContext.SaveChanges();
        }

        public static void modificarPersona(Context.SigseContext sigseContext, Entities.Persona persona)
        {
            sigseContext.Entry(persona).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarPersona(Context.SigseContext sigseContext, Entities.Persona persona)
        {
            sigseContext.personas.Remove(persona);
            sigseContext.SaveChanges();
        }

        public static Entities.Persona alumnoEstaAsignadoAProfesor(Context.SigseContext sigseContext, string dni)
        {
            List<Entities.Persona> personas =  sigseContext.personas.ToList();
            List<Entities.Profesor> profesores = new List<Entities.Profesor>();
            int DNI = int.Parse(dni);

            foreach (Entities.Persona pers in personas)
            {
                if (pers.GetType().Name == "Profesor")
                    profesores.Add((Entities.Profesor)pers);
            }

            foreach (Entities.Profesor prof in profesores)
            {
                foreach (Entities.Alumno a in prof.alumnos)
                {
                    if (DNI == a.DNI)
                        return a;
                }
            }

            return null;
        }

        public static Entities.Alumno obtenerAlumnoPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.personas.OfType<Entities.Alumno>()
                .Where(x => x.idPersona == id)
                .Include(x => x.medidas)
                .Include(x => x.planEntrenamiento.Select(o => o.tipo_entrenamiento))
                .Include(x => x.planEntrenamiento.Select(o => o.objetivo))
                .Include(x => x.planEntrenamiento
                .Select(p => p.semanas
                .Select(s => s.dias
                .Select(d => d.ejercicios))))
                .FirstOrDefault();
        }

        public static void removerMedidaEnAlumno(Context.SigseContext sigseContext, Entities.Alumno alumno,int id)
        {
            Entities.Medida medida = sigseContext.medidas.FirstOrDefault(x => x.IdMedida == id);
            alumno.medidas.Remove(medida);
            modificarPersona(sigseContext, alumno);
        }

        public static List<Entities.Alumno> obtenerAlumnosDelProfesor(Context.SigseContext sigseContext, Entities.Profesor profesor)
        {
            Entities.Profesor profesor1 = sigseContext.personas.OfType<Entities.Profesor>()
                .Where(x => x.idPersona == profesor.idPersona)
                .Include(x => x.alumnos.Select(a => a.medidas))
                .FirstOrDefault();

            return profesor1.alumnos;
        }
    }
}
