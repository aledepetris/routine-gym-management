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
    public partial class FrmPersona : MetroFramework.Forms.MetroForm
    {
        Persona gPersona;
        private Usuario currentUser;
        private PersonasController cPersonas;
        String ACCION;

        public FrmPersona()
        {

            InitializeComponent();
            cPersonas = PersonasController.obtenerInstancia();
            currentUser = cPersonas.obtenerSesionUsuario();
            ACCION = "A";
        }

        public FrmPersona(Persona persona)
        {

            InitializeComponent();
            cPersonas = PersonasController.obtenerInstancia();
            currentUser = cPersonas.obtenerSesionUsuario();

            ACCION = "M";

            txtIdPersona.Text = persona.idPersona.ToString();
            txtDNI.Text = persona.DNI.ToString();
            txtNombre.Text = persona.nombre.ToString();
            txtApellido.Text = persona.apellido.ToString();
            txtTelefono.Text = persona.telefono.ToString();
            txtEmail.Text = persona.mail.ToString();

            if (persona.sexo.ToString() == "Masculino")
                cbxSexo.SelectedIndex = 0;
            else
                cbxSexo.SelectedIndex = 1;

            if (persona.GetType().Name.ToString() == "Alumno")
                cbxTipoPersona.SelectedIndex = 0;
            else
                cbxTipoPersona.SelectedIndex = 1;

            cbxTipoPersona.Enabled = false;
            dtpFechaNacimiento.Text = persona.fechaNacimiento.ToString();

            gPersona = persona;

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
                nuevaPersona = gPersona;


            nuevaPersona.sexo = cbxSexo.Text;
            nuevaPersona.DNI = dni;
            nuevaPersona.nombre = txtNombre.Text;
            nuevaPersona.apellido = txtApellido.Text;
            nuevaPersona.telefono = txtTelefono.Text;
            nuevaPersona.fechaNacimiento = dtpFechaNacimiento.Value;
            nuevaPersona.mail = txtEmail.Text;

            cPersonas.guardarPersona(nuevaPersona);


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
