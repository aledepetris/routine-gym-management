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
    public partial class FrmEjercicio : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private EjerciciosController cEjercicio;
        string ACCION;

        public FrmEjercicio()
        {
            inicializarForm();
            ACCION = "A";
            txtIdEjercicio.Text = "#";
            cargarListViews();

        }

        public FrmEjercicio(Ejercicio ejercicio)
        {
            inicializarForm();
            ACCION = "M";

            txtIdEjercicio.Text = ejercicio.idEjercicio.ToString();
            txtNombre.Text = ejercicio.nombre;

            if (ejercicio.total)
                cbxModo.SelectedIndex = 0;
            else
                cbxModo.SelectedIndex = 1;

            if (ejercicio.total)
                cbxForma.SelectedIndex = 0;
            else
                cbxForma.SelectedIndex = 1;

            cargarListViewsAsignaciones(ejercicio);

        }

        private void inicializarForm()
        {
            cEjercicio = EjerciciosController.obtenerInstancia();
            currentUser = cEjercicio.obtenerSesionUsuario();
            InitializeComponent();
            
        }

        private void btnAsignarMusculo_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvMusculoSinAsignar.SelectedItems;
            foreach (ListViewItem item in lista)
            {
                lvMusculoSinAsignar.Items.Remove(item);
                lvMusculoAsignado.Items.Add(item);
            }
        }

        private void btnDesasignarMusculo_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvMusculoAsignado.SelectedItems;
            foreach (ListViewItem item in lista)
            {
                lvMusculoAsignado.Items.Remove(item);
                lvMusculoSinAsignar.Items.Add(item);
            }
        }

        private void btnAsignarTipoEnt_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvTipoEjercicioSinAsignar.SelectedItems;
            foreach (ListViewItem item in lista)
            {
                lvTipoEjercicioSinAsignar.Items.Remove(item);
                lvTipoEjercicioAsignado.Items.Add(item);
            }
        }

        private void btnDesasignarTipoEnt_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lista = lvTipoEjercicioAsignado.SelectedItems;
            foreach (ListViewItem item in lista)
            {
                lvTipoEjercicioAsignado.Items.Remove(item);
                lvTipoEjercicioSinAsignar.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Ejercicio ejercicio;

            #region Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MetroMessageBox.Show(this, "Complete el campo Nombre", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion

            if (ACCION == "A")
            {
                ejercicio = new Ejercicio();
            }
            else
            {
                ejercicio = cEjercicio.obtenerEjercicioPorId(int.Parse(txtIdEjercicio.Text));
            }

            ejercicio.nombre = txtNombre.Text;

            if (cbxForma.SelectedIndex == 0)
                ejercicio.total = true;
            else
                ejercicio.total = false;

            if (cbxModo.SelectedIndex == 0)
                ejercicio.tiempo = true;
            else
                ejercicio.tiempo = false;

            List<Musculo> musculosAsignados = new List<Musculo>();
            List<TipoEjercicio> tipoEjercAsignados = new List<TipoEjercicio>();

            foreach (Musculo musculo in musculosAsignados)
                lvMusculoSinAsignar.Items.Add(musculo.nombre);

            foreach (TipoEjercicio tipoEjer in tipoEjercAsignados)
                lvTipoEjercicioSinAsignar.Items.Add(tipoEjer.nombre);

            foreach (ListViewItem item in lvMusculoAsignado.Items)
            {
                musculosAsignados.Add(cEjercicio.obtenerMusculoPorNombre(item.Text));
            }

            foreach (ListViewItem item in lvTipoEjercicioAsignado.Items)
            {
                tipoEjercAsignados.Add(cEjercicio.obtenerTipoEjercicioPorNombre(item.Text));
            }

            ejercicio.musculos = musculosAsignados;
            ejercicio.tipos_ejercicios = tipoEjercAsignados;

            cEjercicio.guardarEjercicio(ejercicio);

            MetroMessageBox.Show(this, "Ejercicio creado correctamente", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarListViews()
        {
            lvMusculoSinAsignar.Items.Clear();
            lvMusculoAsignado.Items.Clear();
            lvTipoEjercicioSinAsignar.Items.Clear();
            lvTipoEjercicioAsignado.Items.Clear();

            List<Musculo> musculoSinAsignar = cEjercicio.obtenerListaMusculos();
            List<TipoEjercicio> tipoEjercSinAsignar = cEjercicio.obtenerListaTipoEjercicios();

            foreach (Musculo musculo in musculoSinAsignar)
                lvMusculoSinAsignar.Items.Add(musculo.nombre);

            foreach (TipoEjercicio tipoEjer in tipoEjercSinAsignar)
                lvTipoEjercicioSinAsignar.Items.Add(tipoEjer.nombre);

        }

        public void cargarListViewsAsignaciones(Ejercicio ejercicio)
        {
            lvMusculoSinAsignar.Items.Clear();
            lvMusculoAsignado.Items.Clear();
            lvTipoEjercicioSinAsignar.Items.Clear();
            lvTipoEjercicioAsignado.Items.Clear();

            // Musculos
            List<Musculo> musculoSinAsignar = cEjercicio.obtenerListaMusculos();
            List<Musculo> musculosAsignados = ejercicio.musculos;
            if (musculosAsignados != null)
            {
                if (musculosAsignados.Count > 0)
                {
                    foreach (Musculo musculo in musculosAsignados)
                    {
                        musculoSinAsignar.Remove(musculo);
                        lvMusculoAsignado.Items.Add(musculo.nombre);
                    }
                }
            }
            foreach (Musculo musculo in musculoSinAsignar)
                lvMusculoSinAsignar.Items.Add(musculo.nombre);

            // Tipo Ejercicios
            List<TipoEjercicio> tiposEjSinAsignar = cEjercicio.obtenerListaTipoEjercicios();
            List<TipoEjercicio> tiposEjAsignados = ejercicio.tipos_ejercicios;
            if (tiposEjAsignados != null)
            {
                if (tiposEjAsignados.Count > 0)
                {
                    foreach (TipoEjercicio tipoEjercicio in tiposEjAsignados)
                    {
                        tiposEjSinAsignar.Remove(tipoEjercicio);
                        lvTipoEjercicioAsignado.Items.Add(tipoEjercicio.nombre);
                    }
                }

            }

            foreach (TipoEjercicio tipoEjercicio in tiposEjSinAsignar)
                lvTipoEjercicioSinAsignar.Items.Add(tipoEjercicio.nombre);

        }
    }
}
