using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class CicloManager
    {
        public static List<Entities.Ciclo> obtenerCiclos(Context.SigseContext sigseContext)
        {
            return sigseContext.ciclos.ToList();
        }

        public static Entities.Ciclo obtenerCicloPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.ciclos.Where(x => x.idCiclo == id)
                .Include(x => x.semanas
                .Select(b => b.dias
                .Select(d => d.ejercicios
                .Select(e => e.ejercicio))))
                .FirstOrDefault();
        }
    

        public static void agregarCiclos(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            sigseContext.ciclos.Add(ciclo);
            sigseContext.SaveChanges();
        }

        public static bool eliminarCiclo(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            
            foreach (var semana in ciclo.semanas)
            {
                List<Entities.Dia> dias = semana.dias.ToList();
                foreach (var dia in dias)
                {
                    dia.ejercicios.ToList().ForEach(e => sigseContext.ejercicios_instesidad.Remove(e));
                }
                dias.ForEach(p => sigseContext.dias.Remove(p));

            }

            sigseContext.semanas.RemoveRange(ciclo.semanas);
            sigseContext.ciclos.Remove(ciclo);
            sigseContext.SaveChanges();

            return true;

        }


        public static void modificarCiclo(Context.SigseContext sigseContext, Entities.Alumno alumno, Entities.Ciclo oCiclo, DateTime inicio, Entities.Objetivo oObjetivo, int cantSemanas, Entities.TipoEntrenamiento oTipoEntrenamiento, int cantDias)
        {
            oCiclo.tipo_entrenamiento = oTipoEntrenamiento;
            oCiclo.objetivo = oObjetivo;

            if (oCiclo.cant_dias != cantDias || oCiclo.semanas.Count != cantSemanas)
            {
                oCiclo.fecha_inicio = inicio;
                oCiclo.cant_dias = cantDias;

                foreach (var semana in oCiclo.semanas)
                {
                    List<Entities.Dia> ddias = semana.dias.ToList();
                    foreach (var dia in ddias)
                    {
                        dia.ejercicios.ToList().ForEach(e => sigseContext.ejercicios_instesidad.Remove(e));
                    }
                    ddias.ForEach(p => sigseContext.dias.Remove(p));
                }

                oCiclo.semanas.ToList().ForEach(s => sigseContext.semanas.Remove(s));

                for (int i = 0; i < cantSemanas; i++)
                {
                    var semana = new Entities.Semana(cantDias);
                    oCiclo.semanas.Add(semana);
                }
            }
            alumno.planEntrenamiento.Add(oCiclo); 
            sigseContext.Entry(alumno).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();

        }

        public static void agregarNuevoEjercicioAlCiclo(Context.SigseContext sigseContext, Entities.EjercicioIntensidad ej, Entities.Ciclo ciclo, int semana, int dia)
        {
            ciclo.semanas[semana].dias[dia].ejercicios.Add(ej);
            sigseContext.Entry(ciclo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void cambiarEstadoSemana(Context.SigseContext sigseContext, Entities.Ciclo ciclo, Entities.Semana semanaActual, Entities.EstadoSemana estado)
        {

            if(semanaActual.estado == estado)
            {
                throw new Exception("No es posible cambiar a al mismo estado");
            }

            if(semanaActual.estado == Entities.EstadoSemana.BORRADOR)
            {
                if(estado != Entities.EstadoSemana.PENDIENTE)
                {
                    throw new Exception("No es posible cambiar a ese estado");
                }
            }

            if (semanaActual.estado == Entities.EstadoSemana.PENDIENTE)
            {
                if (estado != Entities.EstadoSemana.POSPUESTA)
                {
                    throw new Exception("No es posible cambiar a ese estado");
                }
                else
                {
                    int index = ciclo.semanas.IndexOf(semanaActual);

                    Entities.Semana s = new Entities.Semana();
                    s.estado = Entities.EstadoSemana.BORRADOR;
                    s.fecha_inicio = semanaActual.fecha_inicio.AddDays(7);
                    s.orden = semanaActual.orden + 1;

                    foreach (Entities.Dia dd in semanaActual.dias)
                    {
                        List<Entities.EjercicioIntensidad> ejercicioIntensidads = new List<Entities.EjercicioIntensidad>();

                        foreach (Entities.EjercicioIntensidad ej in dd.ejercicios)
                        {
                            Entities.EjercicioIntensidad nuevoEj = new Entities.EjercicioIntensidad();
                            nuevoEj.ejercicio = ej.ejercicio;
                            nuevoEj.descanso = ej.descanso;
                            nuevoEj.notas = ej.notas;
                            nuevoEj.peso = ej.peso;
                            nuevoEj.repeticiones = ej.repeticiones;
                            nuevoEj.series = ej.series;
                            ejercicioIntensidads.Add(nuevoEj);
                        }

                        Entities.Dia nuevodia = new Entities.Dia();
                        nuevodia.ejercicios.AddRange(ejercicioIntensidads);
                        s.dias.Add(nuevodia);
                    }

                    ciclo.semanas.Insert(index + 1, s);
                    int ii = 0;
                    foreach (Entities.Semana sss in ciclo.semanas)
                    {
                        sss.fecha_inicio = ciclo.fecha_inicio.AddDays(ii * 7);
                        sss.orden = ii + 1;
                        ii++;
                    }
                }
            }

            if (semanaActual.estado == Entities.EstadoSemana.EN_CURSO)
            {
                if (estado != Entities.EstadoSemana.POSPUESTA)
                {
                    throw new Exception("No es posible cambiar a ese estado");
                }
                else
                {
                    int index = ciclo.semanas.IndexOf(semanaActual);

                    Entities.Semana s = new Entities.Semana();
                    s.estado = Entities.EstadoSemana.BORRADOR;
                    s.fecha_inicio = semanaActual.fecha_inicio.AddDays(7);
                    s.orden = semanaActual.orden + 1;

                    foreach (Entities.Dia dd in semanaActual.dias)
                    {
                        List<Entities.EjercicioIntensidad> ejercicioIntensidads = new List<Entities.EjercicioIntensidad>();

                        foreach (Entities.EjercicioIntensidad ej in dd.ejercicios)
                        {
                            Entities.EjercicioIntensidad nuevoEj = new Entities.EjercicioIntensidad();
                            nuevoEj.ejercicio = ej.ejercicio;
                            nuevoEj.descanso = ej.descanso;
                            nuevoEj.notas = ej.notas;
                            nuevoEj.peso = ej.peso;
                            nuevoEj.repeticiones = ej.repeticiones;
                            nuevoEj.series = ej.series;
                            ejercicioIntensidads.Add(nuevoEj);
                        }

                        Entities.Dia nuevodia = new Entities.Dia();
                        nuevodia.ejercicios.AddRange(ejercicioIntensidads);
                        s.dias.Add(nuevodia);
                    }

                    ciclo.semanas.Insert(index + 1, s);
                    int ii = 0;
                    foreach(Entities.Semana sss in ciclo.semanas)
                    {
                        sss.fecha_inicio = ciclo.fecha_inicio.AddDays(ii * 7);
                        sss.orden = ii + 1;
                    }
                }
            }

            semanaActual.estado = estado;
            sigseContext.Entry(ciclo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
            return;
        }



    }

}
