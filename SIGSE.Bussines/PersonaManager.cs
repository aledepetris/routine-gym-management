using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class PersonaManager
    {
        public static List<Entities.Persona> obtenerPesonas(Context.SigseContext sigseContext)
        {
            return sigseContext.personas.ToList();
        }

        public static Entities.Persona obtenerPesonaPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.personas.SingleOrDefault(p => p.idPersona == id);
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
    }
}
