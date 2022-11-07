using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class ObjetivoManager
    {
        public static List<Entities.Objetivo> obtenerObjetivos(Context.SigseContext sigseContext)
        {
            return sigseContext.objetivos.ToList();
        }

        public static Entities.Objetivo obtenerObjetivoPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.objetivos.Where(p => p.idObjetivo == id)
                .FirstOrDefault();
        }

        public static void agregarObjetivos(Context.SigseContext sigseContext, Entities.Objetivo ejercicio)
        {
            sigseContext.objetivos.Add(ejercicio);
            sigseContext.SaveChanges();
        }

        public static void modificarObjetivo(Context.SigseContext sigseContext, Entities.Objetivo ejercicio)
        {
            sigseContext.Entry(ejercicio).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarObjetivo(Context.SigseContext sigseContext, Entities.Objetivo ejercicio)
        {
            sigseContext.objetivos.Remove(ejercicio);
            sigseContext.SaveChanges();
        }

    }

}
