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
    public partial class FrmCiclo : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private CiclosController cCiclos;
        String ACCION;

        Alumno alumno;
        Ciclo ciclo;

        public FrmCiclo(Alumno _alumno)
        {
            this.alumno = _alumno;
            InitializeComponent();
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            ACCION = "A";
        }

        public FrmCiclo(Ciclo _ciclo)
        {
            this.ciclo = _ciclo;
            InitializeComponent();
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            ACCION = "M";



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona;

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "")
            {
                MetroMessageBox.Show(this, "Complete los campos obligatorios", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            if (cbxTipoPersona.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Tipo de Persona", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            if (!int.TryParse(txtDNI.Text, out int dni))
            {
                MetroMessageBox.Show(this, "El DNI ingresado no es correcto", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }

            if (ACCION == "A")
            {
                if (cbxTipoPersona.SelectedIndex == 0)
                {
                    nuevaPersona = new Alumno();

                }
                else
                {
                    nuevaPersona = new Profesor();
                }
            }
            else
                //nuevaPersona = gPersona;
                        
           /* nuevaPersona.DNI = dni;
            nuevaPersona.nombre = txtNombre.Text;
            nuevaPersona.apellido = txtApellido.Text;
            nuevaPersona.telefono = txtTelefono.Text;
            nuevaPersona.fechaNacimiento = dtpFechaNacimiento.Value;
            nuevaPersona.mail = txtEmail.Text;*/

            //cCiclos.guardarPersona(nuevaPersona);


            MetroMessageBox.Show(this, "Persona creada correctamente ", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
