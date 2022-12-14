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
    public partial class FrmMedidasAlumnos : MetroFramework.Forms.MetroForm
    {

        public FrmMedidasAlumnos(Alumno alumno)
        {
            InitializeComponent();

            // Altura
            int calculoAltura;
            calculoAltura = ((alumno.medidas[alumno.medidas.Count - 1].altura) * 100);
            float porcentajeAltura = (calculoAltura / alumno.medidas[0].altura) - 100;

            mbInicialAltura.Text = alumno.medidas[0].altura.ToString() + " cm";
            mlActualAltura.Text = alumno.medidas[alumno.medidas.Count - 1].altura.ToString() + " cm";

            lblPorcentajeAltura.ForeColor = Color.Green;
            lblPorcentajeAltura.Text = porcentajeAltura.ToString() + " %";
            if (porcentajeAltura < 0)
                lblPorcentajeAltura.ForeColor = Color.Red;

            // Peso
            int calculoPeso;
            calculoPeso = ((alumno.medidas[alumno.medidas.Count - 1].peso) * 100);
            float porcentajePeso = (calculoPeso / alumno.medidas[0].peso) - 100;

            mbInicialPeso.Text = alumno.medidas[0].peso.ToString() + " kg";
            mlActualPeso.Text = alumno.medidas[alumno.medidas.Count - 1].peso.ToString() + " kg";

            lblPorcentajePeso.Text = porcentajePeso.ToString() + " %";
            lblPorcentajePeso.ForeColor = Color.Red;
            if (porcentajePeso < 0)
                lblPorcentajePeso.ForeColor = Color.Green;

            // Hombro
            int calculoHombro;
            calculoHombro = ((alumno.medidas[alumno.medidas.Count - 1].hombro) * 100);
            float porcentajeHombro = (calculoHombro / alumno.medidas[0].hombro) - 100;

            mbInicialHombro.Text = alumno.medidas[0].hombro.ToString() + " cm";
            mlActualHombro.Text = alumno.medidas[alumno.medidas.Count - 1].hombro.ToString() + " cm";

            lblPorcentajeHombro.Text = porcentajeHombro.ToString() + " %";
            lblPorcentajeHombro.ForeColor = Color.Red;
            if (porcentajeHombro < 0)
                lblPorcentajeHombro.ForeColor = Color.Green;

            // Pecho
            int calculoPecho;
            calculoPecho = ((alumno.medidas[alumno.medidas.Count - 1].pecho) * 100);
            float porcentajePecho = (calculoPecho / alumno.medidas[0].pecho) - 100;

            mbInicialPecho.Text = alumno.medidas[0].pecho.ToString() + " cm";
            mlActualPecho.Text = alumno.medidas[alumno.medidas.Count - 1].pecho.ToString() + " cm";

            lblPorcentajePecho.Text = porcentajePecho.ToString() + " %";
            lblPorcentajePecho.ForeColor = Color.Red;
            if (porcentajePecho < 0)
                lblPorcentajePecho.ForeColor = Color.Green;

            // Brazo
            int calculoBrazo;
            calculoBrazo = ((alumno.medidas[alumno.medidas.Count - 1].brazo) * 100);
            float porcentajeBrazo = (calculoBrazo / alumno.medidas[0].brazo) - 100;

            mbInicialBrazo.Text = alumno.medidas[0].brazo.ToString() + " cm";
            mlActualBrazo.Text = alumno.medidas[alumno.medidas.Count - 1].brazo.ToString() + " cm";

            lblPorcentajeBrazo.Text = porcentajeBrazo.ToString() + " %";
            lblPorcentajeBrazo.ForeColor = Color.Red;
            if (porcentajeBrazo < 0)
                lblPorcentajeBrazo.ForeColor = Color.Green;

            // Cintura
            int calculoCintura;
            calculoCintura = ((alumno.medidas[alumno.medidas.Count - 1].cintura) * 100);
            float porcentajeCintura = (calculoCintura / alumno.medidas[0].cintura) - 100;

            mbInicialCintura.Text = alumno.medidas[0].cintura.ToString() + " cm";
            mlActualCintura.Text = alumno.medidas[alumno.medidas.Count - 1].cintura.ToString() + " cm";

            lblPorcentajeCintura.Text = porcentajeCintura.ToString() + " %";
            lblPorcentajeCintura.ForeColor = Color.Red;
            if (porcentajeCintura < 0)
                lblPorcentajeCintura.ForeColor = Color.Green;


            // Cadera
            int calculoCadera;
            calculoCadera = ((alumno.medidas[alumno.medidas.Count - 1].cadera) * 100);
            float porcentajeCadera = (calculoCadera / alumno.medidas[0].cadera) - 100;

            mbInicialCadera.Text = alumno.medidas[0].cadera.ToString() + " cm";
            mlActualCadera.Text = alumno.medidas[alumno.medidas.Count - 1].cadera.ToString() + " cm";

            lblPorcentajeCadera.Text = porcentajeCadera.ToString() + " %";
            lblPorcentajeCadera.ForeColor = Color.Red;
            if (porcentajeCadera < 0)
                lblPorcentajeCadera.ForeColor = Color.Green;

            // Pierna
            int calculoPierna;
            calculoPierna = ((alumno.medidas[alumno.medidas.Count - 1].pierna) * 100);
            float porcentajePierna = (calculoPierna / alumno.medidas[0].pierna) - 100;

            mbInicialPierna.Text = alumno.medidas[0].pierna.ToString() + " cm";
            mlActualPierna.Text = alumno.medidas[alumno.medidas.Count - 1].pierna.ToString() + " cm";

            lblPorcentajePierna.Text = porcentajePierna.ToString() + " %";
            lblPorcentajePierna.ForeColor = Color.Red;
            if (porcentajePierna < 0)
                lblPorcentajePierna.ForeColor = Color.Green;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
