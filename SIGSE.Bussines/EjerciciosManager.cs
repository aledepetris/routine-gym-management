using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class EjercicioManager
    {
        public static List<Entities.Ejercicio> obtenerEjercicios(Context.SigseContext sigseContext)
        {
            return sigseContext.ejercicios.ToList();
        }

        public static Entities.Ejercicio obtenerEjercicioPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.ejercicios.Where(p => p.idEjercicio == id)
                .Include(x => x.tipos_ejercicios)
                .Include(x => x.musculos)
                .FirstOrDefault();
        }

        public static void agregarEjercicios(Context.SigseContext sigseContext, Entities.Ejercicio ejercicio)
        {
            sigseContext.ejercicios.Add(ejercicio);
            sigseContext.SaveChanges();
        }

        public static void modificarEjercicio(Context.SigseContext sigseContext, Entities.Ejercicio ejercicio)
        {
            sigseContext.Entry(ejercicio).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarEjercicio(Context.SigseContext sigseContext, Entities.Ejercicio ejercicio)
        {
            sigseContext.ejercicios.Remove(ejercicio);
            sigseContext.SaveChanges();
        }

        public static List<Entities.Ejercicio> obtenerEjerciciosSegunTipoEntrenamiento(Context.SigseContext sigseContext, Entities.TipoEntrenamiento tipoEnt)
        {
            Entities.TipoEntrenamiento tipoEntrenamiento = sigseContext.tipos_entrenamientos
                .Where(x => x.idTipoEntrenamiento == tipoEnt.idTipoEntrenamiento)
                .Include(x => x.tipos_ejercicios)
                .FirstOrDefault();

            List<Entities.Ejercicio> totalEjercicios = sigseContext.ejercicios
                .Include(x => x.tipos_ejercicios)
                .ToList();

            HashSet<Entities.Ejercicio> ejerciciosReturn = new HashSet<Entities.Ejercicio>();
            
            foreach (Entities.Ejercicio ej in totalEjercicios)
            {
                foreach (Entities.TipoEjercicio tEj in ej.tipos_ejercicios)
                {
                    foreach (Entities.TipoEjercicio tEj2 in tipoEntrenamiento.tipos_ejercicios)
                    {
                        if (tEj2.idTipoEjercicio == tEj.idTipoEjercicio)
                        {
                            ejerciciosReturn.Add(ej);
                        }
                    }
                }
            }

            return ejerciciosReturn.ToList();

        }

    }

}
