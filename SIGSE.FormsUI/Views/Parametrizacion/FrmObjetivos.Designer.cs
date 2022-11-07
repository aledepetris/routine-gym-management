
namespace SIGSE.FormsUI.Views
{
    partial class FrmObjetivos
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
            this.gbFrmObjetivo = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.numMaximos = new System.Windows.Forms.NumericUpDown();
            this.numMinimos = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdObjetivo = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.gridObjetivos = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiaMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFrmObjetivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimos)).BeginInit();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFrmObjetivo
            // 
            this.gbFrmObjetivo.Controls.Add(this.btnCancelar);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel6);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel5);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel4);
            this.gbFrmObjetivo.Controls.Add(this.numMaximos);
            this.gbFrmObjetivo.Controls.Add(this.numMinimos);
            this.gbFrmObjetivo.Controls.Add(this.btnGuardar);
            this.gbFrmObjetivo.Controls.Add(this.txtDescripcion);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel3);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel1);
            this.gbFrmObjetivo.Controls.Add(this.txtIdObjetivo);
            this.gbFrmObjetivo.Controls.Add(this.txtNombre);
            this.gbFrmObjetivo.Controls.Add(this.metroLabel2);
            this.gbFrmObjetivo.HorizontalScrollbarBarColor = true;
            this.gbFrmObjetivo.HorizontalScrollbarHighlightOnWheel = false;
            this.gbFrmObjetivo.HorizontalScrollbarSize = 10;
            this.gbFrmObjetivo.Location = new System.Drawing.Point(340, 77);
            this.gbFrmObjetivo.Name = "gbFrmObjetivo";
            this.gbFrmObjetivo.Size = new System.Drawing.Size(225, 324);
            this.gbFrmObjetivo.TabIndex = 56;
            this.gbFrmObjetivo.VerticalScrollbarBarColor = true;
            this.gbFrmObjetivo.VerticalScrollbarHighlightOnWheel = false;
            this.gbFrmObjetivo.VerticalScrollbarSize = 10;
            this.gbFrmObjetivo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(6, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(130, 189);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.Text = "Máximos";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 189);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.Text = "Minimos";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 19);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.Text = "Días de entrenamientos:";
            // 
            // numMaximos
            // 
            this.numMaximos.Location = new System.Drawing.Point(130, 211);
            this.numMaximos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMaximos.Name = "numMaximos";
            this.numMaximos.Size = new System.Drawing.Size(92, 20);
            this.numMaximos.TabIndex = 56;
            // 
            // numMinimos
            // 
            this.numMinimos.Location = new System.Drawing.Point(6, 211);
            this.numMinimos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMinimos.Name = "numMinimos";
            this.numMinimos.Size = new System.Drawing.Size(92, 20);
            this.numMinimos.TabIndex = 55;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.DisplayFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(4, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(216, 24);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(6, 133);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(214, 29);
            this.txtDescripcion.TabIndex = 43;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Descripción:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "ID Objetivo";
            // 
            // txtIdObjetivo
            // 
            // 
            // 
            // 
            this.txtIdObjetivo.CustomButton.Image = null;
            this.txtIdObjetivo.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtIdObjetivo.CustomButton.Name = "";
            this.txtIdObjetivo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdObjetivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdObjetivo.CustomButton.TabIndex = 1;
            this.txtIdObjetivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdObjetivo.CustomButton.UseSelectable = true;
            this.txtIdObjetivo.CustomButton.Visible = false;
            this.txtIdObjetivo.Enabled = false;
            this.txtIdObjetivo.Lines = new string[0];
            this.txtIdObjetivo.Location = new System.Drawing.Point(6, 22);
            this.txtIdObjetivo.MaxLength = 32767;
            this.txtIdObjetivo.Name = "txtIdObjetivo";
            this.txtIdObjetivo.PasswordChar = '\0';
            this.txtIdObjetivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdObjetivo.SelectedText = "";
            this.txtIdObjetivo.SelectionLength = 0;
            this.txtIdObjetivo.SelectionStart = 0;
            this.txtIdObjetivo.ShortcutsEnabled = true;
            this.txtIdObjetivo.Size = new System.Drawing.Size(214, 29);
            this.txtIdObjetivo.TabIndex = 34;
            this.txtIdObjetivo.UseSelectable = true;
            this.txtIdObjetivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdObjetivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(6, 76);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(214, 29);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Nombre:";
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
            this.mpFooter.Location = new System.Drawing.Point(-4, 399);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(596, 30);
            this.mpFooter.TabIndex = 62;
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
            this.lblFooter.Location = new System.Drawing.Point(153, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(128, 359);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(233, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 359);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 23);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 75);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(112, 19);
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Lista de Objetivos";
            // 
            // gridObjetivos
            // 
            this.gridObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridObjetivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRol,
            this.Nombre,
            this.DiaMin,
            this.DiaMax});
            this.gridObjetivos.FullRowSelect = true;
            this.gridObjetivos.GridLines = true;
            this.gridObjetivos.HideSelection = false;
            this.gridObjetivos.Location = new System.Drawing.Point(23, 96);
            this.gridObjetivos.MultiSelect = false;
            this.gridObjetivos.Name = "gridObjetivos";
            this.gridObjetivos.Size = new System.Drawing.Size(298, 257);
            this.gridObjetivos.TabIndex = 68;
            this.gridObjetivos.UseCompatibleStateImageBehavior = false;
            this.gridObjetivos.View = System.Windows.Forms.View.Details;
            // 
            // IdRol
            // 
            this.IdRol.Text = "#";
            this.IdRol.Width = 31;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 148;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 10);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // DiaMin
            // 
            this.DiaMin.Text = "Dia Min";
            this.DiaMin.Width = 55;
            // 
            // DiaMax
            // 
            this.DiaMax.Text = "Día Max";
            this.DiaMax.Width = 59;
            // 
            // FrmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.gridObjetivos);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.gbFrmObjetivo);
            this.MaximizeBox = false;
            this.Name = "FrmObjetivos";
            this.Resizable = false;
            this.Text = "Objetivos";
            this.Activated += new System.EventHandler(this.FrmObjetivos_Activated);
            this.gbFrmObjetivo.ResumeLayout(false);
            this.gbFrmObjetivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimos)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel gbFrmObjetivo;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtIdObjetivo;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.NumericUpDown numMaximos;
        private System.Windows.Forms.NumericUpDown numMinimos;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ListView gridObjetivos;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader DiaMin;
        private System.Windows.Forms.ColumnHeader DiaMax;
    }
}