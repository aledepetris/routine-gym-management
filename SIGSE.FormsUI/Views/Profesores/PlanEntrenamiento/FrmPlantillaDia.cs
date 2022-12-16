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
    public partial class CrearPlantilla : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private CiclosController cCiclos;

        List<EjercicioIntensidad> ejercicios;

        public CrearPlantilla(List<EjercicioIntensidad> _ejercicios)
        {
            this.ejercicios = _ejercicios;
            InitializeComponent();
            cCiclos = CiclosController.obtenerInstancia();
            currentUser = cCiclos.obtenerSesionUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PlantillaDia plantilla = new PlantillaDia();

            plantilla.nombre = txtNombre.Text;

            cCiclos.agregarNuevoDiaPlantilla(plantilla, ejercicios);

            MetroMessageBox.Show(this, "Persona creada correctamente ", "EXITO!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information,
                100);
            this.Close();
        }

    }
}
