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
    public partial class FrmUsuario : MetroFramework.Forms.MetroForm
    {
        private Usuario globalUser;
        private Usuario currentUser;
        private UsuariosController cUsuarios;
        String ACCION;

        public FrmUsuario()
        {
            cargarDatosFormulario();
            ACCION = "A";
            txtIdUsuario.Text = "#";
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            btnAgregarPersona.Visible = true;
            txtPassword.Text = "";
            txtUsuario.Text = "";
            cbxActivo.SelectedIndex = 0;

            lvSinAsignar.Items.Clear();

            List<Rol> roles = cUsuarios.obtenerListaRoles();

            foreach (Rol rol in roles)
                lvSinAsignar.Items.Add(rol.nombre);

        }

        public FrmUsuario(Usuario user)
        {
            cargarDatosFormulario();
            cargarComboPersonas();
            ACCION = "M";

            txtIdUsuario.Text = user.idUsuario.ToString();
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            btnAgregarPersona.Visible = false;
            txtUsuario.Text = user.username;

            if (user.activo)
                cbxActivo.SelectedIndex = 0;
            else
                cbxActivo.SelectedIndex = 1;

            cbxPersonas.SelectedItem = user.persona;
            cbxPersonas.Enabled = false;

            cargarLisViewsAsignacionesDeUsuario(user);

            globalUser = user;
        }

        public void cargarLisViewsAsignacionesDeUsuario(Usuario user)
        {
            List<Rol> rolesSinAsignar = cUsuarios.obtenerListaRoles();

            List<Rol> rolesAsignados = (List<Rol>) user.roles;

            if (rolesAsignados != null)
            { 
                if (rolesAsignados.Count > 0)
                { 
                    rolesSinAsignar.RemoveAll(r => r.nombre == rolesAsignados[0].nombre);

                    foreach (Rol rol in rolesAsignados)
                        lvAsignado.Items.Add(rol.nombre);
                }

            }

            foreach (Rol rol in rolesSinAsignar)
                lvSinAsignar.Items.Add(rol.nombre);

        }

        public void cargarDatosFormulario()
        {
            InitializeComponent();
            cUsuarios = UsuariosController.obtenerInstancia();
            currentUser = cUsuarios.obtenerSesionUsuario();
            cargarComboPersonas();
        }

        public void cargarComboPersonas()
        {
            cbxPersonas.DataSource = cUsuarios.obtenerListaPersonas();
            cbxPersonas.DisplayMember = "nombreCompleto";
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmPersona());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cbxPersonas_Click(object sender, EventArgs e)
        {
            cargarComboPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txtUsuario.Text == "")
            {
                MetroMessageBox.Show(this, "Complete los campos obligatorios", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            if (cbxActivo.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Debe completar el campo activo", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            if (cbxPersonas.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Debe seleccionar una persona", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion

            Usuario nuevoUsuario;
            if (ACCION == "A")
            {                
                if (txtPassword.Text == "")
                {
                    MetroMessageBox.Show(this, "Complete los campos obligatorios", "ERROR!",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error,
                        100);
                    return;
                }
                nuevoUsuario = new Usuario();
            }
            else
                nuevoUsuario = globalUser;

            nuevoUsuario.username = txtUsuario.Text;
            nuevoUsuario.password = txtPassword.Text;
            nuevoUsuario.persona = (Persona) cbxPersonas.SelectedItem;

            if (cbxActivo.SelectedIndex == 0)
                nuevoUsuario.activo = true;
            else
                nuevoUsuario.activo = false;

            List<Rol> rolesAsignado = new List<Rol>();

            foreach (ListViewItem item in lvAsignado.Items)
            {
                rolesAsignado.Add(cUsuarios.obtenerRolPorNombre(item.Text));
            }

            nuevoUsuario.roles = rolesAsignado;

            cUsuarios.guardarUsuario(nuevoUsuario);

            MetroMessageBox.Show(this, "Usuario creado correctamente", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);

            this.Close();
        }

    }
}
