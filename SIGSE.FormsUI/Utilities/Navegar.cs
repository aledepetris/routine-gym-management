using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Utilities
{
    public class Navegar
    {
        public static void Open(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Close();
            currentForm.Dispose();
        }
        public static void OpenNewTab(Form newForm)
        {
            newForm.ShowDialog();
        }

    }
}
