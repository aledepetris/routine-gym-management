
namespace SIGSE.FormsUI.Views
{
    partial class FrmEjercicios
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
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxHome = new MetroFramework.Controls.MetroLink();
            this.gridEjercicios = new System.Windows.Forms.ListView();
            this.idEjercicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnEliminar.DisplayFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(465, 78);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 24);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.White;
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar Ejercicio";
            this.btnEliminar.UseCustomBackColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.UseStyleColors = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnModificar.DisplayFocus = true;
            this.btnModificar.Location = new System.Drawing.Point(329, 78);
            this.btnModificar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 24);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.White;
            this.btnModificar.TabIndex = 68;
            this.btnModificar.Text = "Modificar Ejercicio";
            this.btnModificar.UseCustomBackColor = true;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.UseStyleColors = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnAgregar.DisplayFocus = true;
            this.btnAgregar.Location = new System.Drawing.Point(193, 78);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.White;
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar Ejercicio";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(1, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 10);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // tbxHome
            // 
            this.tbxHome.BackColor = System.Drawing.Color.White;
            this.tbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHome.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tbxHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.tbxHome.Location = new System.Drawing.Point(22, 78);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(264, 24);
            this.tbxHome.TabIndex = 65;
            this.tbxHome.Text = "Ejercicios";
            this.tbxHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxHome.UseCustomForeColor = true;
            this.tbxHome.UseSelectable = true;
            // 
            // gridEjercicios
            // 
            this.gridEjercicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEjercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idEjercicio,
            this.nombre});
            this.gridEjercicios.FullRowSelect = true;
            this.gridEjercicios.GridLines = true;
            this.gridEjercicios.HideSelection = false;
            this.gridEjercicios.Location = new System.Drawing.Point(22, 108);
            this.gridEjercicios.MultiSelect = false;
            this.gridEjercicios.Name = "gridEjercicios";
            this.gridEjercicios.Size = new System.Drawing.Size(573, 341);
            this.gridEjercicios.TabIndex = 64;
            this.gridEjercicios.UseCompatibleStateImageBehavior = false;
            this.gridEjercicios.View = System.Windows.Forms.View.Details;
            // 
            // idEjercicio
            // 
            this.idEjercicio.Text = "#";
            this.idEjercicio.Width = 42;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 527;
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
            this.mpFooter.Location = new System.Drawing.Point(-1, 462);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(637, 30);
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
            this.lblFooter.Location = new System.Drawing.Point(164, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // FrmEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 491);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxHome);
            this.Controls.Add(this.gridEjercicios);
            this.Controls.Add(this.mpFooter);
            this.MaximizeBox = false;
            this.Name = "FrmEjercicios";
            this.Resizable = false;
            this.Text = "Gestionar Ejercicios";
            this.Activated += new System.EventHandler(this.FrmEjercicios_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink tbxHome;
        private System.Windows.Forms.ListView gridEjercicios;
        private System.Windows.Forms.ColumnHeader idEjercicio;
        private System.Windows.Forms.ColumnHeader nombre;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
    }
}