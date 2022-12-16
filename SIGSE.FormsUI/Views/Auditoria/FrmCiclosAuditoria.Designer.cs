
namespace SIGSE.FormsUI.Views
{
    partial class FrmCiclosAuditoria
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
            this.alumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciclo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.gridMovimientos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.separador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultarAcciones = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tipoent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objetivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechIni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantSemanas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantDias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnConsultarAcciones);
            this.metroPanel1.Controls.Add(this.gridMovimientos);
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
            this.metroLabel5.Size = new System.Drawing.Size(111, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Listado de Ciclos";
            // 
            // gridLogins
            // 
            this.gridLogins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLogins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idLog,
            this.alumno,
            this.ciclo});
            this.gridLogins.FullRowSelect = true;
            this.gridLogins.GridLines = true;
            this.gridLogins.HideSelection = false;
            this.gridLogins.Location = new System.Drawing.Point(13, 34);
            this.gridLogins.MultiSelect = false;
            this.gridLogins.Name = "gridLogins";
            this.gridLogins.Size = new System.Drawing.Size(405, 117);
            this.gridLogins.TabIndex = 36;
            this.gridLogins.UseCompatibleStateImageBehavior = false;
            this.gridLogins.View = System.Windows.Forms.View.Details;
            // 
            // idLog
            // 
            this.idLog.Text = "#";
            this.idLog.Width = 31;
            // 
            // alumno
            // 
            this.alumno.Text = "Alumno";
            this.alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alumno.Width = 268;
            // 
            // ciclo
            // 
            this.ciclo.Text = "ID Ciclo";
            this.ciclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ciclo.Width = 92;
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
            // gridMovimientos
            // 
            this.gridMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fec,
            this.Usuario,
            this.separador,
            this.estado,
            this.tipoent,
            this.objetivo,
            this.fechIni,
            this.cantSemanas,
            this.cantDias});
            this.gridMovimientos.FullRowSelect = true;
            this.gridMovimientos.GridLines = true;
            this.gridMovimientos.HideSelection = false;
            this.gridMovimientos.Location = new System.Drawing.Point(13, 178);
            this.gridMovimientos.MultiSelect = false;
            this.gridMovimientos.Name = "gridMovimientos";
            this.gridMovimientos.Size = new System.Drawing.Size(742, 218);
            this.gridMovimientos.TabIndex = 37;
            this.gridMovimientos.UseCompatibleStateImageBehavior = false;
            this.gridMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "#";
            this.id.Width = 23;
            // 
            // fec
            // 
            this.fec.Text = "Fecha Modif.";
            this.fec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fec.Width = 129;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.Width = 91;
            // 
            // separador
            // 
            this.separador.Text = "";
            this.separador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.separador.Width = 22;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estado.Width = 87;
            // 
            // btnConsultarAcciones
            // 
            this.btnConsultarAcciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnConsultarAcciones.DisplayFocus = true;
            this.btnConsultarAcciones.Location = new System.Drawing.Point(433, 120);
            this.btnConsultarAcciones.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnConsultarAcciones.Name = "btnConsultarAcciones";
            this.btnConsultarAcciones.Size = new System.Drawing.Size(176, 31);
            this.btnConsultarAcciones.Style = MetroFramework.MetroColorStyle.White;
            this.btnConsultarAcciones.TabIndex = 38;
            this.btnConsultarAcciones.Text = "Consultar movimientos >>";
            this.btnConsultarAcciones.UseCustomBackColor = true;
            this.btnConsultarAcciones.UseSelectable = true;
            this.btnConsultarAcciones.UseStyleColors = true;
            this.btnConsultarAcciones.Click += new System.EventHandler(this.btnConsultarAcciones_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(13, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Listado de movimientos";
            // 
            // tipoent
            // 
            this.tipoent.Text = "Tipo Ent.";
            // 
            // objetivo
            // 
            this.objetivo.Text = "Objetivo";
            // 
            // fechIni
            // 
            this.fechIni.Text = "Fecha Inicio";
            // 
            // cantSemanas
            // 
            this.cantSemanas.Text = "Semanas";
            // 
            // cantDias
            // 
            this.cantDias.Text = "Dias";
            // 
            // FrmCiclosAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmCiclosAuditoria";
            this.Resizable = false;
            this.Text = "Auditoria Ciclos";
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
        private System.Windows.Forms.ColumnHeader alumno;
        private System.Windows.Forms.ColumnHeader ciclo;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.ListView gridMovimientos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader fec;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader separador;
        private System.Windows.Forms.ColumnHeader estado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConsultarAcciones;
        private System.Windows.Forms.ColumnHeader tipoent;
        private System.Windows.Forms.ColumnHeader objetivo;
        private System.Windows.Forms.ColumnHeader fechIni;
        private System.Windows.Forms.ColumnHeader cantSemanas;
        private System.Windows.Forms.ColumnHeader cantDias;
    }
}