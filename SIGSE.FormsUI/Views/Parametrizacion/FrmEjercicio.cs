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
    public partial class FrmEjercicio : MetroFramework.Forms.MetroForm
    {
        private Usuario globalUser;
        private Usuario currentUser;
        private UsuariosController cUsuarios;
        String ACCION;

        public FrmEjercicio()
        {
            InitializeComponent();
        }

        public FrmEjercicio(Ejercicio ejercicio)
        {
            cargarDatosFormulario();
            cargarComboPersonas();
            ACCION = "M";

            InitializeComponent();
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


        }

    }
}
