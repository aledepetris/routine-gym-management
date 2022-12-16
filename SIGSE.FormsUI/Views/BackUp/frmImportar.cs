using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo.Wmi;
using Microsoft.SqlServer.Management.Smo.Agent;
using Microsoft.SqlServer.Management.Smo.Broker;
using Microsoft.SqlServer.Management.Smo.Mail;
using MetroFramework;

namespace SIGSE.FormsUI.Views.BackUp
{
    public partial class frmImportar : MetroFramework.Forms.MetroForm
    {
        public frmImportar()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                //SqlConnection.ClearAllPools();
                Server dbServer = new Server(new ServerConnection(txtServer.Text, txtUsername.Text, txtPassword.Text));
                Restore dbRestore = new Restore() { Action = RestoreActionType.Database, Database = txtDatabase.Text, ReplaceDatabase = true, NoRecovery = false };
                dbServer.KillAllProcesses(dbRestore.Database);
                dbRestore.Devices.AddDevice(txtRuta.Text, DeviceType.File); //@"C:\Users\Public\DATA\CPPS1.bak"
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestore(dbServer);
                dbRestore.SqlRestoreAsync(dbServer);

                MetroMessageBox.Show(this, "Exportación exitosa", "EXITO!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information,
                    100);
                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
            }
        }
        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }

    }
}
