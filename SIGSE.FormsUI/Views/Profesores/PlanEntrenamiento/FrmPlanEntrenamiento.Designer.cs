
namespace SIGSE.FormsUI.Views
{
    partial class FrmPlanEntrenamiento
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
            this.btnGestionarCiclo = new System.Windows.Forms.PictureBox();
            this.btnEliminarCiclo = new MetroFramework.Controls.MetroButton();
            this.btnModificarCiclo = new MetroFramework.Controls.MetroButton();
            this.btnPlanEntrenamiento = new System.Windows.Forms.PictureBox();
            this.btnAgregarCiclo = new MetroFramework.Controls.MetroButton();
            this.gridCiclos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nroCiclo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semanas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantDias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objetivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoEntrenamiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ciclos = new MetroFramework.Controls.MetroLabel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionarCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).BeginInit();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btnGestionarCiclo);
            this.metroPanel1.Controls.Add(this.btnEliminarCiclo);
            this.metroPanel1.Controls.Add(this.btnModificarCiclo);
            this.metroPanel1.Controls.Add(this.btnPlanEntrenamiento);
            this.metroPanel1.Controls.Add(this.btnAgregarCiclo);
            this.metroPanel1.Controls.Add(this.gridCiclos);
            this.metroPanel1.Controls.Add(this.Ciclos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(791, 297);
            this.metroPanel1.TabIndex = 34;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnGestionarCiclo
            // 
            this.btnGestionarCiclo.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionarCiclo.Image = global::SIGSE.FormsUI.Properties.Resources.checklist1;
            this.btnGestionarCiclo.Location = new System.Drawing.Point(425, 252);
            this.btnGestionarCiclo.Name = "btnGestionarCiclo";
            this.btnGestionarCiclo.Size = new System.Drawing.Size(64, 41);
            this.btnGestionarCiclo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGestionarCiclo.TabIndex = 60;
            this.btnGestionarCiclo.TabStop = false;
            this.btnGestionarCiclo.Click += new System.EventHandler(this.btnGestionarCiclo_Click);
            // 
            // btnEliminarCiclo
            // 
            this.btnEliminarCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCiclo.BackColor = System.Drawing.Color.Silver;
            this.btnEliminarCiclo.Location = new System.Drawing.Point(285, 256);
            this.btnEliminarCiclo.Name = "btnEliminarCiclo";
            this.btnEliminarCiclo.Size = new System.Drawing.Size(130, 34);
            this.btnEliminarCiclo.TabIndex = 59;
            this.btnEliminarCiclo.Text = "Eliminar Ciclo";
            this.btnEliminarCiclo.UseSelectable = true;
            this.btnEliminarCiclo.Click += new System.EventHandler(this.btnEliminarCiclo_Click);
            // 
            // btnModificarCiclo
            // 
            this.btnModificarCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCiclo.BackColor = System.Drawing.Color.Silver;
            this.btnModificarCiclo.Location = new System.Drawing.Point(149, 256);
            this.btnModificarCiclo.Name = "btnModificarCiclo";
            this.btnModificarCiclo.Size = new System.Drawing.Size(130, 34);
            this.btnModificarCiclo.TabIndex = 58;
            this.btnModificarCiclo.Text = "Modificar Ciclo";
            this.btnModificarCiclo.UseSelectable = true;
            this.btnModificarCiclo.Click += new System.EventHandler(this.btnModificarCiclo_Click);
            // 
            // btnPlanEntrenamiento
            // 
            this.btnPlanEntrenamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanEntrenamiento.Image = global::SIGSE.FormsUI.Properties.Resources.checklist1;
            this.btnPlanEntrenamiento.Location = new System.Drawing.Point(411, 336);
            this.btnPlanEntrenamiento.Name = "btnPlanEntrenamiento";
            this.btnPlanEntrenamiento.Size = new System.Drawing.Size(34, 34);
            this.btnPlanEntrenamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlanEntrenamiento.TabIndex = 57;
            this.btnPlanEntrenamiento.TabStop = false;
            // 
            // btnAgregarCiclo
            // 
            this.btnAgregarCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCiclo.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarCiclo.Location = new System.Drawing.Point(13, 256);
            this.btnAgregarCiclo.Name = "btnAgregarCiclo";
            this.btnAgregarCiclo.Size = new System.Drawing.Size(130, 34);
            this.btnAgregarCiclo.TabIndex = 55;
            this.btnAgregarCiclo.Text = "Agregar Ciclo";
            this.btnAgregarCiclo.UseSelectable = true;
            this.btnAgregarCiclo.Click += new System.EventHandler(this.btnAgregarCiclo_Click);
            // 
            // gridCiclos
            // 
            this.gridCiclos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCiclos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nroCiclo,
            this.fechaInicio,
            this.fechaFin,
            this.semanas,
            this.cantDias,
            this.objetivo,
            this.tipoEntrenamiento,
            this.estado});
            this.gridCiclos.FullRowSelect = true;
            this.gridCiclos.GridLines = true;
            this.gridCiclos.HideSelection = false;
            this.gridCiclos.Location = new System.Drawing.Point(13, 36);
            this.gridCiclos.MultiSelect = false;
            this.gridCiclos.Name = "gridCiclos";
            this.gridCiclos.Size = new System.Drawing.Size(752, 214);
            this.gridCiclos.TabIndex = 54;
            this.gridCiclos.UseCompatibleStateImageBehavior = false;
            this.gridCiclos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 0;
            // 
            // nroCiclo
            // 
            this.nroCiclo.Text = "#";
            this.nroCiclo.Width = 26;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Text = "Fecha Inicio";
            this.fechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fechaInicio.Width = 115;
            // 
            // fechaFin
            // 
            this.fechaFin.Text = "Fecha Fin";
            this.fechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fechaFin.Width = 119;
            // 
            // semanas
            // 
            this.semanas.Text = "Semanas";
            this.semanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.semanas.Width = 64;
            // 
            // cantDias
            // 
            this.cantDias.Text = "Cant. Días";
            this.cantDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantDias.Width = 66;
            // 
            // objetivo
            // 
            this.objetivo.Text = "Objetivo";
            this.objetivo.Width = 110;
            // 
            // tipoEntrenamiento
            // 
            this.tipoEntrenamiento.Text = "Tipo Entrenamiento";
            this.tipoEntrenamiento.Width = 129;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 75;
            // 
            // Ciclos
            // 
            this.Ciclos.AutoSize = true;
            this.Ciclos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Ciclos.Location = new System.Drawing.Point(13, 14);
            this.Ciclos.Name = "Ciclos";
            this.Ciclos.Size = new System.Drawing.Size(83, 19);
            this.Ciclos.TabIndex = 52;
            this.Ciclos.Text = "Ciclo Actual:";
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
            this.mpFooter.Location = new System.Drawing.Point(-2, 363);
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
            // FrmPlanEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 392);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmPlanEntrenamiento";
            this.Resizable = false;
            this.Text = "Plan Entrenamiento: ";
            this.Activated += new System.EventHandler(this.FrmPlanEntrenamiento_Activated);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionarCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView gridCiclos;
        private System.Windows.Forms.ColumnHeader nroCiclo;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader fechaInicio;
        private System.Windows.Forms.ColumnHeader fechaFin;
        private System.Windows.Forms.ColumnHeader semanas;
        private System.Windows.Forms.ColumnHeader cantDias;
        private System.Windows.Forms.ColumnHeader objetivo;
        private MetroFramework.Controls.MetroLabel Ciclos;
        private MetroFramework.Controls.MetroButton btnAgregarCiclo;
        private System.Windows.Forms.PictureBox btnPlanEntrenamiento;
        private System.Windows.Forms.ColumnHeader tipoEntrenamiento;
        private System.Windows.Forms.ColumnHeader estado;
        private MetroFramework.Controls.MetroButton btnEliminarCiclo;
        private MetroFramework.Controls.MetroButton btnModificarCiclo;
        private System.Windows.Forms.PictureBox btnGestionarCiclo;
    }
}