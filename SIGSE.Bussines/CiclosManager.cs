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
            return sigseContext.ciclos.Where(p => p.idCiclo == id)
                .FirstOrDefault();
        }

        public static void agregarCiclos(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            sigseContext.ciclos.Add(ciclo);
            sigseContext.SaveChanges();
        }

        public static void modificarCiclo(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            sigseContext.Entry(ciclo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarCiclo(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            sigseContext.ciclos.Remove(ciclo);
            sigseContext.SaveChanges();
        }

    }

}
