using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmCambiarPassword : MetroFramework.Forms.MetroForm
    {

        private Usuario currentUser;
        private HomeController cHome;

        public FrmCambiarPassword()
        {
            InitializeComponent();
            cHome = HomeController.obtenerInstancia();
            currentUser = cHome.obtenerSesionUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool result = cHome.cambiarPassword(currentUser, txtPassword.Text, txtNuevaPassword.Text, txtRepetirPassword.Text);

            if (result)
            {
                MetroMessageBox.Show(this, "Exito", "Cambio de Contraseña",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information,
                        100);
                this.Close();
            }
            else
            { 
                MetroMessageBox.Show(this, "Exito", "Cambio de Contraseña",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error,
                        100);
                txtNuevaPassword.Text = "";
                txtPassword.Text = "";
                txtRepetirPassword.Text = "";
            }



        }
    }
}
