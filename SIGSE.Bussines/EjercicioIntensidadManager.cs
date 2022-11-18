using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class EjercicioIntensidadManager
    {
        public static List<Entities.EjercicioIntensidad> obtenerEjercicioIntensidads(Context.SigseContext sigseContext)
        {
            return sigseContext.ejercicios_instesidad.ToList();
        }

        public static Entities.EjercicioIntensidad obtenerEjercicioIntensidadPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.ejercicios_instesidad.Where(p => p.idEjercicioIntensidad == id)
                .Include(x => x.ejercicio)
                .FirstOrDefault();
        }

        public static void agregarEjercicioIntensidads(Context.SigseContext sigseContext, Entities.EjercicioIntensidad ejercicios_instesidad)
        {
            sigseContext.ejercicios_instesidad.Add(ejercicios_instesidad);
            sigseContext.SaveChanges();
        }

        public static void modificarEjercicioIntensidad(Context.SigseContext sigseContext, Entities.EjercicioIntensidad ejercicios_instesidad)
        {
            sigseContext.Entry(ejercicios_instesidad).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarEjercicioIntensidad(Context.SigseContext sigseContext, Entities.EjercicioIntensidad ejercicios_instesidad)
        {
            sigseContext.ejercicios_instesidad.Remove(ejercicios_instesidad);
            sigseContext.SaveChanges();
        }

    }

}
