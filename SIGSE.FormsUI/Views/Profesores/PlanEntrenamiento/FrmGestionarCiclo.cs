using MetroFramework;
using OfficeOpenXml;
using SIGSE.Bussines.TemplateReport;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmGestionarCiclo : MetroFramework.Forms.MetroForm
    {
        String ACCION;
        Alumno alumno;
        EjercicioIntensidad ejercicioGlobal;
        Ciclo ciclo;
        int diaCount, semanaCount;
        private Usuario currentUser;
        private CiclosController cCiclos;

        public FrmGestionarCiclo(Alumno _alumno, Ciclo _ciclo)
        {
            this.alumno = _alumno;
            _ciclo.semanas = _ciclo.semanas.OrderBy(s => s.orden).ToList();
            this.ciclo = _ciclo;
            diaCount = 0;
            semanaCount = 0;
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            InitializeComponent();
            lblTipoEntrenamiento.Text = ciclo.tipo_entrenamiento.nombre;
            actualizarDiaSemana();
            cargarComboEstadoSemana();
            cargarEjercicios();
            cargarPlantillasDias();
            this.Text = _alumno.nombrecompleto + "   |   " + ciclo.fecha_inicio.ToShortDateString() + " - " + ciclo.calcularFechaFin().ToShortDateString();
            cargarPlanillaEjercicio(diaCount, semanaCount);

            cargarComboEstadoSemana();
            cbxFormato.SelectedIndex = 1;

        }

        private void actualizarDiaSemana()
        {
            lblSemana.Text = "SEMANA " + (semanaCount + 1).ToString();
            lblDIA.Text = "DIA " + (diaCount + 1).ToString();

            if (diaCount == 0)
                btnPrevDay.Visible = false;
            else
                btnPrevDay.Visible = true;

            if (diaCount == (ciclo.semanas[semanaCount].dias.Count - 1))
                btnNextDay.Visible = false;
            else
                btnNextDay.Visible = true;

            if (semanaCount == 0)
                btnPrevWeek.Visible = false;
            else
                btnPrevWeek.Visible = true;

            if (semanaCount == (ciclo.semanas.Count - 1))
                btnNextWeek.Visible = false;
            else
                btnNextWeek.Visible = true;
        }

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            semanaCount--;
            cargarPlanillaEjercicio(diaCount, semanaCount);
            actualizarDiaSemana();
            //actualizarEstadosSemana(semanaCount);
            cargarComboEstadoSemana();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            semanaCount++;
            cargarPlanillaEjercicio(diaCount, semanaCount);
            actualizarDiaSemana();
            //actualizarEstadosSemana(semanaCount);
            cargarComboEstadoSemana();
        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            diaCount--;
            cargarPlanillaEjercicio(diaCount, semanaCount);
            actualizarDiaSemana();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            diaCount++;
            cargarPlanillaEjercicio(diaCount, semanaCount);
            actualizarDiaSemana();
        }

        private void cargarEjercicios()
        {
            cbxEjercicios.DataSource = cCiclos.obtenerEjerciciosSegunTipoEntrenamiento(ciclo.tipo_entrenamiento);
            cbxEjercicios.DisplayMember = "nombre";
        }

        private void cargarPlantillasDias()
        {
            cbxPlantillas.DataSource = cCiclos.obtenerPlantillas();
            cbxPlantillas.DisplayMember = "nombre";
        }

        private void cargarPlanillaEjercicio(int dd, int sem)
        {
            gridEjercicios.Items.Clear();
            int i = 1;
            foreach (EjercicioIntensidad ej in ciclo.semanas[sem].dias[dd].ejercicios)
            {
                string[] row =
                {
                    ej.idEjercicioIntensidad.ToString(),
                    i.ToString(),
                    ej.ejercicio.nombre,
                    ej.series.ToString(),
                    ej.repeticiones.ToString(),
                    ej.peso.ToString(),
                    ej.descanso.ToString()
                };
                var listViewItem = new ListViewItem(row);
                gridEjercicios.Items.Add(listViewItem);
                i++;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ejercicioGlobal.ejercicio = (Ejercicio)cbxEjercicios.SelectedValue;
            ejercicioGlobal.descanso = int.Parse(txtDescanso.Text);
            ejercicioGlobal.peso = float.Parse(txtPeso.Text);
            ejercicioGlobal.series = int.Parse(txtSeries.Text);
            ejercicioGlobal.repeticiones = int.Parse(txtRepeticiones.Text);
            if (ACCION == "A")
                cCiclos.agregarNuevoEjercicioAlCiclo(ejercicioGlobal, ciclo, semanaCount, diaCount);
            else
                cCiclos.modificarEjercicioIntensidad(ejercicioGlobal);

            cargarPlanillaEjercicio(diaCount, semanaCount);

            btnAgregar.Visible = true;
            lblAgregarEjercicio.Visible = true;
            panelForm.Visible = false;
            btnGuardar.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = "A";
            txtDescanso.Text = "5";
            txtPeso.Text = "5";
            txtSeries.Text = "5";
            txtRepeticiones.Text = "5";
            cbxEjercicios.SelectedIndex = 0;

            ejercicioGlobal = new EjercicioIntensidad();

            btnAgregar.Visible = false;
            lblAgregarEjercicio.Visible = false;
            panelForm.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ejercicio de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            EjercicioIntensidad ej = obtenerEjercicioSeleccionado();
            ACCION = "M";

            txtDescanso.Text = ej.descanso.ToString();
            txtPeso.Text = ej.peso.ToString();
            txtSeries.Text = ej.series.ToString();
            txtRepeticiones.Text = ej.repeticiones.ToString();
            cbxEjercicios.SelectedItem = ej.ejercicio;

            btnAgregar.Visible = false;
            lblAgregarEjercicio.Visible = false;
            panelForm.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridEjercicios.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Ejercicio de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }

            cCiclos.eliminarEjercicioIntensidad(obtenerEjercicioSeleccionado());
            cargarPlanillaEjercicio(diaCount, semanaCount);

        }

        private EjercicioIntensidad obtenerEjercicioSeleccionado()
        {
            int id = int.Parse(gridEjercicios.SelectedItems[0].Text);
            return cCiclos.obtenerEjercicioIntencidad(id);
        }


        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try {
                cCiclos.cambiarEstadoSemana(ciclo, ciclo.semanas[semanaCount], (EstadoSemana)cbxEstadoSemana.SelectedItem);
                MetroMessageBox.Show(this, "Cambio de estado exitoso", "Exito!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information,
                    100);
                return;
            } catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error,
                                    100);
                return;
            }
            finally
            {
                cargarComboEstadoSemana();
                this.Text = alumno.nombrecompleto + "   |   " + ciclo.fecha_inicio.ToShortDateString() + " - " + ciclo.calcularFechaFin().ToShortDateString();
            }
        }

        private void frmCrearPlantilla_Click(object sender, EventArgs e)
        {
            if (gridEjercicios.Items.Count < 1)
            {
                MetroMessageBox.Show(this, "Debe existir al menos un Ejercicio en la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error,
                                    100);
                return;
            };

            Utilities.Navegar.OpenNewTab(new CrearPlantilla(ciclo.semanas[semanaCount].dias[diaCount].ejercicios));
        }

        private void FrmGestionarCiclo_Activated(object sender, EventArgs e)
        {
        }

        private void btnCargarPlantilla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Está seguro que quiere cargar esta plantilla?", "ATENCION!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                100);

            if (dr == DialogResult.Yes)
            {

                PlantillaDia ptoPass = (PlantillaDia) cbxPlantillas.SelectedValue;
                List<EjercicioIntensidad> ejerciciosPlantilla = cCiclos.obtenerEjerciciosPlantilla(ptoPass);

                foreach (EjercicioIntensidad ej in ejerciciosPlantilla)
                {
                    EjercicioIntensidad newEj = new EjercicioIntensidad();
                    newEj.ejercicio = ej.ejercicio;
                    newEj.descanso = ej.descanso;
                    newEj.notas = ej.notas;
                    newEj.peso = ej.peso;
                    newEj.repeticiones = ej.repeticiones;
                    newEj.series = ej.series;
                    cCiclos.agregarNuevoEjercicioAlCiclo(newEj, ciclo, semanaCount, diaCount);

                }

                cargarPlanillaEjercicio(diaCount, semanaCount);

            }

        }

        private void pbArrowDown_Click(object sender, EventArgs e)
        {
            string ruta;

            if (cbxFormato.Text == "xlsx")
            {
                RutinaSemanalAbs rutina = new RutinaSemanalExcel();
                ruta = rutina.crearRutinaAndReturnPath(ciclo.semanas[semanaCount]);

                ExcelPackage excel = new ExcelPackage(ruta);

                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Title = "Save As";
                saveFD.Filter = "Excel File (*.xlsx)| *.xlsx";
                string nombre = alumno.nombrecompleto + "_" + "semana_" + ciclo.semanas[semanaCount].fecha_inicio.ToString("yyyy-MM-dd");
                saveFD.FileName = nombre;
                if (saveFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Stream stream = saveFD.OpenFile();
                    excel.SaveAs(stream);
                    stream.Close();
                }
            }
            else
            {
                RutinaSemanalAbs rutina = new RutinaSemanalCsv();
                ruta = rutina.crearRutinaAndReturnPath(ciclo.semanas[semanaCount]);

                StreamReader csv_file = new StreamReader(ruta);

                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Title = "Save As"; 
                string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                saveFD.Filter = filter;
                string nombre = alumno.nombrecompleto + "_" + "semana_" + ciclo.semanas[semanaCount].fecha_inicio.ToString("yyyy-MM-dd");
                saveFD.FileName = nombre;

                string selectedPath = "";
                if (saveFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectedPath = saveFD.FileName;
                    Console.WriteLine(selectedPath);
                    File.WriteAllText(selectedPath, csv_file.ReadToEnd().ToString());
                }

            }

            Console.WriteLine(ruta);

        }

        private void cargarComboEstadoSemana()
        {
            lbfecha_inicio.Text = ciclo.semanas[semanaCount].fecha_inicio.ToShortDateString();
            EstadoSemana estado = ciclo.semanas[semanaCount].estado;

            cbxEstadoSemana.Items.Clear();
            cbxEstadoSemana.Items.Add(estado);
            cbxEstadoSemana.SelectedIndex = 0;

            if(estado == EstadoSemana.BORRADOR)
            {
                cbxEstadoSemana.Items.Add(EstadoSemana.PENDIENTE);
            }

            if (estado == EstadoSemana.PENDIENTE)
            {
                cbxEstadoSemana.Items.Add(EstadoSemana.EN_CURSO);
                cbxEstadoSemana.Items.Add(EstadoSemana.POSPUESTA);
            }

            if (estado == EstadoSemana.EN_CURSO)
            {
                cbxEstadoSemana.Items.Add(EstadoSemana.POSPUESTA);
            }
        }
    }
}
