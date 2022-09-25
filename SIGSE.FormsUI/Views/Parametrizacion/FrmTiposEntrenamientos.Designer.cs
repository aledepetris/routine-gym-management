
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Administrador"}, -1);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbxMail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lvAcessFlags = new System.Windows.Forms.ListView();
            this.IdRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
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
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(117, 480);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 23);
            this.metroButton1.TabIndex = 80;
            this.metroButton1.Text = "Modificar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(211, 480);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 23);
            this.metroButton2.TabIndex = 79;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.UseSelectable = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(23, 480);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(88, 23);
            this.btnDel.TabIndex = 78;
            this.btnDel.Text = "Agregar";
            this.btnDel.UseSelectable = true;
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton5);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroButton3);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.metroButton4);
            this.metroPanel2.Controls.Add(this.listView2);
            this.metroPanel2.Controls.Add(this.tbxUsername);
            this.metroPanel2.Controls.Add(this.listView1);
            this.metroPanel2.Controls.Add(this.tbxMail);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(305, 87);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(401, 425);
            this.metroPanel2.TabIndex = 76;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "ID Tipo de Entrenamiento:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnSave.DisplayFocus = true;
            this.btnSave.Location = new System.Drawing.Point(105, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 37);
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
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(193, 1);
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
            this.tbxUsername.Size = new System.Drawing.Size(221, 29);
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
            this.tbxMail.CustomButton.Location = new System.Drawing.Point(193, 1);
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
            this.tbxMail.Size = new System.Drawing.Size(221, 29);
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
            this.lvAcessFlags.Location = new System.Drawing.Point(23, 99);
            this.lvAcessFlags.MultiSelect = false;
            this.lvAcessFlags.Name = "lvAcessFlags";
            this.lvAcessFlags.Size = new System.Drawing.Size(276, 375);
            this.lvAcessFlags.TabIndex = 75;
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
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(281, 130);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Asignados";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(47, 130);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Sin Asignar";
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Location = new System.Drawing.Point(173, 262);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(54, 29);
            this.metroButton3.TabIndex = 85;
            this.metroButton3.Text = "<";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.metroButton4.ForeColor = System.Drawing.Color.White;
            this.metroButton4.Location = new System.Drawing.Point(173, 198);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(54, 29);
            this.metroButton4.TabIndex = 84;
            this.metroButton4.Text = ">";
            this.metroButton4.UseSelectable = true;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(233, 152);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(161, 193);
            this.listView2.TabIndex = 83;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 193);
            this.listView1.TabIndex = 82;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 88;
            this.metroLabel5.Text = "Tipos Ejercicios:";
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Location = new System.Drawing.Point(105, 393);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(184, 23);
            this.metroButton5.TabIndex = 82;
            this.metroButton5.Text = "Cancelar";
            this.metroButton5.UseSelectable = true;
            // 
            // FrmTiposEntrenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 545);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lvAcessFlags);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmTiposEntrenamientos";
            this.Resizable = false;
            this.Text = "Gestión Tipos de Entrenamientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroTextBox tbxMail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView lvAcessFlags;
        private System.Windows.Forms.ColumnHeader IdRol;
        private System.Windows.Forms.ColumnHeader Nombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}