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
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.Open(this, new FrmPersona());
        }
    }
}
