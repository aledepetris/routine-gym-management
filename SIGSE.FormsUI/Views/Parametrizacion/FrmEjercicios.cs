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
    public partial class FrmEjercicios : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private EjerciciosController cEjercicios;

        public FrmEjercicios()
        {
            cEjercicios = EjerciciosController.obtenerInstancia();
            currentUser = cEjercicios.obtenerSesionUsuario();
            InitializeComponent();
            cargarLista();
        }

        private void cargarLista()
        {
            gridEjercicios.Items.Clear();
            List<Ejercicio> listaEjercicios = cEjercicios.obtenerListaEjercicios();

            foreach (Ejercicio ejercicio in listaEjercicios)
            {
                string[] row =
                {
                    ejercicio.idEjercicio.ToString(),
                    ejercicio.nombre
                };

                var listViewItem = new ListViewItem(row);
                gridEjercicios.Items.Add(listViewItem);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmEjercicio());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ejercicio de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            Utilities.Navegar.OpenNewTab(new FrmEjercicio(obtenerEjercicioSeleccionado()));
            cargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ejercicio de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            cEjercicios.eliminarEjercicio(obtenerEjercicioSeleccionado());
            cargarLista();
            return;
        }

        private Ejercicio obtenerEjercicioSeleccionado()
        {
            int id = int.Parse(gridEjercicios.SelectedItems[0].Text);
            return cEjercicios.obtenerEjercicioPorId(id);
        }

        private void FrmEjercicios_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}
