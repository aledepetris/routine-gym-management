using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class MusculoManager
    {
        public static List<Entities.Musculo> obtenerMusculos(Context.SigseContext sigseContext)
        {
            return sigseContext.musculos.ToList();
        }

        public static Entities.Musculo obtenerMusculoPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.musculos.SingleOrDefault(p => p.idMusculo == id);
        }

        public static void agregarMusculos(Context.SigseContext sigseContext, Entities.Musculo musculo)
        {
            sigseContext.musculos.Add(musculo);
            sigseContext.SaveChanges();
        }

        public static void modificarMusculo(Context.SigseContext sigseContext, Entities.Musculo musculo)
        {
            sigseContext.Entry(musculo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarMusculo(Context.SigseContext sigseContext, Entities.Musculo musculo)
        {
            sigseContext.musculos.Remove(musculo);
            sigseContext.SaveChanges();
        }

    }

}
