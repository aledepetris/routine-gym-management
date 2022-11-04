using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmPersonas : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private PersonasController cPersonas;

        public FrmPersonas()
        {
            cPersonas = PersonasController.obtenerInstancia();
            currentUser = cPersonas.obtenerSesionUsuario();
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmPersona());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridPersonas.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar una Persona de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            Utilities.Navegar.OpenNewTab(new FrmPersona(obtenerPersonaSeleccionado()));
            cargarLista();
            return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridPersonas.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar una Persona de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            cPersonas.eliminarPersona(obtenerPersonaSeleccionado());
            cargarLista();
            return;
        }

        private Persona obtenerPersonaSeleccionado()
        {
            int id = int.Parse(gridPersonas.SelectedItems[0].Text);
            return cPersonas.obtenerPersona(id);
        }

        private void FrmPersonas_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            gridPersonas.Items.Clear();
            List<Persona> listaPersonas = cPersonas.obtenerListaPersonas();

            foreach (Persona persona in listaPersonas)
            {
                string[] row =
                {
                    persona.idPersona.ToString(),
                    persona.GetType().Name,
                    persona.DNI.ToString(),
                    persona.nombre,
                    persona.apellido,
                    persona.telefono,
                    persona.mail
                };

                var listViewItem = new ListViewItem(row);
                gridPersonas.Items.Add(listViewItem);
            }
        }


    }
}
