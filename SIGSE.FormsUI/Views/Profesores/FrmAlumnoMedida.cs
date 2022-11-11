using System;
using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
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
    public partial class FrmAlumnoMedida : MetroFramework.Forms.MetroForm
    {
        Alumno alumno;
        private Usuario currentUser;
        private AlumnosController cAlumnos;

        public FrmAlumnoMedida(Alumno _alumno)
        {
            cAlumnos = AlumnosController.obtenerInstancia();
            currentUser = cAlumnos.obtenerSesionUsuario();
            this.alumno = _alumno;
            InitializeComponent();
            txtAlumno.Text = alumno.nombrecompleto;
            dtpFechaMedida.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Medida medida = new Medida();

            medida.fecha = dtpFechaMedida.Value;
            medida.altura = (int) numAltura.Value;
            medida.brazo = (int)numBrazo.Value;
            medida.cadera = (int)numCadera.Value;
            medida.cintura = (int)numCintura.Value;
            medida.hombro = (int)numHombro.Value;
            medida.pierna = (int)numPierna.Value;
            medida.peso = (int)numPeso.Value;
            medida.pecho = (int)numPecho.Value;

            alumno.medidas.Add(medida);
            cAlumnos.modificarAlumno(alumno);

            MetroMessageBox.Show(this, "Medida agregada correctamente", "Exito!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
