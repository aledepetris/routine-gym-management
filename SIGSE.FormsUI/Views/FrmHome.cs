using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGSE.Entities;
using SIGSE.Controller;


namespace SIGSE.FormsUI.Views
{
    public partial class FrmHome : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private HomeController cHome;

        private static FrmHome instancia;
        public static FrmHome obtenerInstancia()
        {
            if (instancia == null)
                instancia = new FrmHome();
            if (instancia.IsDisposed)
                instancia = new FrmHome();

            return instancia;
        }

        public FrmHome()
        {
            cHome = HomeController.obtenerInstancia();
            currentUser = cHome.obtenerSesionUsuario();
            InitializeComponent();
            lblNombreApellido.Text = currentUser.persona.nombre.ToUpper() + " " + currentUser.persona.apellido.ToUpper();

        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            cHome.realizarLogOut();
            Utilities.Navegar.Open(this, new FrmLogin());
        }

        private void tspGestionarRoles_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new Seguridad.FrmRoles());
        }

        private void tspGestionarUsuarios_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new Seguridad.FrmUsuarios());
        }

        private void tspGestionarPersonas_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new Personas.FrmPersonas());
        }

        private void tspGestionarAlumnos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new Profesores.FrmAlumnos());
        }
    }
}
