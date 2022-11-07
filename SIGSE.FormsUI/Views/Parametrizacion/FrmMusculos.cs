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
    public partial class FrmMusculos : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private MusculosController cMusculos;
        string ACCION;

        public FrmMusculos()
        {
            cMusculos = MusculosController.obtenerInstancia();
            currentUser = cMusculos.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(true);
            cargarLista();
            txtIdMusculos.Text = "#";
            ACCION = "A";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ACCION = "M";
            if (gridMusculos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Músculo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridMusculos.SelectedItems[0].Text);
            Musculo musculo = cMusculos.obtenerMusculo(id);
            gbFrmMusculos.Visible = true;
            txtIdMusculos.Text = musculo.idMusculo.ToString();
            txtNombre.Text = musculo.nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridMusculos.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un músculo de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridMusculos.SelectedItems[0].Text);
            Musculo musculo = cMusculos.obtenerMusculo(id);

            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que desea eliminar el musculo " + musculo.nombre + "?" , "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);
            if (dr == DialogResult.Yes)
            {
                cMusculos.eliminarMusculo(musculo);
                cargarLista();
                return;
            }
            return;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Musculo musculo;

            #region Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MetroMessageBox.Show(this, "Complete el campo Nombre", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion


            if (ACCION == "A")
            {
                musculo = new Musculo();
            }
            else
            {
                musculo = cMusculos.obtenerMusculo(int.Parse(txtIdMusculos.Text));
            }

            musculo.nombre = txtNombre.Text;

            cMusculos.guardarMusculo(musculo);
            limpiarFormDejarVisible(false);
            cargarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormDejarVisible(false);
        }

        private void FrmMusculos_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void limpiarFormDejarVisible(bool visible)
        {
            gbFrmMusculos.Visible = visible;
            txtIdMusculos.Text = "";
            txtNombre.Text = "";
        }

        private void cargarLista()
        {
            gridMusculos.Items.Clear();
            List<Musculo> listaMusculos = cMusculos.obtenerListaMusculos();

            foreach (Musculo musculo in listaMusculos)
            {
                string[] row =
                {
                    musculo.idMusculo.ToString(),
                    musculo.nombre
                };

                var listViewItem = new ListViewItem(row);
                gridMusculos.Items.Add(listViewItem);
            }
        }

    }
}
