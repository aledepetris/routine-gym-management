
namespace SIGSE.FormsUI.Views
{
    partial class FrmLoginLogout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gridLogins = new System.Windows.Forms.ListView();
            this.idLog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaHoraConexion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaHoraDesconexion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SesionActiva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroPanel1.SuspendLayout();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.gridLogins);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(758, 438);
            this.metroPanel1.TabIndex = 34;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(13, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(127, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Listado de sesiones";
            // 
            // gridLogins
            // 
            this.gridLogins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLogins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idLog,
            this.Username,
            this.FechaHoraConexion,
            this.FechaHoraDesconexion,
            this.SesionActiva});
            this.gridLogins.FullRowSelect = true;
            this.gridLogins.GridLines = true;
            this.gridLogins.HideSelection = false;
            this.gridLogins.Location = new System.Drawing.Point(13, 34);
            this.gridLogins.MultiSelect = false;
            this.gridLogins.Name = "gridLogins";
            this.gridLogins.Size = new System.Drawing.Size(742, 359);
            this.gridLogins.TabIndex = 36;
            this.gridLogins.UseCompatibleStateImageBehavior = false;
            this.gridLogins.View = System.Windows.Forms.View.Details;
            // 
            // idLog
            // 
            this.idLog.Text = "#";
            this.idLog.Width = 34;
            // 
            // Username
            // 
            this.Username.Text = "Usuario";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Width = 160;
            // 
            // FechaHoraConexion
            // 
            this.FechaHoraConexion.Text = "Fecha y Hora Conexión";
            this.FechaHoraConexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FechaHoraConexion.Width = 200;
            // 
            // FechaHoraDesconexion
            // 
            this.FechaHoraDesconexion.Text = "Fecha y Hora Desconexión";
            this.FechaHoraDesconexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FechaHoraDesconexion.Width = 206;
            // 
            // SesionActiva
            // 
            this.SesionActiva.Text = "Sesion Activa";
            this.SesionActiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SesionActiva.Width = 87;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFooter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(269, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // mpFooter
            // 
            this.mpFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.mpFooter.Controls.Add(this.lblFooter);
            this.mpFooter.HorizontalScrollbarBarColor = true;
            this.mpFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.mpFooter.HorizontalScrollbarSize = 10;
            this.mpFooter.Location = new System.Drawing.Point(-2, 480);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(820, 30);
            this.mpFooter.TabIndex = 44;
            this.mpFooter.UseCustomBackColor = true;
            this.mpFooter.VerticalScrollbarBarColor = true;
            this.mpFooter.VerticalScrollbarHighlightOnWheel = false;
            this.mpFooter.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 10);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLoginLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmLoginLogout";
            this.Resizable = false;
            this.Text = "Login-Logout";
            this.Activated += new System.EventHandler(this.FrmPersonas_Activated);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListView gridLogins;
        private System.Windows.Forms.ColumnHeader idLog;
        private System.Windows.Forms.ColumnHeader FechaHoraDesconexion;
        private System.Windows.Forms.ColumnHeader SesionActiva;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader FechaHoraConexion;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}