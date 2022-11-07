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
    public class ObjetivosController
    {

        private static ObjetivosController instancia;
        public static ObjetivosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new ObjetivosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private ObjetivosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Objetivo> obtenerListaObjetivos()
        {
            return ObjetivoManager.obtenerObjetivos(context);
        }

        public Objetivo obtenerObjetivoPorId(int id)
        {
            return ObjetivoManager.obtenerObjetivoPorId(context, id);
        }

        public void guardarObjetivo(Objetivo objetivo)
        {
            if (objetivo.idObjetivo != 0)
                ObjetivoManager.modificarObjetivo(context, objetivo);
            else
                ObjetivoManager.agregarObjetivos(context, objetivo);
        }

        public void eliminarObjetivo(Objetivo objetivo)
        {
            ObjetivoManager.eliminarObjetivo(context, objetivo);
        }

    }
}
