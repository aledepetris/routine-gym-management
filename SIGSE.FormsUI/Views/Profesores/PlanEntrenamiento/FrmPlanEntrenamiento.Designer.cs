
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
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.gridCiclos = new System.Windows.Forms.ListView();
            this.nroCiclo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semanas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantDias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objetivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarMedida = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnPlanEntrenamiento = new System.Windows.Forms.PictureBox();
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoEntrenamiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btnPlanEntrenamiento);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.btnAgregarMedida);
            this.metroPanel1.Controls.Add(this.gridCiclos);
            this.metroPanel1.Controls.Add(this.metroLabel4);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(13, 14);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Ciclo Actual:";
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
            this.gridCiclos.Size = new System.Drawing.Size(732, 202);
            this.gridCiclos.TabIndex = 54;
            this.gridCiclos.UseCompatibleStateImageBehavior = false;
            this.gridCiclos.View = System.Windows.Forms.View.Details;
            // 
            // nroCiclo
            // 
            this.nroCiclo.Text = "#";
            this.nroCiclo.Width = 26;
            // 
            // id
            // 
            this.id.DisplayIndex = 1;
            this.id.Text = "";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 0;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Text = "Fecha Inicio";
            this.fechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fechaInicio.Width = 106;
            // 
            // fechaFin
            // 
            this.fechaFin.Text = "Fecha Fin";
            this.fechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fechaFin.Width = 107;
            // 
            // semanas
            // 
            this.semanas.Text = "Semanas";
            this.semanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.semanas.Width = 92;
            // 
            // cantDias
            // 
            this.cantDias.Text = "Cant. Días";
            this.cantDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantDias.Width = 128;
            // 
            // objetivo
            // 
            this.objetivo.Text = "Objetivo";
            this.objetivo.Width = 46;
            // 
            // btnAgregarMedida
            // 
            this.btnAgregarMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMedida.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarMedida.Location = new System.Drawing.Point(43, 270);
            this.btnAgregarMedida.Name = "btnAgregarMedida";
            this.btnAgregarMedida.Size = new System.Drawing.Size(130, 23);
            this.btnAgregarMedida.TabIndex = 55;
            this.btnAgregarMedida.Text = "Agregar Medida";
            this.btnAgregarMedida.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.BackgroundImage = global::SIGSE.FormsUI.Properties.Resources.checklist;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(226, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            // 
            // btnPlanEntrenamiento
            // 
            this.btnPlanEntrenamiento.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanEntrenamiento.Image = global::SIGSE.FormsUI.Properties.Resources.checklist1;
            this.btnPlanEntrenamiento.Location = new System.Drawing.Point(393, 259);
            this.btnPlanEntrenamiento.Name = "btnPlanEntrenamiento";
            this.btnPlanEntrenamiento.Size = new System.Drawing.Size(34, 34);
            this.btnPlanEntrenamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlanEntrenamiento.TabIndex = 57;
            this.btnPlanEntrenamiento.TabStop = false;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            // 
            // tipoEntrenamiento
            // 
            this.tipoEntrenamiento.Text = "Tipo Entrenamiento";
            // 
            // FrmPlanEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 519);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmPlanEntrenamiento";
            this.Resizable = false;
            this.Text = "Plan Entrenamiento: ";
            this.Activated += new System.EventHandler(this.FrmAlumnos_Activated);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlanEntrenamiento)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAgregarMedida;
        private System.Windows.Forms.PictureBox btnPlanEntrenamiento;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.ColumnHeader tipoEntrenamiento;
        private System.Windows.Forms.ColumnHeader estado;
    }
}