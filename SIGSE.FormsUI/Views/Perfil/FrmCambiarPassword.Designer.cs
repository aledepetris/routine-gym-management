
namespace SIGSE.FormsUI.Views
{
    partial class FrmCambiarPassword
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
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNuevaPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRepetirPassword = new MetroFramework.Controls.MetroTextBox();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(23, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(267, 34);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFooter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(13, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 4;
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
            this.mpFooter.Location = new System.Drawing.Point(-3, 311);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(325, 30);
            this.mpFooter.TabIndex = 57;
            this.mpFooter.UseCustomBackColor = true;
            this.mpFooter.VerticalScrollbarBarColor = true;
            this.mpFooter.VerticalScrollbarHighlightOnWheel = false;
            this.mpFooter.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(23, 102);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(267, 29);
            this.txtPassword.TabIndex = 58;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(-239, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(811, 10);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "Nueva contraseña:";
            // 
            // txtNuevaPassword
            // 
            // 
            // 
            // 
            this.txtNuevaPassword.CustomButton.Image = null;
            this.txtNuevaPassword.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtNuevaPassword.CustomButton.Name = "";
            this.txtNuevaPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNuevaPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevaPassword.CustomButton.TabIndex = 1;
            this.txtNuevaPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevaPassword.CustomButton.UseSelectable = true;
            this.txtNuevaPassword.CustomButton.Visible = false;
            this.txtNuevaPassword.Lines = new string[0];
            this.txtNuevaPassword.Location = new System.Drawing.Point(23, 156);
            this.txtNuevaPassword.MaxLength = 32767;
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.PasswordChar = '*';
            this.txtNuevaPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaPassword.SelectedText = "";
            this.txtNuevaPassword.SelectionLength = 0;
            this.txtNuevaPassword.SelectionStart = 0;
            this.txtNuevaPassword.ShortcutsEnabled = true;
            this.txtNuevaPassword.Size = new System.Drawing.Size(267, 29);
            this.txtNuevaPassword.TabIndex = 61;
            this.txtNuevaPassword.UseSelectable = true;
            this.txtNuevaPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevaPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 188);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 19);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "Repetir contraseña:";
            // 
            // txtRepetirPassword
            // 
            // 
            // 
            // 
            this.txtRepetirPassword.CustomButton.Image = null;
            this.txtRepetirPassword.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtRepetirPassword.CustomButton.Name = "";
            this.txtRepetirPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRepetirPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepetirPassword.CustomButton.TabIndex = 1;
            this.txtRepetirPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepetirPassword.CustomButton.UseSelectable = true;
            this.txtRepetirPassword.CustomButton.Visible = false;
            this.txtRepetirPassword.Lines = new string[0];
            this.txtRepetirPassword.Location = new System.Drawing.Point(23, 210);
            this.txtRepetirPassword.MaxLength = 32767;
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.PasswordChar = '*';
            this.txtRepetirPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepetirPassword.SelectedText = "";
            this.txtRepetirPassword.SelectionLength = 0;
            this.txtRepetirPassword.SelectionStart = 0;
            this.txtRepetirPassword.ShortcutsEnabled = true;
            this.txtRepetirPassword.Size = new System.Drawing.Size(267, 29);
            this.txtRepetirPassword.TabIndex = 63;
            this.txtRepetirPassword.UseSelectable = true;
            this.txtRepetirPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepetirPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 338);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtRepetirPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNuevaPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarPassword";
            this.Resizable = false;
            this.Text = "Cambiar contraseña";
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNuevaPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRepetirPassword;
    }
}