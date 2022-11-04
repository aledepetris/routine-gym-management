using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SIGSE.Bussines;
using SIGSE.Context;
using SIGSE.Entities;
using SIGSE.SessionManager;

namespace SIGSE.Controller
{
    public class PersonasController
    {

        private static PersonasController instancia;
        public static PersonasController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new PersonasController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private PersonasController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Persona> obtenerListaPersonas()
        {
            return PersonaManager.obtenerPesonas(context);
        }

        public Persona obtenerPersona(int id)
        {
            return PersonaManager.obtenerPesonaPorId(context, id);
        }

        public void guardarPersona(Persona persona)
        {
            if (persona.idPersona != 0)
                PersonaManager.modificarPersona(context, persona);
            else
                PersonaManager.agregarPersonas(context, persona);
        }

        public void eliminarPersona(Persona persona)
        {
            PersonaManager.eliminarPersona(context, persona);
        }

    }
}
