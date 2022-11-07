using System;
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
using MetroFramework;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmTipoEjercicios : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private TiposEjerciciosController cTiposEjercicios;
        string ACCION;

        public FrmTipoEjercicios()
        {
            cTiposEjercicios = TiposEjerciciosController.obtenerInstancia();
            currentUser = cTiposEjercicios.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(true);
            cargarLista();
            txtIdTipoEjercicio.Text = "#";
            ACCION = "A";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ACCION = "M";
            if (gridTiposEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Tipo de Ejercicio de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            int id = int.Parse(gridTiposEjercicios.SelectedItems[0].Text);
            TipoEjercicio tipoEjercicio = cTiposEjercicios.obtenerTiposEjercicioPorId(id);

            gbFrmTipoEjercicio.Visible = true;
            txtIdTipoEjercicio.Text = tipoEjercicio.idTipoEjercicio.ToString();
            txtNombre.Text = tipoEjercicio.nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridTiposEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un objetivo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridTiposEjercicios.SelectedItems[0].Text);
            TipoEjercicio tipoEjercicio = cTiposEjercicios.obtenerTiposEjercicioPorId(id);

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar el objetivo?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                cTiposEjercicios.eliminarTiposEjercicio(tipoEjercicio);
                cargarLista();
                return;
            }
            cargarLista();
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TipoEjercicio tipoEjercicio;
            
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

            if (ACCION == "A")
            {
                tipoEjercicio = new TipoEjercicio();
            }
            else
            {
                tipoEjercicio = cTiposEjercicios.obtenerTiposEjercicioPorId(int.Parse(txtIdTipoEjercicio.Text));
            }

            tipoEjercicio.nombre = txtNombre.Text;

            cTiposEjercicios.guardarTiposEjercicio(tipoEjercicio);

            limpiarFormDejarVisible(false);
            cargarLista();
        }

        private void limpiarFormDejarVisible(bool visible)
        {
            gbFrmTipoEjercicio.Visible = visible;
            txtIdTipoEjercicio.Text = "";
            txtNombre.Text = "";
        }

        private void cargarLista()
        {
            gridTiposEjercicios.Items.Clear();
            List<TipoEjercicio> listaTipoEjercicio = cTiposEjercicios.obtenerListaTiposEjercicios();

            foreach (TipoEjercicio tipoEjercicio in listaTipoEjercicio)
            {
                string[] row =
                {
                    tipoEjercicio.idTipoEjercicio.ToString(),
                    tipoEjercicio.nombre,
                };

                var listViewItem = new ListViewItem(row);
                gridTiposEjercicios.Items.Add(listViewItem);
            }
        }

        private void FrmTipoEjercicios_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}
