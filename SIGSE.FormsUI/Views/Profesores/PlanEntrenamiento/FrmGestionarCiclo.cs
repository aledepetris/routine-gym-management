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
    public partial class FrmGestionarCiclo : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private HomeController cHome;
        
        public FrmGestionarCiclo(Alumno alumno, Ciclo ciclo)
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
    }
}
