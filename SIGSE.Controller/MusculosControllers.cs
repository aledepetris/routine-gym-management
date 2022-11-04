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
    public class MuculosController
    {

        private static MuculosController instancia;
        public static MuculosController obtenerInstancia()
        {
            if (instancia == null)
                instancia = new MuculosController();
            return instancia;
        }

        SigseContext context;
        Sesion sesion;

        private MuculosController()
        {
            context = SigseContext.obtenerInstancia();
            sesion = Sesion.obtenerSesion();
        }

        public Usuario obtenerSesionUsuario()
        {
            return sesion.currentUser;
        }

        public List<Musculo> obtene()
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
