using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class TipoEjercicioManager
    {
        public static List<Entities.TipoEjercicio> obtenerTipoEjercicios(Context.SigseContext sigseContext)
        {
            return sigseContext.tipos_ejercicios.ToList();
        }

        public static Entities.TipoEjercicio obtenerTipoEjercicioPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.tipos_ejercicios.Where(p => p.idTipoEjercicio == id)
                .FirstOrDefault();
        }

        public static Entities.TipoEjercicio obtenerTipoEjercicioPorNombre(Context.SigseContext sigseContext, string nombre)
        {
            return sigseContext.tipos_ejercicios.Where(p => p.nombre == nombre)
                .FirstOrDefault();
        }
        
        public static void agregarTipoEjercicios(Context.SigseContext sigseContext, Entities.TipoEjercicio ejercicio)
        {
            sigseContext.tipos_ejercicios.Add(ejercicio);
            sigseContext.SaveChanges();
        }

        public static void modificarTipoEjercicio(Context.SigseContext sigseContext, Entities.TipoEjercicio ejercicio)
        {
            sigseContext.Entry(ejercicio).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }

        public static void eliminarTipoEjercicio(Context.SigseContext sigseContext, Entities.TipoEjercicio ejercicio)
        {
            sigseContext.tipos_ejercicios.Remove(ejercicio);
            sigseContext.SaveChanges();
        }

        public static Entities.TipoEjercicio obtenerTiposEjercicioPorNombre(Context.SigseContext sigseContext, string name)
        {
            return sigseContext.tipos_ejercicios.Where(p => p.nombre == name)
                .FirstOrDefault();                
        }
    }
}
