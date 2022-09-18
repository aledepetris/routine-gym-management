
namespace SIGSE.FormsUI.Views.Seguridad
{
    partial class FrmUsuarios
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
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.lvlExercises = new System.Windows.Forms.ListView();
            this.IdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Persona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonaEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxHome
            // 
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(23, 71);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(264, 24);
            this.tbxHome.TabIndex = 58;
            this.tbxHome.Text = "Usuarios";
            this.tbxHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxHome.UseCustomForeColor = true;
            this.tbxHome.UseSelectable = true;
            // 
            // lvlExercises
            // 
            this.lvlExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUsuario,
            this.Username,
            this.Persona,
            this.PersonaEmail,
            this.Activo});
            this.lvlExercises.FullRowSelect = true;
            this.lvlExercises.GridLines = true;
            this.lvlExercises.HideSelection = false;
            this.lvlExercises.Location = new System.Drawing.Point(23, 103);
            this.lvlExercises.MultiSelect = false;
            this.lvlExercises.Name = "lvlExercises";
            this.lvlExercises.Size = new System.Drawing.Size(573, 341);
            this.lvlExercises.TabIndex = 54;
            this.lvlExercises.UseCompatibleStateImageBehavior = false;
            this.lvlExercises.View = System.Windows.Forms.View.Details;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Text = "#";
            this.IdUsuario.Width = 37;
            // 
            // Username
            // 
            this.Username.Text = "Usuario";
            this.Username.Width = 133;
            // 
            // Persona
            // 
            this.Persona.Text = "Persona";
            this.Persona.Width = 173;
            // 
            // PersonaEmail
            // 
            this.PersonaEmail.Text = "e-mail";
            this.PersonaEmail.Width = 164;
            // 
            // Activo
            // 
            this.Activo.Text = "Activo";
            this.Activo.Width = 50;
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
            this.mpFooter.Location = new System.Drawing.Point(-7, 457);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(637, 30);
            this.mpFooter.TabIndex = 53;
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
            this.lblFooter.Location = new System.Drawing.Point(164, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 10);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.DisplayFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(466, 73);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 24);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.White;
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseCustomBackColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.UseStyleColors = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.DisplayFocus = true;
            this.btnModificar.Location = new System.Drawing.Point(330, 73);
            this.btnModificar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 24);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.White;
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseCustomBackColor = true;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.UseStyleColors = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.DisplayFocus = true;
            this.btnAgregar.Location = new System.Drawing.Point(194, 73);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.White;
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 486);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.lvlExercises);
            this.Controls.Add(this.mpFooter);
            this.MaximizeBox = false;
            this.Name = "FrmUsuarios";
            this.Resizable = false;
            this.Text = "Gestionar Usuarios";
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink tbxHome;
        private System.Windows.Forms.ListView lvlExercises;
        private System.Windows.Forms.ColumnHeader IdUsuario;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Persona;
        private System.Windows.Forms.ColumnHeader Activo;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.ColumnHeader PersonaEmail;
    }
}