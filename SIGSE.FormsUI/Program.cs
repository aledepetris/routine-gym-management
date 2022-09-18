using SIGSE.Bussines;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            #region cargaDatos
            Alumno alumno = new Alumno();
            Profesor profesor = new Profesor();

            alumno.activo = true;
            alumno.nombre = "Alejandro";
            alumno.apellido = "Depetris";
            alumno.DNI = 36477909;
            alumno.fechaInicio = DateTime.Today;
            alumno.fechaNacimiento = DateTime.Today;
            alumno.mail = "aledepetris@gmail.com";
            alumno.telefono = "3401418966";


            profesor.nombre = "Celina";
            profesor.apellido = "Reymundo";
            profesor.DNI = 32000000;
            profesor.fechaNacimiento = DateTime.Today;
            profesor.mail = "celirey@gmail.com";
            profesor.telefono = "3401418966";
            profesor.crearListaAlumnos();
            profesor.agregarAlumno(alumno);

            Context.SigseContext sigse = Context.SigseContext.obtenerInstancia();

            PersonaManager.agregarPersonas(sigse, alumno);
            PersonaManager.agregarPersonas(sigse, profesor);

            Usuario user = new Usuario();
            user.activo = true;
            user.username = "aledepetris";
            user.password = "123";
            user.persona = alumno;

            UsuarioManager.agregarUsuario(sigse, user);

            user.username = "celi";
            user.password = "123";
            user.persona = profesor;

            UsuarioManager.agregarUsuario(sigse, user);
            #endregion cargaDatos
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmLogin.obtenerInstancia());
        }
    }
}
