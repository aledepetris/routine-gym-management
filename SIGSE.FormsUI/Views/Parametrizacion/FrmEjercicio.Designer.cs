
namespace SIGSE.FormsUI.Views
{
    partial class FrmEjercicio
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
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnDesasignarTipoEnt = new MetroFramework.Controls.MetroButton();
            this.btnAsignarTipoEnt = new MetroFramework.Controls.MetroButton();
            this.lvTipoEjercicioAsignado = new System.Windows.Forms.ListView();
            this.lvTipoEjercicioSinAsignar = new System.Windows.Forms.ListView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxModo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnDesasignarMusculo = new MetroFramework.Controls.MetroButton();
            this.btnAsignarMusculo = new MetroFramework.Controls.MetroButton();
            this.lvMusculoAsignado = new System.Windows.Forms.ListView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lvMusculoSinAsignar = new System.Windows.Forms.ListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxForma = new MetroFramework.Controls.MetroComboBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdEjercicio = new MetroFramework.Controls.MetroTextBox();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mpFooter.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.btnDesasignarTipoEnt);
            this.groupBox1.Controls.Add(this.btnAsignarTipoEnt);
            this.groupBox1.Controls.Add(this.lvTipoEjercicioAsignado);
            this.groupBox1.Controls.Add(this.lvTipoEjercicioSinAsignar);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cbxModo);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnDesasignarMusculo);
            this.groupBox1.Controls.Add(this.btnAsignarMusculo);
            this.groupBox1.Controls.Add(this.lvMusculoAsignado);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lvMusculoSinAsignar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbxForma);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtIdEjercicio);
            this.groupBox1.Location = new System.Drawing.Point(14, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 454);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(353, 145);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Tipos Ejercicio";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(547, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Asignados";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(353, 164);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Sin Asignar";
            // 
            // btnDesasignarTipoEnt
            // 
            this.btnDesasignarTipoEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnDesasignarTipoEnt.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarTipoEnt.Location = new System.Drawing.Point(487, 268);
            this.btnDesasignarTipoEnt.Name = "btnDesasignarTipoEnt";
            this.btnDesasignarTipoEnt.Size = new System.Drawing.Size(54, 29);
            this.btnDesasignarTipoEnt.TabIndex = 34;
            this.btnDesasignarTipoEnt.Text = "<";
            this.btnDesasignarTipoEnt.UseSelectable = true;
            this.btnDesasignarTipoEnt.Click += new System.EventHandler(this.btnDesasignarTipoEnt_Click);
            // 
            // btnAsignarTipoEnt
            // 
            this.btnAsignarTipoEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnAsignarTipoEnt.ForeColor = System.Drawing.Color.White;
            this.btnAsignarTipoEnt.Location = new System.Drawing.Point(487, 223);
            this.btnAsignarTipoEnt.Name = "btnAsignarTipoEnt";
            this.btnAsignarTipoEnt.Size = new System.Drawing.Size(54, 29);
            this.btnAsignarTipoEnt.TabIndex = 33;
            this.btnAsignarTipoEnt.Text = ">";
            this.btnAsignarTipoEnt.UseSelectable = true;
            this.btnAsignarTipoEnt.Click += new System.EventHandler(this.btnAsignarTipoEnt_Click);
            // 
            // lvTipoEjercicioAsignado
            // 
            this.lvTipoEjercicioAsignado.HideSelection = false;
            this.lvTipoEjercicioAsignado.Location = new System.Drawing.Point(547, 186);
            this.lvTipoEjercicioAsignado.Name = "lvTipoEjercicioAsignado";
            this.lvTipoEjercicioAsignado.Size = new System.Drawing.Size(128, 178);
            this.lvTipoEjercicioAsignado.TabIndex = 32;
            this.lvTipoEjercicioAsignado.UseCompatibleStateImageBehavior = false;
            this.lvTipoEjercicioAsignado.View = System.Windows.Forms.View.List;
            // 
            // lvTipoEjercicioSinAsignar
            // 
            this.lvTipoEjercicioSinAsignar.HideSelection = false;
            this.lvTipoEjercicioSinAsignar.Location = new System.Drawing.Point(353, 186);
            this.lvTipoEjercicioSinAsignar.Name = "lvTipoEjercicioSinAsignar";
            this.lvTipoEjercicioSinAsignar.Size = new System.Drawing.Size(128, 178);
            this.lvTipoEjercicioSinAsignar.TabIndex = 31;
            this.lvTipoEjercicioSinAsignar.UseCompatibleStateImageBehavior = false;
            this.lvTipoEjercicioSinAsignar.View = System.Windows.Forms.View.List;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(513, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Modo:";
            // 
            // cbxModo
            // 
            this.cbxModo.FormattingEnabled = true;
            this.cbxModo.ItemHeight = 23;
            this.cbxModo.Items.AddRange(new object[] {
            "Por Tiempo",
            "Por Cantidad"});
            this.cbxModo.Location = new System.Drawing.Point(513, 99);
            this.cbxModo.Name = "cbxModo";
            this.cbxModo.Size = new System.Drawing.Size(162, 29);
            this.cbxModo.TabIndex = 29;
            this.cbxModo.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(203, 164);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Asignados";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 164);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Sin Asignar";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.DisplayFocus = true;
            this.btnSalir.Location = new System.Drawing.Point(203, 415);
            this.btnSalir.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(278, 26);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.White;
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesasignarMusculo
            // 
            this.btnDesasignarMusculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnDesasignarMusculo.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarMusculo.Location = new System.Drawing.Point(143, 268);
            this.btnDesasignarMusculo.Name = "btnDesasignarMusculo";
            this.btnDesasignarMusculo.Size = new System.Drawing.Size(54, 29);
            this.btnDesasignarMusculo.TabIndex = 25;
            this.btnDesasignarMusculo.Text = "<";
            this.btnDesasignarMusculo.UseSelectable = true;
            this.btnDesasignarMusculo.Click += new System.EventHandler(this.btnDesasignarMusculo_Click);
            // 
            // btnAsignarMusculo
            // 
            this.btnAsignarMusculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnAsignarMusculo.ForeColor = System.Drawing.Color.White;
            this.btnAsignarMusculo.Location = new System.Drawing.Point(143, 223);
            this.btnAsignarMusculo.Name = "btnAsignarMusculo";
            this.btnAsignarMusculo.Size = new System.Drawing.Size(54, 29);
            this.btnAsignarMusculo.TabIndex = 24;
            this.btnAsignarMusculo.Text = ">";
            this.btnAsignarMusculo.UseSelectable = true;
            this.btnAsignarMusculo.Click += new System.EventHandler(this.btnAsignarMusculo_Click);
            // 
            // lvMusculoAsignado
            // 
            this.lvMusculoAsignado.HideSelection = false;
            this.lvMusculoAsignado.Location = new System.Drawing.Point(203, 186);
            this.lvMusculoAsignado.Name = "lvMusculoAsignado";
            this.lvMusculoAsignado.Size = new System.Drawing.Size(128, 178);
            this.lvMusculoAsignado.TabIndex = 23;
            this.lvMusculoAsignado.UseCompatibleStateImageBehavior = false;
            this.lvMusculoAsignado.View = System.Windows.Forms.View.List;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(9, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Musculos";
            // 
            // lvMusculoSinAsignar
            // 
            this.lvMusculoSinAsignar.HideSelection = false;
            this.lvMusculoSinAsignar.Location = new System.Drawing.Point(9, 186);
            this.lvMusculoSinAsignar.Name = "lvMusculoSinAsignar";
            this.lvMusculoSinAsignar.Size = new System.Drawing.Size(128, 178);
            this.lvMusculoSinAsignar.TabIndex = 21;
            this.lvMusculoSinAsignar.UseCompatibleStateImageBehavior = false;
            this.lvMusculoSinAsignar.View = System.Windows.Forms.View.List;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(337, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Forma:";
            // 
            // cbxForma
            // 
            this.cbxForma.FormattingEnabled = true;
            this.cbxForma.ItemHeight = 23;
            this.cbxForma.Items.AddRange(new object[] {
            "Total",
            "Lado/Extremidad"});
            this.cbxForma.Location = new System.Drawing.Point(337, 99);
            this.cbxForma.Name = "cbxForma";
            this.cbxForma.Size = new System.Drawing.Size(170, 29);
            this.cbxForma.TabIndex = 19;
            this.cbxForma.UseSelectable = true;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(6, 99);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(325, 29);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(203, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(278, 26);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(5, 77);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Nombre:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID Ejercicio:";
            // 
            // txtIdEjercicio
            // 
            // 
            // 
            // 
            this.txtIdEjercicio.CustomButton.Image = null;
            this.txtIdEjercicio.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.txtIdEjercicio.CustomButton.Name = "";
            this.txtIdEjercicio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdEjercicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdEjercicio.CustomButton.TabIndex = 1;
            this.txtIdEjercicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdEjercicio.CustomButton.UseSelectable = true;
            this.txtIdEjercicio.CustomButton.Visible = false;
            this.txtIdEjercicio.Enabled = false;
            this.txtIdEjercicio.Lines = new string[0];
            this.txtIdEjercicio.Location = new System.Drawing.Point(6, 39);
            this.txtIdEjercicio.MaxLength = 32767;
            this.txtIdEjercicio.Name = "txtIdEjercicio";
            this.txtIdEjercicio.PasswordChar = '\0';
            this.txtIdEjercicio.ReadOnly = true;
            this.txtIdEjercicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdEjercicio.SelectedText = "";
            this.txtIdEjercicio.SelectionLength = 0;
            this.txtIdEjercicio.SelectionStart = 0;
            this.txtIdEjercicio.ShortcutsEnabled = true;
            this.txtIdEjercicio.Size = new System.Drawing.Size(325, 29);
            this.txtIdEjercicio.TabIndex = 0;
            this.txtIdEjercicio.UseSelectable = true;
            this.txtIdEjercicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdEjercicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mpFooter.Location = new System.Drawing.Point(-4, 520);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(714, 26);
            this.mpFooter.TabIndex = 64;
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
            this.lblFooter.Location = new System.Drawing.Point(221, 6);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // FrmEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 546);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmEjercicio";
            this.Resizable = false;
            this.Text = "Ejercicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdEjercicio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxForma;
        private MetroFramework.Controls.MetroButton btnDesasignarMusculo;
        private MetroFramework.Controls.MetroButton btnAsignarMusculo;
        private System.Windows.Forms.ListView lvMusculoAsignado;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListView lvMusculoSinAsignar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxModo;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnDesasignarTipoEnt;
        private MetroFramework.Controls.MetroButton btnAsignarTipoEnt;
        private System.Windows.Forms.ListView lvTipoEjercicioAsignado;
        private System.Windows.Forms.ListView lvTipoEjercicioSinAsignar;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
    }
}