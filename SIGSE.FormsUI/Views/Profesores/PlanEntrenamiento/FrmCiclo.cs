using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmCiclo : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private CiclosController cCiclos;
        String ACCION;

        Alumno alumno;
        Ciclo ciclo;
        Objetivo objetivo;
        TipoEntrenamiento tipoEntrenamiento;

        public FrmCiclo(Alumno _alumno)
        {
            this.alumno = _alumno;
            InitializeComponent();
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            ACCION = "A";
            cbxESTADO.Enabled = false;
            dtpFechaInicio.Value = DateTime.Today;
            numSemanas.Text = "8";

            calcularFechaFin();
            cbxESTADO.Items.Add(EstadoCiclo.BORRADOR);
            configInicial();
            filtrarDiasObjetivos();
        }

        public FrmCiclo(Ciclo _ciclo)
        {
            this.ciclo = _ciclo;
            InitializeComponent();
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
            ACCION = "M";

            txtIdCiclo.Text = ciclo.idCiclo.ToString();
            numSemanas.Text = ciclo.obtenerCantidadSemanas().ToString();
            dtpFechaInicio.Value = ciclo.fecha_inicio;
            calcularFechaFin();

            // Fecha Fin + ESTADOS + Objetivos:
            cbxESTADO.Items.Add(ciclo.estado);
            cbxESTADO.SelectedIndex = 0;

            if (ciclo.estado == EstadoCiclo.EN_CURSO)
                configEstadoEnCurso();
            else
                configOtroEstado();

            if (ciclo.estado == EstadoCiclo.BORRADOR) 
            {
                cbxESTADO.Items.Add(EstadoCiclo.PENDIENTE);
                cbxESTADO.Items.Add(EstadoCiclo.CANCELADO);
            }

            if (ciclo.estado == EstadoCiclo.PENDIENTE || ciclo.estado == EstadoCiclo.EN_CURSO)
            {
                cbxESTADO.Items.Add(EstadoCiclo.CANCELADO);
            }

            cbxESTADO.Enabled = Enabled;
            configInicial();            
            // Cant Dias x Semana
            filtrarDiasObjetivos();
            // Tipos entramientos 
            filtrarTiposEntramientoDias();

            /// Ahora ajusto los valores: Objetivo, Dias, Tipo y Estado.
            cbxObjetivo.Text = ciclo.objetivo.nombre;
            cbxDias.Text = ciclo.cant_dias.ToString();
            cbxEntrenamiento.Text = ciclo.tipo_entrenamiento.nombre;

        }

        private void configEstadoEnCurso()
        {
            cbxDias.Enabled = false;
            cbxEntrenamiento.Enabled = false;
            cbxObjetivo.Enabled = false;
            numSemanas.Enabled = false;
            dtpFechaInicio.Enabled = false;
        }

        private void configOtroEstado()
        {
            cbxDias.Enabled = true;
            cbxEntrenamiento.Enabled = true;
            cbxObjetivo.Enabled = true;
            numSemanas.Enabled = true;
            dtpFechaInicio.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxObjetivo.SelectedItem == null || cbxEntrenamiento.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Complete los campos obligatorios", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }

            if (dtpFechaInicio.Value < DateTime.Today)
            {
                MetroMessageBox.Show(this, "Fecha en el pasado", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            calcularFechaFin();
            foreach (Ciclo ciclo in alumno.planEntrenamiento)
            {
                if (ciclo.estado != EstadoCiclo.CANCELADO)
                { 
                    if (dtpFechaInicio.Value >= ciclo.fecha_inicio && dtpFechaInicio.Value <= ciclo.calcularFechaFin())
                    {
                        MetroMessageBox.Show(this, "Coinciden Fechas", "ERROR!",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error,
                            100);
                        return;
                    }

                    if (dtpFechaFin.Value >= ciclo.fecha_inicio && dtpFechaFin.Value <= ciclo.calcularFechaFin())
                    {
                        MetroMessageBox.Show(this, "Coinciden Fechas", "ERROR!",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error,
                            100);
                        return;
                    }
                }
            }
            


            DateTime inicio = dtpFechaInicio.Value;
            objetivo = (Objetivo) cbxObjetivo.SelectedItem;
            int semanas = int.Parse(numSemanas.Text);
            tipoEntrenamiento = (TipoEntrenamiento) cbxEntrenamiento.SelectedItem;
            int dias = int.Parse(cbxDias.Text);

            if (ACCION == "A")
            {
                ciclo = new Ciclo(inicio, objetivo, semanas, tipoEntrenamiento, dias);
                cCiclos.agregarNuevoCiclo(alumno, ciclo);

                this.Close();
            }
            else
            {
                EstadoCiclo estadoCiclo = (EstadoCiclo) Enum.Parse(typeof(EstadoCiclo), cbxESTADO.SelectedItem.ToString());
                ciclo.estado = estadoCiclo;

                cCiclos.modificarCiclo(alumno, ciclo, inicio, objetivo, semanas, tipoEntrenamiento, dias);
                this.Close();
            }

            MetroMessageBox.Show(this, "Ciclo creado correctamente ", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularFechaFin()
        {
            decimal semanas = numSemanas.Value;
            int dias = (int)(semanas * 7);
            dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(dias);
        }

        private void filtrarTiposEntramientoDias()
        {
            int dias = int.Parse(cbxDias.Text);
            cbxEntrenamiento.DataSource = cCiclos.obtenerListaTiposEntrenamientos(objetivo, dias);
            cbxEntrenamiento.DisplayMember = "nombre";
        }

        private void configInicial()
        {
            cbxESTADO.SelectedIndex = 0;
            cbxObjetivo.DataSource = cCiclos.obtenerListaObjetivos();
            cbxObjetivo.DisplayMember = "nombre";
        }
        private void filtrarDiasObjetivos()
        {
            objetivo = (Objetivo) cbxObjetivo.SelectedItem;
            List<int> relleno = new List<int>();
            for (int i = objetivo.diasMinimo; i <= objetivo.diasMaximo; i++)
            {
                relleno.Add(i);
            }
            cbxDias.DataSource = relleno;
        }

        private void FrmCiclo_Activated(object sender, EventArgs e)
        {
            calcularFechaFin();
        }

        private void cbxObjetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarDiasObjetivos();
        }

        private void txtSemanas_TextChanged(object sender, EventArgs e)
        {
            calcularFechaFin();
        }

        private void cbxDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarTiposEntramientoDias();
        }

        private void numSemanas_ValueChanged(object sender, EventArgs e)
        {
            calcularFechaFin();
        }
    }
}
