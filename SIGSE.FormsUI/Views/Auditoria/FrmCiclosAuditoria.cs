using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using SIGSE.Entities.Auditoria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmCiclosAuditoria : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private AuditoriaController cAuditoria;

        public FrmCiclosAuditoria()
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
            List<AuditoriaCiclos> listaAuditoria = cAuditoria.obtenerListaAuditoriaCiclos();

            foreach (AuditoriaCiclos audi in listaAuditoria)
            {
                string[] row =
                {
                    audi.idAuditoria.ToString(),
                    audi.nombreAlumno,
                    audi.idCiclo.ToString()
                };

                var listViewItem = new ListViewItem(row);
                gridLogins.Items.Add(listViewItem);

            }
        }

        private void btnConsultarAcciones_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridLogins.SelectedItems[0].Text);
            AuditoriaCiclos cicloAud = cAuditoria.obtenerCicloAuditado(id);

            gridMovimientos.Items.Clear();

            int count = 0;
            foreach (MovimientosCiclo mov in cicloAud.movimientosCiclo)
            {

                string[] row =
                {
                    count.ToString(),
                    mov.fecha_actividad.ToString(),
                    mov.usuario,

                    "->",

                    mov.estado.ToString(),
                    mov.tipo_entrenamiento.nombre,
                    mov.objetivo,
                    mov.fecha_inicio.ToString(),
                    mov.cant_semanas.ToString(),
                    mov.cant_dias.ToString(),

                };

                count++;
                var listViewItem = new ListViewItem(row);
                gridMovimientos.Items.Add(listViewItem);

            }


        }
    }
}
