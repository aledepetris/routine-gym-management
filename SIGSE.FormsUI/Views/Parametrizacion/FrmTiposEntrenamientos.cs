using System;
using System.Collections.Generic;
using SIGSE.Controller;
using SIGSE.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmTiposEntrenamientos : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private TiposEntrenamientosController cTiposEntrenamientos;
        string ACCION;

        public FrmTiposEntrenamientos()
        {
            cTiposEntrenamientos = TiposEntrenamientosController.obtenerInstancia();
            currentUser = cTiposEntrenamientos.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(true);
            cargarLista();
            txtIdTipoEntrenamiento.Text = "#";
            ACCION = "A";

            lvSinAsignar.Items.Clear();

            List<TipoEjercicio> listaTipoEjercicio = cTiposEntrenamientos.obtenerListaTiposEjercicio();
            foreach (TipoEjercicio tipoEjercicio in listaTipoEjercicio)
                lvSinAsignar.Items.Add(tipoEjercicio.nombre);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ACCION = "M";
            if (gridTipoEntrenamiento.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Tipo de Entrenamiento de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            int id = int.Parse(gridTipoEntrenamiento.SelectedItems[0].Text);
            TipoEntrenamiento tipoEntrenamiento = cTiposEntrenamientos.obtenerTiposEntrenamientoPorId(id);

            gbTipoEntrenamiento.Visible = true;
            txtIdTipoEntrenamiento.Text = tipoEntrenamiento.idTipoEntrenamiento.ToString();
            txtNombre.Text = tipoEntrenamiento.nombre;

            cargarLisViewsAsignaciones(tipoEntrenamiento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridTipoEntrenamiento.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un tipo entrenamiento de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridTipoEntrenamiento.SelectedItems[0].Text);
            TipoEntrenamiento tipoEntrenamiento = cTiposEntrenamientos.obtenerTiposEntrenamientoPorId(id);

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar el tipo entrenamiento?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                cTiposEntrenamientos.eliminarTiposEntrenamiento(tipoEntrenamiento);
                cargarLista();
                return;
            }
            cargarLista();
            return;

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvSinAsignar.SelectedItems;

            foreach (ListViewItem item in lista)
            {
                lvSinAsignar.Items.Remove(item);
                lvAsignado.Items.Add(item);
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvAsignado.SelectedItems;

            foreach (ListViewItem item in lista)
            {
                lvAsignado.Items.Remove(item);
                lvSinAsignar.Items.Add(item);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MetroMessageBox.Show(this, "Complete los campos Obligatorios", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion

            TipoEntrenamiento tipoEntrenamiento;
            if (ACCION == "A")
            {
                tipoEntrenamiento = new TipoEntrenamiento();
            }
            else
            {
                tipoEntrenamiento = cTiposEntrenamientos.obtenerTiposEntrenamientoPorId(int.Parse(txtIdTipoEntrenamiento.Text));
            }

            tipoEntrenamiento.nombre = txtNombre.Text;


            List<TipoEjercicio> tiposEjerciciosAsignadas = new List<TipoEjercicio>();

            foreach (ListViewItem item in lvAsignado.Items)
            {
                tiposEjerciciosAsignadas.Add(cTiposEntrenamientos.obtenerTiposEjercicioPorNombre(item.Text));
            }

            tipoEntrenamiento.tipos_ejercicios = tiposEjerciciosAsignadas;
            cTiposEntrenamientos.guardarTiposEntrenamiento(tipoEntrenamiento);

            MetroMessageBox.Show(this, "Tipo de Entrenamiento creado correctamente", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);

            limpiarFormDejarVisible(false);
        }

        private void limpiarFormDejarVisible(bool visible)
        {
            gbTipoEntrenamiento.Visible = visible;
            txtIdTipoEntrenamiento.Text = "";
            txtNombre.Text = "";
            lvSinAsignar.Items.Clear();
            lvAsignado.Items.Clear();
        }

        private void cargarLista()
        {
            gridTipoEntrenamiento.Items.Clear();
            List<TipoEntrenamiento> listaTipoEntrenamiento = cTiposEntrenamientos.obtenerListaTiposEntrenamientos();

            foreach (TipoEntrenamiento tipoEntrenamiento in listaTipoEntrenamiento)
            {
                string[] row =
                {
                    tipoEntrenamiento.idTipoEntrenamiento.ToString(),
                    tipoEntrenamiento.nombre
                };

                var listViewItem = new ListViewItem(row);
                gridTipoEntrenamiento.Items.Add(listViewItem);
            }

        }

        public void cargarLisViewsAsignaciones(TipoEntrenamiento tipoEntrenamiento)
        {
            lvSinAsignar.Items.Clear();
            lvAsignado.Items.Clear();

            List<TipoEjercicio> tiposEjSinAsignar = cTiposEntrenamientos.obtenerListaTiposEjercicio();

            List<TipoEjercicio> tiposEjAsignados = tipoEntrenamiento.tipos_ejercicios;

            if (tiposEjAsignados != null)
            {
                if (tiposEjAsignados.Count > 0)
                {
                    foreach (TipoEjercicio tipoEjercicio in tiposEjAsignados) 
                    {
                        tiposEjSinAsignar.Remove(tipoEjercicio);
                        lvAsignado.Items.Add(tipoEjercicio.nombre);
                    }
                }

            }

            foreach (TipoEjercicio tipoEjercicio in tiposEjSinAsignar)
                lvSinAsignar.Items.Add(tipoEjercicio.nombre);

        }

        private void FrmTiposEntrenamientos_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

    }
}
