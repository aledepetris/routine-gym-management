
namespace SIGSE.FormsUI.Views
{
    partial class FrmMusculos
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
            this.lblListaMusculos = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.gbFrmMusculos = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.lblIdMusculo = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtIdMusculos = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.gridMusculos = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mpFooter.SuspendLayout();
            this.gbFrmMusculos.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaMusculos
            // 
            this.lblListaMusculos.AutoSize = true;
            this.lblListaMusculos.Location = new System.Drawing.Point(23, 78);
            this.lblListaMusculos.Name = "lblListaMusculos";
            this.lblListaMusculos.Size = new System.Drawing.Size(110, 19);
            this.lblListaMusculos.TabIndex = 58;
            this.lblListaMusculos.Text = "Lista de Músculos";
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
            // gbFrmMusculos
            // 
            this.gbFrmMusculos.Controls.Add(this.btnCancelar);
            this.gbFrmMusculos.Controls.Add(this.lblIdMusculo);
            this.gbFrmMusculos.Controls.Add(this.btnGuardar);
            this.gbFrmMusculos.Controls.Add(this.txtIdMusculos);
            this.gbFrmMusculos.Controls.Add(this.txtNombre);
            this.gbFrmMusculos.Controls.Add(this.lblNombre);
            this.gbFrmMusculos.HorizontalScrollbarBarColor = true;
            this.gbFrmMusculos.HorizontalScrollbarHighlightOnWheel = false;
            this.gbFrmMusculos.HorizontalScrollbarSize = 10;
            this.gbFrmMusculos.Location = new System.Drawing.Point(305, 99);
            this.gbFrmMusculos.Name = "gbFrmMusculos";
            this.gbFrmMusculos.Size = new System.Drawing.Size(225, 204);
            this.gbFrmMusculos.TabIndex = 55;
            this.gbFrmMusculos.VerticalScrollbarBarColor = true;
            this.gbFrmMusculos.VerticalScrollbarHighlightOnWheel = false;
            this.gbFrmMusculos.VerticalScrollbarSize = 10;
            this.gbFrmMusculos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(8, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 23);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdMusculo
            // 
            this.lblIdMusculo.AutoSize = true;
            this.lblIdMusculo.Location = new System.Drawing.Point(6, -5);
            this.lblIdMusculo.Name = "lblIdMusculo";
            this.lblIdMusculo.Size = new System.Drawing.Size(76, 19);
            this.lblIdMusculo.TabIndex = 36;
            this.lblIdMusculo.Text = "ID Músculo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.DisplayFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(6, 106);
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
            // txtIdMusculos
            // 
            // 
            // 
            // 
            this.txtIdMusculos.CustomButton.Image = null;
            this.txtIdMusculos.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtIdMusculos.CustomButton.Name = "";
            this.txtIdMusculos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIdMusculos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdMusculos.CustomButton.TabIndex = 1;
            this.txtIdMusculos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdMusculos.CustomButton.UseSelectable = true;
            this.txtIdMusculos.CustomButton.Visible = false;
            this.txtIdMusculos.Enabled = false;
            this.txtIdMusculos.Lines = new string[0];
            this.txtIdMusculos.Location = new System.Drawing.Point(6, 17);
            this.txtIdMusculos.MaxLength = 32767;
            this.txtIdMusculos.Name = "txtIdMusculos";
            this.txtIdMusculos.PasswordChar = '\0';
            this.txtIdMusculos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdMusculos.SelectedText = "";
            this.txtIdMusculos.SelectionLength = 0;
            this.txtIdMusculos.SelectionStart = 0;
            this.txtIdMusculos.ShortcutsEnabled = true;
            this.txtIdMusculos.Size = new System.Drawing.Size(214, 29);
            this.txtIdMusculos.TabIndex = 34;
            this.txtIdMusculos.UseSelectable = true;
            this.txtIdMusculos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdMusculos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNombre.Location = new System.Drawing.Point(6, 71);
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(117, 266);
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
            this.btnEliminar.Location = new System.Drawing.Point(211, 266);
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
            this.btnAgregar.Location = new System.Drawing.Point(23, 266);
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
            // gridMusculos
            // 
            this.gridMusculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMusculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRol,
            this.Nombre});
            this.gridMusculos.FullRowSelect = true;
            this.gridMusculos.GridLines = true;
            this.gridMusculos.HideSelection = false;
            this.gridMusculos.Location = new System.Drawing.Point(23, 99);
            this.gridMusculos.MultiSelect = false;
            this.gridMusculos.Name = "gridMusculos";
            this.gridMusculos.Size = new System.Drawing.Size(276, 158);
            this.gridMusculos.TabIndex = 69;
            this.gridMusculos.UseCompatibleStateImageBehavior = false;
            this.gridMusculos.View = System.Windows.Forms.View.Details;
            // 
            // IdRol
            // 
            this.IdRol.Text = "#";
            this.IdRol.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 232;
            // 
            // FrmMusculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 335);
            this.Controls.Add(this.gridMusculos);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblListaMusculos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.gbFrmMusculos);
            this.MaximizeBox = false;
            this.Name = "FrmMusculos";
            this.Resizable = false;
            this.Text = "Gestionar Músculos";
            this.Activated += new System.EventHandler(this.FrmMusculos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            this.gbFrmMusculos.ResumeLayout(false);
            this.gbFrmMusculos.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblListaMusculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel gbFrmMusculos;
        private MetroFramework.Controls.MetroLabel lblIdMusculo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtIdMusculos;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.ListView gridMusculos;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
    }
}