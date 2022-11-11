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
    public partial class FrmAlumnoDetalle : MetroFramework.Forms.MetroForm
    {
        Alumno alumno;
        private Usuario currentUser;
        private AlumnosController cAlumnos;

        public FrmAlumnoDetalle(Alumno _alumno)
        {
            this.alumno = _alumno;
            inicializarFormulario();
            cargarDatosFormulario();

        }

        private void inicializarFormulario()
        {
            cAlumnos = AlumnosController.obtenerInstancia();
            currentUser = cAlumnos.obtenerSesionUsuario();
            InitializeComponent();
            cargarDatosMedidas();
        }

        private void cargarDatosMedidas()
        {
            gridMedidas.Items.Clear();
            List<Medida> listaMedidas = alumno.medidas;
            int i = 1;
            foreach (Medida medida in listaMedidas)
            {
                string[] row =
                {
                    medida.IdMedida.ToString(),
                    i.ToString(),
                    medida.fecha.ToShortDateString(),
                    medida.altura.ToString(),
                    medida.peso.ToString(),
                    medida.hombro.ToString(),
                    medida.pecho.ToString(),
                    medida.brazo.ToString(),
                    medida.cintura.ToString(),
                    medida.cadera.ToString(),
                    medida.pierna.ToString()
                    
                };
                var listViewItem = new ListViewItem(row);
                gridMedidas.Items.Add(listViewItem);
                i++;
            }
        }

        private void cargarDatosFormulario()
        {
            txtNombre.Text = alumno.nombre;
            txtApellido.Text = alumno.apellido;
            txtEmail.Text = alumno.mail;
            txtTelefono.Text = alumno.telefono.ToString();
            if (alumno.activo)
                cbxActivo.SelectedIndex = 0;
            else
                cbxActivo.SelectedIndex = 1;

            dtpFechaInicio.Value = alumno.fechaInicio;
            dtpFechaNacimiento.Value = (DateTime) alumno.fechaNacimiento;
        }


        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmAlumnoMedida(alumno));
            cargarDatosMedidas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridMedidas.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar una medida de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar esta medida?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(gridMedidas.SelectedItems[0].Text);
                cAlumnos.removerMedidaEnAlumno(alumno, id);
            }
            cargarDatosMedidas();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            alumno.activo = cbxActivo.SelectedIndex == 0;
            alumno.nombre = txtNombre.Text;
            alumno.apellido = txtApellido.Text;
            alumno.mail = txtEmail.Text;
            alumno.fechaInicio = dtpFechaInicio.Value;
            alumno.fechaNacimiento = dtpFechaNacimiento.Value;

            cAlumnos.modificarAlumno(alumno);

            MetroMessageBox.Show(this, "El alumno fue modificado correctamente", "Exito!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);
            this.Close();
        }

        private void btnDesasignarAlumno_Click(object sender, EventArgs e)
        {

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desasignar el Alumno?", "ATENCION!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            100);
            if (dr == DialogResult.Yes)
            {
                cAlumnos.desasignarAlumno(this.alumno);
                this.Close();
            }
        }
    }
}
