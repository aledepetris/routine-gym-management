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
    public partial class FrmObjetivos : MetroFramework.Forms.MetroForm
    {

        private Usuario currentUser;
        private ObjetivosController cObjetivos;
        string ACCION;

        public FrmObjetivos()
        {
            cObjetivos = ObjetivosController.obtenerInstancia();
            currentUser = cObjetivos.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(true);
            cargarLista();
            txtIdObjetivo.Text = "#";
            ACCION = "A";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ACCION = "M";
            if (gridObjetivos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un objetivo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            int id = int.Parse(gridObjetivos.SelectedItems[0].Text);
            Objetivo objetivo = cObjetivos.obtenerObjetivoPorId(id);

            gbFrmObjetivo.Visible = true;
            txtIdObjetivo.Text = objetivo.idObjetivo.ToString();
            txtNombre.Text = objetivo.nombre;
            txtDescripcion.Text = objetivo.descripcion;
            numMinimos.Value = objetivo.diasMinimo;
            numMaximos.Value = objetivo.diasMaximo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridObjetivos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un objetivo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridObjetivos.SelectedItems[0].Text);
            Objetivo objetivo = cObjetivos.obtenerObjetivoPorId(id);

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar el objetivo?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                cObjetivos.eliminarObjetivo(objetivo);
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
            Objetivo objetivo;

            #region Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
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
                objetivo = new Objetivo();
            }
            else
            {
                objetivo = cObjetivos.obtenerObjetivoPorId(int.Parse(txtIdObjetivo.Text));
            }

            objetivo.nombre = txtNombre.Text;
            objetivo.descripcion = txtDescripcion.Text;
            objetivo.diasMinimo = (int) numMinimos.Value;
            objetivo.diasMaximo = (int) numMaximos.Value;

            cObjetivos.guardarObjetivo(objetivo);

            limpiarFormDejarVisible(false);
            cargarLista();
        }

        private void limpiarFormDejarVisible(bool visible)
        {
            gbFrmObjetivo.Visible = visible;
            txtIdObjetivo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            numMaximos.Value = 0;
            numMinimos.Value = 0;
        }

        private void cargarLista()
        {
            gridObjetivos.Items.Clear();
            List<Objetivo> listaObjetivos = cObjetivos.obtenerListaObjetivos();

            foreach (Objetivo objetivo in listaObjetivos)
            {
                string[] row =
                {
                    objetivo.idObjetivo.ToString(),
                    objetivo.nombre,
                    objetivo.diasMinimo.ToString(),
                    objetivo.diasMaximo.ToString()
                };

                var listViewItem = new ListViewItem(row);
                gridObjetivos.Items.Add(listViewItem);
            }
        }

        private void FrmObjetivos_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}
