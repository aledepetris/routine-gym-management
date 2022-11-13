
namespace SIGSE.FormsUI.Views
{
    partial class FrmCiclo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdCiclo = new MetroFramework.Controls.MetroTextBox();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.cbxObjetivo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaFin = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbxEntrenamiento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbxESTADO = new MetroFramework.Controls.MetroComboBox();
            this.cbxDias = new MetroFramework.Controls.MetroComboBox();
            this.numSemanas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemanas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 10);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSemanas);
            this.groupBox1.Controls.Add(this.cbxDias);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.cbxESTADO);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.cbxEntrenamiento);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.cbxObjetivo);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtIdCiclo);
            this.groupBox1.Location = new System.Drawing.Point(23, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 588);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(10, 93);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(292, 29);
            this.dtpFechaInicio.TabIndex = 32;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.DisplayFocus = true;
            this.btnSalir.Location = new System.Drawing.Point(82, 506);
            this.btnSalir.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 26);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.White;
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Fecha Inicio:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Semanas:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(81, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID Ciclo";
            // 
            // txtIdCiclo
            // 
            // 
            // 
            // 
            this.txtIdCiclo.CustomButton.Image = null;
            this.txtIdCiclo.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.txtIdCiclo.CustomButton.Name = "";
            this.txtIdCiclo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdCiclo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdCiclo.CustomButton.TabIndex = 1;
            this.txtIdCiclo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdCiclo.CustomButton.UseSelectable = true;
            this.txtIdCiclo.CustomButton.Visible = false;
            this.txtIdCiclo.Enabled = false;
            this.txtIdCiclo.Lines = new string[0];
            this.txtIdCiclo.Location = new System.Drawing.Point(10, 39);
            this.txtIdCiclo.MaxLength = 32767;
            this.txtIdCiclo.Name = "txtIdCiclo";
            this.txtIdCiclo.PasswordChar = '\0';
            this.txtIdCiclo.ReadOnly = true;
            this.txtIdCiclo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdCiclo.SelectedText = "";
            this.txtIdCiclo.SelectionLength = 0;
            this.txtIdCiclo.SelectionStart = 0;
            this.txtIdCiclo.ShortcutsEnabled = true;
            this.txtIdCiclo.Size = new System.Drawing.Size(292, 29);
            this.txtIdCiclo.TabIndex = 0;
            this.txtIdCiclo.UseSelectable = true;
            this.txtIdCiclo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdCiclo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mpFooter.Location = new System.Drawing.Point(-2, 616);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(364, 30);
            this.mpFooter.TabIndex = 63;
            this.mpFooter.UseCustomBackColor = true;
            this.mpFooter.VerticalScrollbarBarColor = true;
            this.mpFooter.VerticalScrollbarHighlightOnWheel = false;
            this.mpFooter.VerticalScrollbarSize = 10;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFooter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(38, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // cbxObjetivo
            // 
            this.cbxObjetivo.FormattingEnabled = true;
            this.cbxObjetivo.ItemHeight = 23;
            this.cbxObjetivo.Location = new System.Drawing.Point(10, 255);
            this.cbxObjetivo.Name = "cbxObjetivo";
            this.cbxObjetivo.Size = new System.Drawing.Size(292, 29);
            this.cbxObjetivo.TabIndex = 12;
            this.cbxObjetivo.UseSelectable = true;
            this.cbxObjetivo.SelectedIndexChanged += new System.EventHandler(this.cbxObjetivo_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 287);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 55;
            this.metroLabel4.Text = "Dias:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Location = new System.Drawing.Point(10, 201);
            this.dtpFechaFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(292, 29);
            this.dtpFechaFin.TabIndex = 58;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 179);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 57;
            this.metroLabel5.Text = "Fecha Fin";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.Text = "Objetivo:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 341);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 61;
            this.metroLabel7.Text = "Entrenamiento:";
            // 
            // cbxEntrenamiento
            // 
            this.cbxEntrenamiento.FormattingEnabled = true;
            this.cbxEntrenamiento.ItemHeight = 23;
            this.cbxEntrenamiento.Location = new System.Drawing.Point(11, 363);
            this.cbxEntrenamiento.Name = "cbxEntrenamiento";
            this.cbxEntrenamiento.Size = new System.Drawing.Size(291, 29);
            this.cbxEntrenamiento.TabIndex = 60;
            this.cbxEntrenamiento.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(10, 395);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 63;
            this.metroLabel8.Text = "ESTADO:";
            // 
            // cbxESTADO
            // 
            this.cbxESTADO.FormattingEnabled = true;
            this.cbxESTADO.ItemHeight = 23;
            this.cbxESTADO.Location = new System.Drawing.Point(11, 417);
            this.cbxESTADO.Name = "cbxESTADO";
            this.cbxESTADO.Size = new System.Drawing.Size(290, 29);
            this.cbxESTADO.TabIndex = 62;
            this.cbxESTADO.UseSelectable = true;
            // 
            // cbxDias
            // 
            this.cbxDias.FormattingEnabled = true;
            this.cbxDias.ItemHeight = 23;
            this.cbxDias.Location = new System.Drawing.Point(11, 309);
            this.cbxDias.Name = "cbxDias";
            this.cbxDias.Size = new System.Drawing.Size(291, 29);
            this.cbxDias.TabIndex = 64;
            this.cbxDias.UseSelectable = true;
            this.cbxDias.SelectedIndexChanged += new System.EventHandler(this.cbxDias_SelectedIndexChanged);
            // 
            // numSemanas
            // 
            this.numSemanas.Location = new System.Drawing.Point(10, 150);
            this.numSemanas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSemanas.Name = "numSemanas";
            this.numSemanas.Size = new System.Drawing.Size(92, 20);
            this.numSemanas.TabIndex = 65;
            this.numSemanas.ValueChanged += new System.EventHandler(this.numSemanas_ValueChanged);
            // 
            // FrmCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 644);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmCiclo";
            this.Resizable = false;
            this.Text = "Ciclo";
            this.Activated += new System.EventHandler(this.FrmCiclo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemanas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdCiclo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroDateTime dtpFechaInicio;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbxESTADO;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbxEntrenamiento;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtpFechaFin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbxObjetivo;
        private MetroFramework.Controls.MetroComboBox cbxDias;
        private System.Windows.Forms.NumericUpDown numSemanas;
    }
}