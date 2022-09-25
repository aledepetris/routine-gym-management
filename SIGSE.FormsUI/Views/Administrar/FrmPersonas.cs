using System;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmPersonas : MetroFramework.Forms.MetroForm
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmPersona());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
