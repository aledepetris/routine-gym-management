
namespace SIGSE.FormsUI.Views
{
    partial class FrmTipoEjercicios
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.gbFrmTipoEjercicio = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtIdTipoEjercicio = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gridTiposEjercicios = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mpFooter.SuspendLayout();
            this.gbFrmTipoEjercicio.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Tipos de Ejercicios:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 10);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
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
            this.mpFooter.Location = new System.Drawing.Point(-6, 372);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(310, 30);
            this.mpFooter.TabIndex = 56;
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
            this.lblFooter.Location = new System.Drawing.Point(135, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // gbFrmTipoEjercicio
            // 
            this.gbFrmTipoEjercicio.Controls.Add(this.btnCancelar);
            this.gbFrmTipoEjercicio.Controls.Add(this.metroLabel1);
            this.gbFrmTipoEjercicio.Controls.Add(this.btnGuardar);
            this.gbFrmTipoEjercicio.Controls.Add(this.txtIdTipoEjercicio);
            this.gbFrmTipoEjercicio.Controls.Add(this.txtNombre);
            this.gbFrmTipoEjercicio.Controls.Add(this.metroLabel2);
            this.gbFrmTipoEjercicio.HorizontalScrollbarBarColor = true;
            this.gbFrmTipoEjercicio.HorizontalScrollbarHighlightOnWheel = false;
            this.gbFrmTipoEjercicio.HorizontalScrollbarSize = 10;
            this.gbFrmTipoEjercicio.Location = new System.Drawing.Point(305, 97);
            this.gbFrmTipoEjercicio.Name = "gbFrmTipoEjercicio";
            this.gbFrmTipoEjercicio.Size = new System.Drawing.Size(225, 206);
            this.gbFrmTipoEjercicio.TabIndex = 55;
            this.gbFrmTipoEjercicio.VerticalScrollbarBarColor = true;
            this.gbFrmTipoEjercicio.VerticalScrollbarHighlightOnWheel = false;
            this.gbFrmTipoEjercicio.VerticalScrollbarSize = 10;
            this.gbFrmTipoEjercicio.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "ID Tipo de Ejercicio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.DisplayFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(6, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(214, 23);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdTipoEjercicio
            // 
            // 
            // 
            // 
            this.txtIdTipoEjercicio.CustomButton.Image = null;
            this.txtIdTipoEjercicio.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtIdTipoEjercicio.CustomButton.Name = "";
            this.txtIdTipoEjercicio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdTipoEjercicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdTipoEjercicio.CustomButton.TabIndex = 1;
            this.txtIdTipoEjercicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdTipoEjercicio.CustomButton.UseSelectable = true;
            this.txtIdTipoEjercicio.CustomButton.Visible = false;
            this.txtIdTipoEjercicio.Enabled = false;
            this.txtIdTipoEjercicio.Lines = new string[0];
            this.txtIdTipoEjercicio.Location = new System.Drawing.Point(6, 27);
            this.txtIdTipoEjercicio.MaxLength = 32767;
            this.txtIdTipoEjercicio.Name = "txtIdTipoEjercicio";
            this.txtIdTipoEjercicio.PasswordChar = '\0';
            this.txtIdTipoEjercicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdTipoEjercicio.SelectedText = "";
            this.txtIdTipoEjercicio.SelectionLength = 0;
            this.txtIdTipoEjercicio.SelectionStart = 0;
            this.txtIdTipoEjercicio.ShortcutsEnabled = true;
            this.txtIdTipoEjercicio.Size = new System.Drawing.Size(214, 29);
            this.txtIdTipoEjercicio.TabIndex = 34;
            this.txtIdTipoEjercicio.UseSelectable = true;
            this.txtIdTipoEjercicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdTipoEjercicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNombre.Location = new System.Drawing.Point(6, 90);
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
            this.metroLabel2.Location = new System.Drawing.Point(6, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Nombre:";
            // 
            // gridTiposEjercicios
            // 
            this.gridTiposEjercicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTiposEjercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRol,
            this.Nombre});
            this.gridTiposEjercicios.FullRowSelect = true;
            this.gridTiposEjercicios.GridLines = true;
            this.gridTiposEjercicios.HideSelection = false;
            this.gridTiposEjercicios.Location = new System.Drawing.Point(23, 97);
            this.gridTiposEjercicios.MultiSelect = false;
            this.gridTiposEjercicios.Name = "gridTiposEjercicios";
            this.gridTiposEjercicios.Size = new System.Drawing.Size(276, 158);
            this.gridTiposEjercicios.TabIndex = 54;
            this.gridTiposEjercicios.UseCompatibleStateImageBehavior = false;
            this.gridTiposEjercicios.View = System.Windows.Forms.View.Details;
            // 
            // IdRol
            // 
            this.IdRol.Text = "#";
            this.IdRol.Width = 31;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 239;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(117, 264);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(211, 264);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 23);
            this.btnAgregar.TabIndex = 65;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-15, 306);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(571, 30);
            this.metroPanel1.TabIndex = 68;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(135, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(288, 15);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(6, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 23);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmTipoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 335);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.gbFrmTipoEjercicio);
            this.Controls.Add(this.gridTiposEjercicios);
            this.MaximizeBox = false;
            this.Name = "FrmTipoEjercicios";
            this.Resizable = false;
            this.Text = "Gestionar Tipos De Ejercicios";
            this.Activated += new System.EventHandler(this.FrmTipoEjercicios_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            this.gbFrmTipoEjercicio.ResumeLayout(false);
            this.gbFrmTipoEjercicio.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel gbFrmTipoEjercicio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtIdTipoEjercicio;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView gridTiposEjercicios;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}