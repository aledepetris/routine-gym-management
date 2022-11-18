
namespace SIGSE.FormsUI.Views
{
    partial class FrmGestionarCiclo
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
            this.btnNextWeek = new MetroFramework.Controls.MetroButton();
            this.lblSemana = new MetroFramework.Controls.MetroLabel();
            this.btnPrevWeek = new MetroFramework.Controls.MetroButton();
            this.btnPrevDay = new MetroFramework.Controls.MetroButton();
            this.lblDIA = new MetroFramework.Controls.MetroLabel();
            this.btnNextDay = new MetroFramework.Controls.MetroButton();
            this.gridEjercicios = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nroEjercicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ejercicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repeticiones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descanso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxPlantillas = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnElegirPlantilla = new MetroFramework.Controls.MetroButton();
            this.btnCargarPlantilla = new MetroFramework.Controls.MetroButton();
            this.cbxEstadoSemana = new MetroFramework.Controls.MetroComboBox();
            this.btnCambiarEstado = new MetroFramework.Controls.MetroButton();
            this.mpFooter = new MetroFramework.Controls.MetroPanel();
            this.lblFooter = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblTipoEntrenamiento = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblAgregarEjercicio = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNota = new System.Windows.Forms.PictureBox();
            this.txtDescanso = new MetroFramework.Controls.MetroTextBox();
            this.txtPeso = new MetroFramework.Controls.MetroTextBox();
            this.txtSeries = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRepeticiones = new MetroFramework.Controls.MetroTextBox();
            this.cbxEjercicios = new MetroFramework.Controls.MetroComboBox();
            this.lblEjercicio = new MetroFramework.Controls.MetroLabel();
            this.mpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnNextWeek.DisplayFocus = true;
            this.btnNextWeek.Location = new System.Drawing.Point(172, 72);
            this.btnNextWeek.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(19, 29);
            this.btnNextWeek.Style = MetroFramework.MetroColorStyle.White;
            this.btnNextWeek.TabIndex = 5;
            this.btnNextWeek.Text = ">";
            this.btnNextWeek.UseCustomBackColor = true;
            this.btnNextWeek.UseSelectable = true;
            this.btnNextWeek.UseStyleColors = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lblSemana
            // 
            this.lblSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSemana.AutoSize = true;
            this.lblSemana.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSemana.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSemana.Location = new System.Drawing.Point(51, 73);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(118, 25);
            this.lblSemana.TabIndex = 6;
            this.lblSemana.Text = "SEMANA XX";
            // 
            // btnPrevWeek
            // 
            this.btnPrevWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnPrevWeek.DisplayFocus = true;
            this.btnPrevWeek.Location = new System.Drawing.Point(23, 72);
            this.btnPrevWeek.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnPrevWeek.Name = "btnPrevWeek";
            this.btnPrevWeek.Size = new System.Drawing.Size(19, 29);
            this.btnPrevWeek.Style = MetroFramework.MetroColorStyle.White;
            this.btnPrevWeek.TabIndex = 7;
            this.btnPrevWeek.Text = "<";
            this.btnPrevWeek.UseCustomBackColor = true;
            this.btnPrevWeek.UseSelectable = true;
            this.btnPrevWeek.UseStyleColors = true;
            this.btnPrevWeek.Click += new System.EventHandler(this.btnPrevWeek_Click);
            // 
            // btnPrevDay
            // 
            this.btnPrevDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnPrevDay.DisplayFocus = true;
            this.btnPrevDay.Location = new System.Drawing.Point(48, 127);
            this.btnPrevDay.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnPrevDay.Name = "btnPrevDay";
            this.btnPrevDay.Size = new System.Drawing.Size(19, 29);
            this.btnPrevDay.Style = MetroFramework.MetroColorStyle.White;
            this.btnPrevDay.TabIndex = 10;
            this.btnPrevDay.Text = "<";
            this.btnPrevDay.UseCustomBackColor = true;
            this.btnPrevDay.UseSelectable = true;
            this.btnPrevDay.UseStyleColors = true;
            this.btnPrevDay.Click += new System.EventHandler(this.btnPrevDay_Click);
            // 
            // lblDIA
            // 
            this.lblDIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDIA.AutoSize = true;
            this.lblDIA.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDIA.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDIA.Location = new System.Drawing.Point(78, 129);
            this.lblDIA.Name = "lblDIA";
            this.lblDIA.Size = new System.Drawing.Size(73, 25);
            this.lblDIA.TabIndex = 9;
            this.lblDIA.Text = "DIA XX";
            // 
            // btnNextDay
            // 
            this.btnNextDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnNextDay.DisplayFocus = true;
            this.btnNextDay.Location = new System.Drawing.Point(151, 127);
            this.btnNextDay.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(19, 29);
            this.btnNextDay.Style = MetroFramework.MetroColorStyle.White;
            this.btnNextDay.TabIndex = 8;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseCustomBackColor = true;
            this.btnNextDay.UseSelectable = true;
            this.btnNextDay.UseStyleColors = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // gridEjercicios
            // 
            this.gridEjercicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEjercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nroEjercicio,
            this.ejercicio,
            this.series,
            this.repeticiones,
            this.peso,
            this.descanso});
            this.gridEjercicios.FullRowSelect = true;
            this.gridEjercicios.GridLines = true;
            this.gridEjercicios.HideSelection = false;
            this.gridEjercicios.Location = new System.Drawing.Point(48, 230);
            this.gridEjercicios.MultiSelect = false;
            this.gridEjercicios.Name = "gridEjercicios";
            this.gridEjercicios.Size = new System.Drawing.Size(676, 261);
            this.gridEjercicios.TabIndex = 70;
            this.gridEjercicios.UseCompatibleStateImageBehavior = false;
            this.gridEjercicios.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 0;
            // 
            // nroEjercicio
            // 
            this.nroEjercicio.Text = "#";
            this.nroEjercicio.Width = 26;
            // 
            // ejercicio
            // 
            this.ejercicio.Text = "Ejercicio";
            this.ejercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ejercicio.Width = 383;
            // 
            // series
            // 
            this.series.Text = "Series";
            this.series.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.series.Width = 51;
            // 
            // repeticiones
            // 
            this.repeticiones.Text = "Repeticiones";
            this.repeticiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeticiones.Width = 80;
            // 
            // peso
            // 
            this.peso.Text = "Peso";
            this.peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peso.Width = 56;
            // 
            // descanso
            // 
            this.descanso.Text = "Descanso";
            this.descanso.Width = 64;
            // 
            // cbxPlantillas
            // 
            this.cbxPlantillas.FormattingEnabled = true;
            this.cbxPlantillas.ItemHeight = 23;
            this.cbxPlantillas.Location = new System.Drawing.Point(282, 127);
            this.cbxPlantillas.Name = "cbxPlantillas";
            this.cbxPlantillas.Size = new System.Drawing.Size(294, 29);
            this.cbxPlantillas.TabIndex = 71;
            this.cbxPlantillas.UseSelectable = true;
            this.cbxPlantillas.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(210, 73);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 25);
            this.metroLabel6.TabIndex = 72;
            this.metroLabel6.Text = "Estado:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(776, 306);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(108, 19);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "Eliminar Ejercicio";
            // 
            // btnElegirPlantilla
            // 
            this.btnElegirPlantilla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElegirPlantilla.BackColor = System.Drawing.Color.Silver;
            this.btnElegirPlantilla.DisplayFocus = true;
            this.btnElegirPlantilla.Location = new System.Drawing.Point(176, 127);
            this.btnElegirPlantilla.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnElegirPlantilla.Name = "btnElegirPlantilla";
            this.btnElegirPlantilla.Size = new System.Drawing.Size(100, 29);
            this.btnElegirPlantilla.Style = MetroFramework.MetroColorStyle.White;
            this.btnElegirPlantilla.TabIndex = 75;
            this.btnElegirPlantilla.Text = "Elegir Plantilla";
            this.btnElegirPlantilla.UseCustomBackColor = true;
            this.btnElegirPlantilla.UseSelectable = true;
            this.btnElegirPlantilla.UseStyleColors = true;
            this.btnElegirPlantilla.Visible = false;
            // 
            // btnCargarPlantilla
            // 
            this.btnCargarPlantilla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarPlantilla.BackColor = System.Drawing.Color.Silver;
            this.btnCargarPlantilla.DisplayFocus = true;
            this.btnCargarPlantilla.Location = new System.Drawing.Point(582, 127);
            this.btnCargarPlantilla.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnCargarPlantilla.Name = "btnCargarPlantilla";
            this.btnCargarPlantilla.Size = new System.Drawing.Size(142, 29);
            this.btnCargarPlantilla.Style = MetroFramework.MetroColorStyle.White;
            this.btnCargarPlantilla.TabIndex = 76;
            this.btnCargarPlantilla.Text = "Cargar Plantilla";
            this.btnCargarPlantilla.UseCustomBackColor = true;
            this.btnCargarPlantilla.UseSelectable = true;
            this.btnCargarPlantilla.UseStyleColors = true;
            this.btnCargarPlantilla.Visible = false;
            // 
            // cbxEstadoSemana
            // 
            this.cbxEstadoSemana.FormattingEnabled = true;
            this.cbxEstadoSemana.ItemHeight = 23;
            this.cbxEstadoSemana.Location = new System.Drawing.Point(282, 73);
            this.cbxEstadoSemana.Name = "cbxEstadoSemana";
            this.cbxEstadoSemana.Size = new System.Drawing.Size(294, 29);
            this.cbxEstadoSemana.TabIndex = 77;
            this.cbxEstadoSemana.UseSelectable = true;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiarEstado.BackColor = System.Drawing.Color.Silver;
            this.btnCambiarEstado.DisplayFocus = true;
            this.btnCambiarEstado.Location = new System.Drawing.Point(582, 73);
            this.btnCambiarEstado.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(142, 29);
            this.btnCambiarEstado.Style = MetroFramework.MetroColorStyle.White;
            this.btnCambiarEstado.TabIndex = 78;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseCustomBackColor = true;
            this.btnCambiarEstado.UseSelectable = true;
            this.btnCambiarEstado.UseStyleColors = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
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
            this.mpFooter.Location = new System.Drawing.Point(-4, 500);
            this.mpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.mpFooter.Name = "mpFooter";
            this.mpFooter.Size = new System.Drawing.Size(932, 30);
            this.mpFooter.TabIndex = 80;
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
            this.lblFooter.Location = new System.Drawing.Point(322, 10);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(288, 15);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "Sistema Integral de Gestion de Entrenamiento y Salud";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCustomBackColor = true;
            this.lblFooter.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(742, 73);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(144, 19);
            this.metroLabel8.TabIndex = 81;
            this.metroLabel8.Text = "Tipo Entrenamiento:";
            // 
            // lblTipoEntrenamiento
            // 
            this.lblTipoEntrenamiento.AutoSize = true;
            this.lblTipoEntrenamiento.Location = new System.Drawing.Point(775, 95);
            this.lblTipoEntrenamiento.Name = "lblTipoEntrenamiento";
            this.lblTipoEntrenamiento.Size = new System.Drawing.Size(79, 19);
            this.lblTipoEntrenamiento.TabIndex = 82;
            this.lblTipoEntrenamiento.Text = "- xxxxxxxxxx";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Image = global::SIGSE.FormsUI.Properties.Resources.plus_icon_blue;
            this.btnAgregar.Location = new System.Drawing.Point(736, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 32);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 84;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Image = global::SIGSE.FormsUI.Properties.Resources.pencil2;
            this.btnModificar.Location = new System.Drawing.Point(736, 245);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(33, 32);
            this.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificar.TabIndex = 83;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(932, 10);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = global::SIGSE.FormsUI.Properties.Resources.trash;
            this.btnEliminar.Location = new System.Drawing.Point(736, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 32);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(778, 253);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(117, 19);
            this.metroLabel9.TabIndex = 85;
            this.metroLabel9.Text = "Modificar Ejercicio";
            // 
            // lblAgregarEjercicio
            // 
            this.lblAgregarEjercicio.AutoSize = true;
            this.lblAgregarEjercicio.Location = new System.Drawing.Point(778, 200);
            this.lblAgregarEjercicio.Name = "lblAgregarEjercicio";
            this.lblAgregarEjercicio.Size = new System.Drawing.Size(110, 19);
            this.lblAgregarEjercicio.TabIndex = 86;
            this.lblAgregarEjercicio.Text = "Agregar Ejercicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.btnGuardar.DisplayFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(778, 195);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(300, 35);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 32);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.btnNota);
            this.panelForm.Controls.Add(this.txtSeries);
            this.panelForm.Controls.Add(this.txtDescanso);
            this.panelForm.Controls.Add(this.lblEjercicio);
            this.panelForm.Controls.Add(this.txtPeso);
            this.panelForm.Controls.Add(this.cbxEjercicios);
            this.panelForm.Controls.Add(this.txtRepeticiones);
            this.panelForm.Controls.Add(this.metroLabel5);
            this.panelForm.Controls.Add(this.metroLabel1);
            this.panelForm.Controls.Add(this.metroLabel4);
            this.panelForm.Controls.Add(this.metroLabel2);
            this.panelForm.Controls.Add(this.metroLabel3);
            this.panelForm.Location = new System.Drawing.Point(48, 162);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(682, 65);
            this.panelForm.TabIndex = 88;
            this.panelForm.Visible = false;
            // 
            // btnNota
            // 
            this.btnNota.BackColor = System.Drawing.Color.Transparent;
            this.btnNota.Image = global::SIGSE.FormsUI.Properties.Resources.checklist;
            this.btnNota.Location = new System.Drawing.Point(651, 33);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(26, 29);
            this.btnNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNota.TabIndex = 100;
            this.btnNota.TabStop = false;
            // 
            // txtDescanso
            // 
            // 
            // 
            // 
            this.txtDescanso.CustomButton.Image = null;
            this.txtDescanso.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.txtDescanso.CustomButton.Name = "";
            this.txtDescanso.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDescanso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescanso.CustomButton.TabIndex = 1;
            this.txtDescanso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescanso.CustomButton.UseSelectable = true;
            this.txtDescanso.CustomButton.Visible = false;
            this.txtDescanso.Lines = new string[0];
            this.txtDescanso.Location = new System.Drawing.Point(563, 33);
            this.txtDescanso.MaxLength = 32767;
            this.txtDescanso.Name = "txtDescanso";
            this.txtDescanso.PasswordChar = '\0';
            this.txtDescanso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescanso.SelectedText = "";
            this.txtDescanso.SelectionLength = 0;
            this.txtDescanso.SelectionStart = 0;
            this.txtDescanso.ShortcutsEnabled = true;
            this.txtDescanso.Size = new System.Drawing.Size(82, 29);
            this.txtDescanso.TabIndex = 94;
            this.txtDescanso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescanso.UseSelectable = true;
            this.txtDescanso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescanso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPeso
            // 
            // 
            // 
            // 
            this.txtPeso.CustomButton.Image = null;
            this.txtPeso.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.txtPeso.CustomButton.Name = "";
            this.txtPeso.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPeso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeso.CustomButton.TabIndex = 1;
            this.txtPeso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeso.CustomButton.UseSelectable = true;
            this.txtPeso.CustomButton.Visible = false;
            this.txtPeso.Lines = new string[0];
            this.txtPeso.Location = new System.Drawing.Point(475, 33);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.ShortcutsEnabled = true;
            this.txtPeso.Size = new System.Drawing.Size(82, 29);
            this.txtPeso.TabIndex = 93;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.UseSelectable = true;
            this.txtPeso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSeries
            // 
            // 
            // 
            // 
            this.txtSeries.CustomButton.Image = null;
            this.txtSeries.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.txtSeries.CustomButton.Name = "";
            this.txtSeries.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSeries.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeries.CustomButton.TabIndex = 1;
            this.txtSeries.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeries.CustomButton.UseSelectable = true;
            this.txtSeries.CustomButton.Visible = false;
            this.txtSeries.Lines = new string[0];
            this.txtSeries.Location = new System.Drawing.Point(299, 33);
            this.txtSeries.MaxLength = 32767;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.PasswordChar = '\0';
            this.txtSeries.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeries.SelectedText = "";
            this.txtSeries.SelectionLength = 0;
            this.txtSeries.SelectionStart = 0;
            this.txtSeries.ShortcutsEnabled = true;
            this.txtSeries.Size = new System.Drawing.Size(82, 29);
            this.txtSeries.TabIndex = 91;
            this.txtSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeries.UseSelectable = true;
            this.txtSeries.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeries.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(647, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 99;
            this.metroLabel5.Text = "Nota";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(573, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 98;
            this.metroLabel4.Text = "Descanso";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(498, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 97;
            this.metroLabel3.Text = "Peso";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(387, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 96;
            this.metroLabel2.Text = "Repeticiones";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(317, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 95;
            this.metroLabel1.Text = "Series";
            // 
            // txtRepeticiones
            // 
            // 
            // 
            // 
            this.txtRepeticiones.CustomButton.Image = null;
            this.txtRepeticiones.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.txtRepeticiones.CustomButton.Name = "";
            this.txtRepeticiones.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRepeticiones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepeticiones.CustomButton.TabIndex = 1;
            this.txtRepeticiones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepeticiones.CustomButton.UseSelectable = true;
            this.txtRepeticiones.CustomButton.Visible = false;
            this.txtRepeticiones.Lines = new string[0];
            this.txtRepeticiones.Location = new System.Drawing.Point(387, 33);
            this.txtRepeticiones.MaxLength = 32767;
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.PasswordChar = '\0';
            this.txtRepeticiones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepeticiones.SelectedText = "";
            this.txtRepeticiones.SelectionLength = 0;
            this.txtRepeticiones.SelectionStart = 0;
            this.txtRepeticiones.ShortcutsEnabled = true;
            this.txtRepeticiones.Size = new System.Drawing.Size(82, 29);
            this.txtRepeticiones.TabIndex = 92;
            this.txtRepeticiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepeticiones.UseSelectable = true;
            this.txtRepeticiones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepeticiones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxEjercicios
            // 
            this.cbxEjercicios.FormattingEnabled = true;
            this.cbxEjercicios.ItemHeight = 23;
            this.cbxEjercicios.Location = new System.Drawing.Point(1, 33);
            this.cbxEjercicios.Name = "cbxEjercicios";
            this.cbxEjercicios.Size = new System.Drawing.Size(292, 29);
            this.cbxEjercicios.TabIndex = 90;
            this.cbxEjercicios.UseSelectable = true;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(118, 11);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(57, 19);
            this.lblEjercicio.TabIndex = 89;
            this.lblEjercicio.Text = "Ejercicio";
            // 
            // FrmGestionarCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 528);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblAgregarEjercicio);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTipoEntrenamiento);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.mpFooter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.cbxEstadoSemana);
            this.Controls.Add(this.btnCargarPlantilla);
            this.Controls.Add(this.btnElegirPlantilla);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbxPlantillas);
            this.Controls.Add(this.gridEjercicios);
            this.Controls.Add(this.btnPrevDay);
            this.Controls.Add(this.lblDIA);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnPrevWeek);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.btnNextWeek);
            this.MaximizeBox = false;
            this.Name = "FrmGestionarCiclo";
            this.Resizable = false;
            this.Text = "Nombre Apellido   |   Ciclo: 01/01/2022 - 02/02/2022";
            this.mpFooter.ResumeLayout(false);
            this.mpFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNextWeek;
        private MetroFramework.Controls.MetroLabel lblSemana;
        private MetroFramework.Controls.MetroButton btnPrevWeek;
        private MetroFramework.Controls.MetroButton btnPrevDay;
        private MetroFramework.Controls.MetroLabel lblDIA;
        private MetroFramework.Controls.MetroButton btnNextDay;
        private System.Windows.Forms.ListView gridEjercicios;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nroEjercicio;
        private System.Windows.Forms.ColumnHeader ejercicio;
        private System.Windows.Forms.ColumnHeader series;
        private System.Windows.Forms.ColumnHeader repeticiones;
        private System.Windows.Forms.ColumnHeader peso;
        private System.Windows.Forms.ColumnHeader descanso;
        private MetroFramework.Controls.MetroComboBox cbxPlantillas;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox btnEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnElegirPlantilla;
        private MetroFramework.Controls.MetroButton btnCargarPlantilla;
        private MetroFramework.Controls.MetroComboBox cbxEstadoSemana;
        private MetroFramework.Controls.MetroButton btnCambiarEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel mpFooter;
        private MetroFramework.Controls.MetroLabel lblFooter;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblTipoEntrenamiento;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblAgregarEjercicio;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox btnNota;
        private MetroFramework.Controls.MetroTextBox txtSeries;
        private MetroFramework.Controls.MetroTextBox txtDescanso;
        private MetroFramework.Controls.MetroLabel lblEjercicio;
        private MetroFramework.Controls.MetroTextBox txtPeso;
        private MetroFramework.Controls.MetroComboBox cbxEjercicios;
        private MetroFramework.Controls.MetroTextBox txtRepeticiones;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}