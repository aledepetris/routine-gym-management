
namespace SIGSE.FormsUI.Views
{
    partial class FrmAlumnos
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnPlanEntrenamiento = new System.Windows.Forms.PictureBox();
            this.btnVerDetalle = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarAlumno = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gridAlumnos = new System.Windows.Forms.ListView();
            this.IdPersonas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAlumno)).BeginInit();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnPlanEntrenamiento);
            this.metroPanel1.Controls.Add(this.btnVerDetalle);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.btnAgregarAlumno);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.gridAlumnos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(791, 448);
            this.metroPanel1.TabIndex = 34;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(655, 365);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 38);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Plan\r\nEntrenamiento";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlanEntrenamiento
            // 
            this.btnPlanEntrenamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanEntrenamiento.Image = global::SIGSE.FormsUI.Properties.Resources.checklist1;
            this.btnPlanEntrenamiento.Location = new System.Drawing.Point(663, 294);
            this.btnPlanEntrenamiento.Name = "btnPlanEntrenamiento";
            this.btnPlanEntrenamiento.Size = new System.Drawing.Size(86, 68);
            this.btnPlanEntrenamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlanEntrenamiento.TabIndex = 50;
            this.btnPlanEntrenamiento.TabStop = false;
            this.btnPlanEntrenamiento.Click += new System.EventHandler(this.btnPlanEntrenamiento_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnVerDetalle.Image = global::SIGSE.FormsUI.Properties.Resources.search_file;
            this.btnVerDetalle.Location = new System.Drawing.Point(663, 161);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(86, 68);
            this.btnVerDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerDetalle.TabIndex = 48;
            this.btnVerDetalle.TabStop = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(665, 232);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 38);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "Ver Detalle \r\ndel Alumno";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlumno.Image = global::SIGSE.FormsUI.Properties.Resources.user;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(663, 37);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(86, 68);
            this.btnAgregarAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarAlumno.TabIndex = 46;
            this.btnAgregarAlumno.TabStop = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(676, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 38);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Agregar \r\nAlumno";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(13, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Listado:";
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPersonas,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Email,
            this.activo});
            this.gridAlumnos.FullRowSelect = true;
            this.gridAlumnos.GridLines = true;
            this.gridAlumnos.HideSelection = false;
            this.gridAlumnos.Location = new System.Drawing.Point(13, 37);
            this.gridAlumnos.MultiSelect = false;
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.Size = new System.Drawing.Size(640, 366);
            this.gridAlumnos.TabIndex = 36;
            this.gridAlumnos.UseCompatibleStateImageBehavior = false;
            this.gridAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // IdPersonas
            // 
            this.IdPersonas.Text = "#";
            this.IdPersonas.Width = 26;
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DNI.Width = 87;
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
            this.Apellido.Width = 107;
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
            this.mpFooter.Location = new System.Drawing.Point(-2, 490);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(796, 30);
            this.mpFooter.TabIndex = 44;
            this.mpFooter.UseCustomBackColor = true;
            this.mpFooter.VerticalScrollbarBarColor = true;
            this.mpFooter.VerticalScrollbarHighlightOnWheel = false;
            this.mpFooter.VerticalScrollbarSize = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(811, 10);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // activo
            // 
            this.activo.Text = "Activo";
            this.activo.Width = 46;
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 519);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmAlumnos";
            this.Resizable = false;
            this.Text = "Tus Alumnos";
            this.Activated += new System.EventHandler(this.FrmAlumnos_Activated);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAlumno)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListView gridAlumnos;
        private System.Windows.Forms.ColumnHeader IdPersonas;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DNI;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox btnAgregarAlumno;
        private System.Windows.Forms.PictureBox btnVerDetalle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox btnPlanEntrenamiento;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ColumnHeader activo;
    }
}