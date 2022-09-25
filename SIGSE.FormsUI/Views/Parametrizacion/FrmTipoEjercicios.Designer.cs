
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Administrador"}, -1);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbxMail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lvAcessFlags = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mpFooter.SuspendLayout();
            this.metroPanel2.SuspendLayout();
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.tbxUsername);
            this.metroPanel2.Controls.Add(this.tbxMail);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(305, 97);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(225, 171);
            this.metroPanel2.TabIndex = 55;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "ID Tipo de Ejercicio:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.DisplayFocus = true;
            this.btnSave.Location = new System.Drawing.Point(6, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 36);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.CustomButton.Image = null;
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.tbxUsername.CustomButton.Name = "";
            this.tbxUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUsername.CustomButton.TabIndex = 1;
            this.tbxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUsername.CustomButton.UseSelectable = true;
            this.tbxUsername.CustomButton.Visible = false;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(6, 22);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(214, 29);
            this.tbxUsername.TabIndex = 34;
            this.tbxUsername.UseSelectable = true;
            this.tbxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxMail
            // 
            // 
            // 
            // 
            this.tbxMail.CustomButton.Image = null;
            this.tbxMail.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.tbxMail.CustomButton.Name = "";
            this.tbxMail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxMail.CustomButton.TabIndex = 1;
            this.tbxMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxMail.CustomButton.UseSelectable = true;
            this.tbxMail.CustomButton.Visible = false;
            this.tbxMail.Lines = new string[0];
            this.tbxMail.Location = new System.Drawing.Point(6, 76);
            this.tbxMail.MaxLength = 32767;
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.PasswordChar = '\0';
            this.tbxMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxMail.SelectedText = "";
            this.tbxMail.SelectionLength = 0;
            this.tbxMail.SelectionStart = 0;
            this.tbxMail.ShortcutsEnabled = true;
            this.tbxMail.Size = new System.Drawing.Size(214, 29);
            this.tbxMail.TabIndex = 35;
            this.tbxMail.UseSelectable = true;
            this.tbxMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // lvAcessFlags
            // 
            this.lvAcessFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAcessFlags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRol,
            this.Nombre});
            this.lvAcessFlags.FullRowSelect = true;
            this.lvAcessFlags.GridLines = true;
            this.lvAcessFlags.HideSelection = false;
            this.lvAcessFlags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvAcessFlags.Location = new System.Drawing.Point(23, 97);
            this.lvAcessFlags.MultiSelect = false;
            this.lvAcessFlags.Name = "lvAcessFlags";
            this.lvAcessFlags.Size = new System.Drawing.Size(276, 158);
            this.lvAcessFlags.TabIndex = 54;
            this.lvAcessFlags.UseCompatibleStateImageBehavior = false;
            this.lvAcessFlags.View = System.Windows.Forms.View.Details;
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
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(117, 264);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 23);
            this.metroButton1.TabIndex = 67;
            this.metroButton1.Text = "Modificar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(211, 264);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 23);
            this.metroButton2.TabIndex = 66;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.UseSelectable = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(23, 264);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(88, 23);
            this.btnDel.TabIndex = 65;
            this.btnDel.Text = "Agregar";
            this.btnDel.UseSelectable = true;
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
            // FrmTipoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 335);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lvAcessFlags);
            this.MaximizeBox = false;
            this.Name = "FrmTipoEjercicios";
            this.Resizable = false;
            this.Text = "Gestionar Tipos De Ejercicios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
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
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroTextBox tbxMail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView lvAcessFlags;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}