using MetroFramework;
using SIGSE.Controller;
using SIGSE.Entities;
using SIGSE.FormsUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI.Views.Informes
{
    public partial class FrmTablero : MetroFramework.Forms.MetroForm
    {
        TableroController cTablero;

        public FrmTablero()
        {
            InitializeComponent();
            cTablero = TableroController.obtenerInstancia();

            completarGraficoCiclosObjetivo();
            completarGraficoAlumnos();
            completarGraficoCiclosEstado();
            completarGraficosTiposEntrenamientos();
            completarAlumnosActivos();

            cargarComboProfesor();
            cargarComboAlumno();
        }


        private void completarAlumnosActivos()
        {
            List<Alumno> alumno = cTablero.obtenerAlumnos();

            var resultados = from c in alumno
                             group c by c.activo into total
                             select new
                             {
                                 nombre = total.Key ? "Activo" : "No Activo",
                                 cant = total.Count()
                             };

            int CANT = resultados.Count();

            String[] ARRAY_PLANES = new string[CANT];
            Double[] ARRAY_TOTALES = new double[CANT];
            int CONTADOR = 0;
            foreach (var p in resultados)
            {
                ARRAY_PLANES[CONTADOR] = p.nombre.ToString();
                ARRAY_TOTALES[CONTADOR] = ((double)p.cant);

                CONTADOR++;
            }

            chartAlumnosActivos.Series[0].Points.DataBindXY(ARRAY_PLANES, ARRAY_TOTALES);

        }


        private void completarGraficoCiclosObjetivo()
        {
            List<Ciclo> ciclos = cTablero.obtenerCiclos();

            var resultados = from c in ciclos
                             group c by c.objetivo.nombre into total
                             select new
                             {
                                 nombre = total.Key,
                                 cant = total.Count()
                             };


            int CANT = resultados.Count();

            String[] ARRAY_PLANES = new string[CANT];
            Double[] ARRAY_TOTALES = new double[CANT];
            int CONTADOR = 0;
            foreach (var p in resultados)
            {
                ARRAY_PLANES[CONTADOR] = p.nombre.ToString();
                ARRAY_TOTALES[CONTADOR] = ((double)p.cant);

                CONTADOR++;
            }
            chartObjetivos.Series[0].Points.DataBindXY(ARRAY_PLANES, ARRAY_TOTALES);
        }

        private void completarGraficoAlumnos()
        {
            List<Alumno> alumno = cTablero.obtenerAlumnos();

            var resultados = from c in alumno
                             group c by c.sexo into total
                             select new
                             {
                                 nombre = total.Key,
                                 cant = total.Count()
                             };

            int CANT = resultados.Count();

            String[] ARRAY_PLANES = new string[CANT];
            Double[] ARRAY_TOTALES = new double[CANT];
            int CONTADOR = 0;
            foreach (var p in resultados)
            {
                ARRAY_PLANES[CONTADOR] = p.nombre.ToString();
                ARRAY_TOTALES[CONTADOR] = ((double)p.cant);

                CONTADOR++;
            }

            chartAlumnos.Series[0].Points.DataBindXY(ARRAY_PLANES, ARRAY_TOTALES);

        }


        private void completarGraficoCiclosEstado()
        {
            List<Ciclo> ciclos = cTablero.obtenerCiclos();

            var resultados = from c in ciclos
                             group c by c.estado into total
                             select new
                             {
                                 nombre = total.Key,
                                 cant = total.Count()
                             };


            int CANT = resultados.Count();

            String[] ARRAY_PLANES = new string[CANT];
            Double[] ARRAY_TOTALES = new double[CANT];
            int CONTADOR = 0;

            foreach (var p in resultados)
            {
                ARRAY_PLANES[CONTADOR] = p.nombre.ToString();
                ARRAY_TOTALES[CONTADOR] = ((double)p.cant);

                CONTADOR++;
            }

            chartCiclosEstado.Series[0].Points.DataBindXY(ARRAY_PLANES, ARRAY_TOTALES);
        }

        private void completarGraficosTiposEntrenamientos()
        {
            List<Ciclo> ciclos = cTablero.obtenerCiclos();

            var resultados = from c in ciclos
                             group c by c.tipo_entrenamiento into total
                             select new
                             {
                                 nombre = total.Key.nombre,
                                 cant = total.Count()
                             };


            int CANT = resultados.Count();

            String[] ARRAY_PLANES = new string[CANT];
            Double[] ARRAY_TOTALES = new double[CANT];
            int CONTADOR = 0;

            foreach (var p in resultados)
            {
                ARRAY_PLANES[CONTADOR] = p.nombre.ToString();
                ARRAY_TOTALES[CONTADOR] = ((double)p.cant);

                CONTADOR++;
            }

            chartTiposEntrenamiento.Series[0].Points.DataBindXY(ARRAY_PLANES, ARRAY_TOTALES);
        }


        private void cargarComboProfesor()
        {
            cbxProfesor.DataSource = cTablero.obtenerProfesores();
            cbxProfesor.DisplayMember = "nombrecompleto";
        }


        private void cargarComboAlumno()
        {
            Profesor profe = (Profesor) cbxProfesor.SelectedItem;
            cbxAlumno.DataSource = cTablero.obtenerAlumnosPorProfesor(profe);
            cbxAlumno.DisplayMember = "nombrecompleto";

            cargarDatosAlumno();

        }

        private void cbxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboAlumno();
        }

        private void cargarDatosAlumno()
        {
            Alumno alum = (Alumno)cbxAlumno.SelectedItem;

            alum = cTablero.obtenerAlumno(alum);

            lbCiclo.Text = alum.planEntrenamiento.Count.ToString();

            int semanasCount = 0;
            int diasCount = 0;
            int ejerciciosCount = 0;
            foreach (Ciclo c in alum.planEntrenamiento)
            {
                foreach(Semana sem in c.semanas)
                {
                    semanasCount++;
                    foreach (Dia d in sem.dias)
                    {
                        diasCount++;
                        foreach (EjercicioIntensidad ej in d.ejercicios)
                        {
                            ejerciciosCount++;
                        }
                                        
                    }

                }

            }

            lbSemana.Text = semanasCount.ToString();
            lbDias.Text = diasCount.ToString();
            lbEjercicio.Text = ejerciciosCount.ToString();

        }


        private void btnReporteMedida_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alum = (Alumno)cbxAlumno.SelectedItem;
                Utilities.Navegar.OpenNewTab(new FrmMedidasAlumnos(alum));
            }
            catch
            {
                    MetroMessageBox.Show(this, "El Alumno no tiene más de 2 medidas registradas", "ERROR!",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error,
                        100);
            }

        }

        private void cbxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosAlumno();
        }
    }

    

}
