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
    public class MusculosController
    {

        private static MusculosController instancia;
        public static MusculosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new MusculosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private MusculosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Musculo> obtenerListaMusculos()
        {
            return MusculoManager.obtenerMusculos(context);
        }

        public Musculo obtenerMusculo(int id)
        {
            return MusculoManager.obtenerMusculoPorId(context, id);
        }

        public void guardarMusculo(Musculo musculo)
        {
            if (musculo.idMusculo != 0)
                MusculoManager.modificarMusculo(context, musculo);
            else
                MusculoManager.agregarMusculos(context, musculo);
        }

        public void eliminarMusculo(Musculo musculo)
        {
            MusculoManager.eliminarMusculo(context, musculo);
        }

    }
}
