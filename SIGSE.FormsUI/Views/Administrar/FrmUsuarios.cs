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
    public partial class FrmUsuarios : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private UsuariosController cUsuarios;

        public FrmUsuarios()
        {
            cUsuarios = UsuariosController.obtenerInstancia();
            currentUser = cUsuarios.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            gridUsuarios.Items.Clear();
            List<Usuario> listaUsuarios = cUsuarios.obtenerListaUsuarios();

            string activo;

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.activo)
                    activo = "Si";
                else
                    activo = "No";

                string[] row =
                {
                    usuario.idUsuario.ToString(),
                    usuario.username,
                    usuario.persona.nombre + " " + usuario.persona.apellido,
                    usuario.persona.mail,
                    activo
                };

                var listViewItem = new ListViewItem(row);
                gridUsuarios.Items.Add(listViewItem);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmUsuario());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Usuario de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            Utilities.Navegar.OpenNewTab(new FrmUsuario(obtenerUsuarioSeleccionado()));
            cargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Usuario de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            cUsuarios.eliminarUsuario(obtenerUsuarioSeleccionado());
            cargarLista();
            return;
        }

        private Usuario obtenerUsuarioSeleccionado()
        {
            int id = int.Parse(gridUsuarios.SelectedItems[0].Text);
            return cUsuarios.obtenerUsuario(id);
        }

    }
}
