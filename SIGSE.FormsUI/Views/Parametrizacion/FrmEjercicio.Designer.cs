
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
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnDesasignar = new MetroFramework.Controls.MetroButton();
            this.btnAsignar = new MetroFramework.Controls.MetroButton();
            this.lvAsignado = new System.Windows.Forms.ListView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lvSinAsignar = new System.Windows.Forms.ListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxActivo = new MetroFramework.Controls.MetroComboBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdEjercicio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnDesasignar);
            this.groupBox1.Controls.Add(this.btnAsignar);
            this.groupBox1.Controls.Add(this.lvAsignado);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lvSinAsignar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbxActivo);
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
            this.btnSalir.Location = new System.Drawing.Point(271, 415);
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
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnDesasignar.ForeColor = System.Drawing.Color.White;
            this.btnDesasignar.Location = new System.Drawing.Point(143, 268);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(54, 29);
            this.btnDesasignar.TabIndex = 25;
            this.btnDesasignar.Text = "<";
            this.btnDesasignar.UseSelectable = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(143, 223);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(54, 29);
            this.btnAsignar.TabIndex = 24;
            this.btnAsignar.Text = ">";
            this.btnAsignar.UseSelectable = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lvAsignado
            // 
            this.lvAsignado.HideSelection = false;
            this.lvAsignado.Location = new System.Drawing.Point(203, 186);
            this.lvAsignado.Name = "lvAsignado";
            this.lvAsignado.Size = new System.Drawing.Size(128, 178);
            this.lvAsignado.TabIndex = 23;
            this.lvAsignado.UseCompatibleStateImageBehavior = false;
            this.lvAsignado.View = System.Windows.Forms.View.List;
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
            // lvSinAsignar
            // 
            this.lvSinAsignar.HideSelection = false;
            this.lvSinAsignar.Location = new System.Drawing.Point(9, 186);
            this.lvSinAsignar.Name = "lvSinAsignar";
            this.lvSinAsignar.Size = new System.Drawing.Size(128, 178);
            this.lvSinAsignar.TabIndex = 21;
            this.lvSinAsignar.UseCompatibleStateImageBehavior = false;
            this.lvSinAsignar.View = System.Windows.Forms.View.List;
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
            // cbxActivo
            // 
            this.cbxActivo.FormattingEnabled = true;
            this.cbxActivo.ItemHeight = 23;
            this.cbxActivo.Items.AddRange(new object[] {
            "Total",
            "Lado/Extremidad"});
            this.cbxActivo.Location = new System.Drawing.Point(337, 99);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(170, 29);
            this.cbxActivo.TabIndex = 19;
            this.cbxActivo.UseSelectable = true;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(223, 1);
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
            this.btnGuardar.Location = new System.Drawing.Point(271, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 31);
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
            this.txtIdEjercicio.CustomButton.Location = new System.Drawing.Point(224, 1);
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(513, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Modo:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Por Tiempo",
            "Por Cantidad"});
            this.metroComboBox1.Location = new System.Drawing.Point(513, 99);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(162, 29);
            this.metroComboBox1.TabIndex = 29;
            this.metroComboBox1.UseSelectable = true;
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
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(487, 268);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(54, 29);
            this.metroButton1.TabIndex = 34;
            this.metroButton1.Text = "<";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(487, 223);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(54, 29);
            this.metroButton2.TabIndex = 33;
            this.metroButton2.Text = ">";
            this.metroButton2.UseSelectable = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(547, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(128, 178);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(353, 186);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(128, 178);
            this.listView2.TabIndex = 31;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(353, 145);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(141, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Tipos Entrenamientos";
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
        private MetroFramework.Controls.MetroComboBox cbxActivo;
        private MetroFramework.Controls.MetroButton btnDesasignar;
        private MetroFramework.Controls.MetroButton btnAsignar;
        private System.Windows.Forms.ListView lvAsignado;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListView lvSinAsignar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
    }
}