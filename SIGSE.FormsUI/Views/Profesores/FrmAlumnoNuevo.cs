using System;
using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
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
    public partial class FrmAlumnoNuevo : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private AlumnosController cAlumnos;

        public FrmAlumnoNuevo()
        {
            cAlumnos = AlumnosController.obtenerInstancia();
            currentUser = cAlumnos.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MetroMessageBox.Show(this, "Complete el campo DNI", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }

            bool existe = cAlumnos.existeAlumno(txtDNI.Text);

            if (!existe)
            {
                MetroMessageBox.Show(this, "El alumno no existe", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }

            bool asignado = cAlumnos.estaAsignado(txtDNI.Text);

            if (asignado)
            {
                MetroMessageBox.Show(this, "El alumno ya se encuentra asignado", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion

            MetroMessageBox.Show(this, "El alumno se asigno correctamente", "Exito!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information,
                    100);

            cAlumnos.asignarAlumno(txtDNI.Text);
            this.Close();

        }
    }
}
