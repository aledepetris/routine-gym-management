
namespace SIGSE.FormsUI.Views.Personas
{
    partial class FrmPersonas
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lvlAuthorities = new System.Windows.Forms.ListView();
            this.IdPersonas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.metroPanel1.Controls.Add(this.btnEliminar);
            this.metroPanel1.Controls.Add(this.btnModificar);
            this.metroPanel1.Controls.Add(this.btnAgregar);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.lvlAuthorities);
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
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.DisplayFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(626, 7);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 24);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.White;
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar Persona";
            this.btnEliminar.UseCustomBackColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.UseStyleColors = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.DisplayFocus = true;
            this.btnModificar.Location = new System.Drawing.Point(490, 7);
            this.btnModificar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 24);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.White;
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "Modificar Persona";
            this.btnModificar.UseCustomBackColor = true;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.UseStyleColors = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.DisplayFocus = true;
            this.btnAgregar.Location = new System.Drawing.Point(354, 7);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.White;
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar Persona";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(13, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(124, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Listado de Persona";
            // 
            // lvlAuthorities
            // 
            this.lvlAuthorities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlAuthorities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPersonas,
            this.Tipo,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Email});
            this.lvlAuthorities.FullRowSelect = true;
            this.lvlAuthorities.GridLines = true;
            this.lvlAuthorities.HideSelection = false;
            this.lvlAuthorities.Location = new System.Drawing.Point(13, 34);
            this.lvlAuthorities.MultiSelect = false;
            this.lvlAuthorities.Name = "lvlAuthorities";
            this.lvlAuthorities.Size = new System.Drawing.Size(742, 367);
            this.lvlAuthorities.TabIndex = 36;
            this.lvlAuthorities.UseCompatibleStateImageBehavior = false;
            this.lvlAuthorities.View = System.Windows.Forms.View.Details;
            // 
            // IdPersonas
            // 
            this.IdPersonas.Text = "#";
            this.IdPersonas.Width = 30;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tipo.Width = 124;
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DNI.Width = 116;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Width = 106;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellido.Width = 126;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Tel.";
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefono.Width = 92;
            // 
            // Email
            // 
            this.Email.Text = "e-mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 128;
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
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmPersonas";
            this.Resizable = false;
            this.Text = "Gestionar Personas";
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
        private System.Windows.Forms.ListView lvlAuthorities;
        private System.Windows.Forms.ColumnHeader IdPersonas;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Tipo;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DNI;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}