using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class TipoEntrenamientoManager
    {
        public static List<Entities.TipoEntrenamiento> obtenerTipoEntrenamientos(Context.SigseContext sigseContext)
        {
            return sigseContext.tipos_entrenamientos.ToList();
        }

        public static Entities.TipoEntrenamiento obtenerTipoEntrenamientoPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.tipos_entrenamientos.Where(p => p.idTipoEntrenamiento == id)
                .Include(x => x.tipos_ejercicios)
                .FirstOrDefault();
        }

        public static void agregarTipoEntrenamientos(Context.SigseContext sigseContext, Entities.TipoEntrenamiento ejercicio)
        {
            sigseContext.tipos_entrenamientos.Add(ejercicio);
            sigseContext.SaveChanges();
        }

        public static void modificarTipoEntrenamiento(Context.SigseContext sigseContext, Entities.TipoEntrenamiento ejercicio)
        {
            sigseContext.Entry(ejercicio).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarTipoEntrenamiento(Context.SigseContext sigseContext, Entities.TipoEntrenamiento ejercicio)
        {
            sigseContext.tipos_entrenamientos.Remove(ejercicio);
            sigseContext.SaveChanges();
        }

    }

}
