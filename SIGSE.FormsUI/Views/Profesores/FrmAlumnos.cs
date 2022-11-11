using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmAlumnos : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private AlumnosController cAlumnos;

        public FrmAlumnos()
        {
            cAlumnos = AlumnosController.obtenerInstancia();
            currentUser = cAlumnos.obtenerSesionUsuario();
            InitializeComponent();
            cargarLista();
        }

        private void cargarLista()
        {
            gridAlumnos.Items.Clear();
            List<Alumno> listaAlumnos = cAlumnos.obtenerListaAlumnosDelProfesor();

            foreach (Alumno alumno in listaAlumnos)
            {
                string active = "No";
                if (alumno.activo)
                    active = "Si";

                string[] row =
                {
                    alumno.idPersona.ToString(),
                    alumno.DNI.ToString(),
                    alumno.nombre,
                    alumno.apellido,
                    alumno.telefono,
                    alumno.mail,
                    active
                };

                var listViewItem = new ListViewItem(row);
                gridAlumnos.Items.Add(listViewItem);
            }
        }


        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmAlumnoNuevo());
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (gridAlumnos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Alumno de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            Utilities.Navegar.OpenNewTab(new FrmAlumnoDetalle(obtenerAlumnoSeleccionado()));
            cargarLista();
        }

        private void btnPlanEntrenamiento_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmPlanEntrenamiento(obtenerAlumnoSeleccionado()));
        }

        private void FrmAlumnos_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private Alumno obtenerAlumnoSeleccionado()
        {
            int id = int.Parse(gridAlumnos.SelectedItems[0].Text);
            return cAlumnos.obtenerAlumno(id);
        }
    }
}
