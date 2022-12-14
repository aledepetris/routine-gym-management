using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using SIGSE.Entities.Auditoria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmLoginLogout : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private AuditoriaController cAuditoria;

        public FrmLoginLogout()
        {
            cAuditoria = AuditoriaController.obtenerInstancia();
            currentUser = cAuditoria.obtenerSesionUsuario();
            InitializeComponent();

        }
        private void FrmPersonas_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            gridLogins.Items.Clear();
            List<AuditoriaLogin> listaAuditoria = cAuditoria.obtenerListaAuditoriaLogin();

            foreach (AuditoriaLogin audi in listaAuditoria)
            {
                string active = "No";
                if (audi.sesionActiva)
                    active = "Si";

                string[] row =
                {
                    audi.idLogin.ToString(),
                    audi.username,
                    audi.fechaHoraConexion.ToString(),
                    audi.fechaHoraDesconexion.ToString(),
                    active
                };

                var listViewItem = new ListViewItem(row);
                gridLogins.Items.Add(listViewItem);

            }
        }
    }
}
