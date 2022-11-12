using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmPlanEntrenamiento : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private CiclosController cCiclos;
        private Alumno alumno;

        public FrmPlanEntrenamiento(Alumno _alumno)
        {
            this.alumno = _alumno;
            this.Text = "Plan Entrenamiento:" + _alumno.nombrecompleto;
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            InitializeComponent();
            cargarLista();
        }

        private void cargarLista()
        {
            gridCiclos.Items.Clear();
            List<Ciclo> listaCiclos = alumno.planEntrenamiento;
            int i = 1;
            foreach (Ciclo ciclo in listaCiclos)
            {
                string[] row =
                {
                    ciclo.idCiclo.ToString(),
                    i.ToString(),
                    ciclo.fecha_inicio.ToShortDateString(),
                    ciclo.calcularFechaFin().ToShortDateString(),
                    ciclo.semanas.ToString(),
                    ciclo.cant_dias.ToString(),
                    ciclo.objetivo.nombre,
                    ciclo.tipo_entrenamiento.nombre,
                    ciclo.estado.ToString()                    
                };
                i++;
                var listViewItem = new ListViewItem(row);
                gridCiclos.Items.Add(listViewItem);
            }
        }

        private void btnAgregarCiclo_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmCiclo(alumno));
        }

        private void btnModificarCiclo_Click(object sender, EventArgs e)
        {
            if (gridCiclos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ciclo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            Utilities.Navegar.OpenNewTab(new FrmCiclo(obtenerCicloSeleccionado()));
            cargarLista();
        }

        private void btnEliminarCiclo_Click(object sender, EventArgs e)
        {
            if (gridCiclos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ciclo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar el Ciclo?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                bool result = cCiclos.eliminarCiclo(alumno, obtenerCicloSeleccionado());

                // Con el resultado si no puedo eliminar informo porque.
            }

        }

        private void btnGestionarCiclo_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmGestionarCiclo(alumno, obtenerCicloSeleccionado()));
        }


        private Ciclo obtenerCicloSeleccionado()
        {
            int id = int.Parse(gridCiclos.SelectedItems[0].Text);
            return cCiclos.obtenerCiclo(id);
        }
    }
}
