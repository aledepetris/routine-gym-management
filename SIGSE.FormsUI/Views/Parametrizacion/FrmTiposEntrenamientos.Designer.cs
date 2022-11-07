
namespace SIGSE.FormsUI.Views
{ 
    partial class FrmTiposEntrenamientos
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gbTipoEntrenamiento = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnDesasignar = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblTipoEntrenamiento = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnAsignar = new MetroFramework.Controls.MetroButton();
            this.lvAsignado = new System.Windows.Forms.ListView();
            this.txtIdTipoEntrenamiento = new MetroFramework.Controls.MetroTextBox();
            this.lvSinAsignar = new System.Windows.Forms.ListView();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.gridTipoEntrenamiento = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.gbTipoEntrenamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 10);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
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
            this.metroPanel1.Location = new System.Drawing.Point(-4, 515);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(722, 30);
            this.metroPanel1.TabIndex = 81;
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
            this.metroLabel4.Location = new System.Drawing.Point(248, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(288, 15);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(117, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 80;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(211, 480);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 480);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 23);
            this.btnAgregar.TabIndex = 78;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(201, 19);
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Lista de Tipos de Entrenamientos";
            // 
            // gbTipoEntrenamiento
            // 
            this.gbTipoEntrenamiento.Controls.Add(this.btnCancelar);
            this.gbTipoEntrenamiento.Controls.Add(this.metroLabel5);
            this.gbTipoEntrenamiento.Controls.Add(this.metroLabel8);
            this.gbTipoEntrenamiento.Controls.Add(this.btnDesasignar);
            this.gbTipoEntrenamiento.Controls.Add(this.metroLabel7);
            this.gbTipoEntrenamiento.Controls.Add(this.lblTipoEntrenamiento);
            this.gbTipoEntrenamiento.Controls.Add(this.btnGuardar);
            this.gbTipoEntrenamiento.Controls.Add(this.btnAsignar);
            this.gbTipoEntrenamiento.Controls.Add(this.lvAsignado);
            this.gbTipoEntrenamiento.Controls.Add(this.txtIdTipoEntrenamiento);
            this.gbTipoEntrenamiento.Controls.Add(this.lvSinAsignar);
            this.gbTipoEntrenamiento.Controls.Add(this.txtNombre);
            this.gbTipoEntrenamiento.Controls.Add(this.lblNombre);
            this.gbTipoEntrenamiento.HorizontalScrollbarBarColor = true;
            this.gbTipoEntrenamiento.HorizontalScrollbarHighlightOnWheel = false;
            this.gbTipoEntrenamiento.HorizontalScrollbarSize = 10;
            this.gbTipoEntrenamiento.Location = new System.Drawing.Point(305, 87);
            this.gbTipoEntrenamiento.Name = "gbTipoEntrenamiento";
            this.gbTipoEntrenamiento.Size = new System.Drawing.Size(401, 425);
            this.gbTipoEntrenamiento.TabIndex = 76;
            this.gbTipoEntrenamiento.VerticalScrollbarBarColor = true;
            this.gbTipoEntrenamiento.VerticalScrollbarHighlightOnWheel = false;
            this.gbTipoEntrenamiento.VerticalScrollbarSize = 10;
            this.gbTipoEntrenamiento.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(117, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 23);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 116);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 88;
            this.metroLabel5.Text = "Tipos Ejercicios:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(281, 138);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Asignados";
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnDesasignar.ForeColor = System.Drawing.Color.White;
            this.btnDesasignar.Location = new System.Drawing.Point(173, 270);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(54, 29);
            this.btnDesasignar.TabIndex = 85;
            this.btnDesasignar.Text = "<";
            this.btnDesasignar.UseSelectable = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(47, 138);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Sin Asignar";
            // 
            // lblTipoEntrenamiento
            // 
            this.lblTipoEntrenamiento.AutoSize = true;
            this.lblTipoEntrenamiento.Location = new System.Drawing.Point(6, 0);
            this.lblTipoEntrenamiento.Name = "lblTipoEntrenamiento";
            this.lblTipoEntrenamiento.Size = new System.Drawing.Size(162, 19);
            this.lblTipoEntrenamiento.TabIndex = 36;
            this.lblTipoEntrenamiento.Text = "ID Tipo de Entrenamiento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.DisplayFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(117, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(184, 23);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(173, 206);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(54, 29);
            this.btnAsignar.TabIndex = 84;
            this.btnAsignar.Text = ">";
            this.btnAsignar.UseSelectable = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lvAsignado
            // 
            this.lvAsignado.HideSelection = false;
            this.lvAsignado.Location = new System.Drawing.Point(233, 160);
            this.lvAsignado.Name = "lvAsignado";
            this.lvAsignado.Size = new System.Drawing.Size(161, 193);
            this.lvAsignado.TabIndex = 83;
            this.lvAsignado.UseCompatibleStateImageBehavior = false;
            this.lvAsignado.View = System.Windows.Forms.View.List;
            // 
            // txtIdTipoEntrenamiento
            // 
            // 
            // 
            // 
            this.txtIdTipoEntrenamiento.CustomButton.Image = null;
            this.txtIdTipoEntrenamiento.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.txtIdTipoEntrenamiento.CustomButton.Name = "";
            this.txtIdTipoEntrenamiento.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdTipoEntrenamiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdTipoEntrenamiento.CustomButton.TabIndex = 1;
            this.txtIdTipoEntrenamiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdTipoEntrenamiento.CustomButton.UseSelectable = true;
            this.txtIdTipoEntrenamiento.CustomButton.Visible = false;
            this.txtIdTipoEntrenamiento.Enabled = false;
            this.txtIdTipoEntrenamiento.Lines = new string[0];
            this.txtIdTipoEntrenamiento.Location = new System.Drawing.Point(6, 22);
            this.txtIdTipoEntrenamiento.MaxLength = 32767;
            this.txtIdTipoEntrenamiento.Name = "txtIdTipoEntrenamiento";
            this.txtIdTipoEntrenamiento.PasswordChar = '\0';
            this.txtIdTipoEntrenamiento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdTipoEntrenamiento.SelectedText = "";
            this.txtIdTipoEntrenamiento.SelectionLength = 0;
            this.txtIdTipoEntrenamiento.SelectionStart = 0;
            this.txtIdTipoEntrenamiento.ShortcutsEnabled = true;
            this.txtIdTipoEntrenamiento.Size = new System.Drawing.Size(388, 29);
            this.txtIdTipoEntrenamiento.TabIndex = 34;
            this.txtIdTipoEntrenamiento.UseSelectable = true;
            this.txtIdTipoEntrenamiento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdTipoEntrenamiento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lvSinAsignar
            // 
            this.lvSinAsignar.HideSelection = false;
            this.lvSinAsignar.Location = new System.Drawing.Point(6, 160);
            this.lvSinAsignar.Name = "lvSinAsignar";
            this.lvSinAsignar.Size = new System.Drawing.Size(161, 193);
            this.lvSinAsignar.TabIndex = 82;
            this.lvSinAsignar.UseCompatibleStateImageBehavior = false;
            this.lvSinAsignar.View = System.Windows.Forms.View.List;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(360, 1);
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
            this.txtNombre.Size = new System.Drawing.Size(388, 29);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // gridTipoEntrenamiento
            // 
            this.gridTipoEntrenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTipoEntrenamiento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRol,
            this.Nombre});
            this.gridTipoEntrenamiento.FullRowSelect = true;
            this.gridTipoEntrenamiento.GridLines = true;
            this.gridTipoEntrenamiento.HideSelection = false;
            this.gridTipoEntrenamiento.Location = new System.Drawing.Point(23, 99);
            this.gridTipoEntrenamiento.MultiSelect = false;
            this.gridTipoEntrenamiento.Name = "gridTipoEntrenamiento";
            this.gridTipoEntrenamiento.Size = new System.Drawing.Size(276, 375);
            this.gridTipoEntrenamiento.TabIndex = 75;
            this.gridTipoEntrenamiento.UseCompatibleStateImageBehavior = false;
            this.gridTipoEntrenamiento.View = System.Windows.Forms.View.Details;
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
            // FrmTiposEntrenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 545);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.gbTipoEntrenamiento);
            this.Controls.Add(this.gridTipoEntrenamiento);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmTiposEntrenamientos";
            this.Resizable = false;
            this.Text = "Gestión Tipos de Entrenamientos";
            this.Activated += new System.EventHandler(this.FrmTiposEntrenamientos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.gbTipoEntrenamiento.ResumeLayout(false);
            this.gbTipoEntrenamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel gbTipoEntrenamiento;
        private MetroFramework.Controls.MetroLabel lblTipoEntrenamiento;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtIdTipoEntrenamiento;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.ListView gridTipoEntrenamiento;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnDesasignar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnAsignar;
        private System.Windows.Forms.ListView lvAsignado;
        private System.Windows.Forms.ListView lvSinAsignar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}