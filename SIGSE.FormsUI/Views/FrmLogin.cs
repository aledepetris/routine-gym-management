using SIGSE.FormsUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGSE.Controller;
using MetroFramework;

namespace SIGSE.FormsUI
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {

        private static FrmLogin instancia;
        private static LoginController cLogin;
        public static FrmLogin obtenerInstancia()
        {
            if (instancia == null)
                instancia = new FrmLogin();
            if (instancia.IsDisposed)
                instancia = new FrmLogin();

            return instancia;
        }

        public FrmLogin()
        {
            InitializeComponent();
            cLogin = LoginController.obtenerInstancia();
            txtUsuario.Text = "celi";
            txtPassword.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Entities.Usuario user = cLogin.realizarLogin(txtUsuario.Text, txtPassword.Text);

            if (user == null)
            {
                MetroMessageBox.Show(this, "Las credenciales son incorrectas", "ERROR",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error,
                                    100);
            }
            else if (!user.activo)
            {
                MetroMessageBox.Show(this, "Usuario Inactivo", "INACTIVO",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error,
                                    100);
            }
            else
            {
                if (user.persona is Entities.Alumno)
                    Utilities.Navegar.Open(this, new FrmHomeAlumnos());
                else
                    Utilities.Navegar.Open(this, new FrmHome());

            }
        }

        private void lblOlvidoPass_Click(object sender, EventArgs e)
        {
    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
