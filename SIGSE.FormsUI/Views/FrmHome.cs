using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGSE.Entities;
using SIGSE.Controller;
using SIGSE.FormsUI.Views;
using System.IO;
using OfficeOpenXml;

namespace SIGSE.FormsUI.Views
{
    public partial class FrmHome : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private HomeController cHome;

        private static FrmHome instancia;
        public static FrmHome obtenerInstancia()
        {
            if (instancia == null)
                instancia = new FrmHome();
            if (instancia.IsDisposed)
                instancia = new FrmHome();

            return instancia;
        }

        public FrmHome()
        {
            cHome = HomeController.obtenerInstancia();
            currentUser = cHome.obtenerSesionUsuario();
            InitializeComponent();
            tsmPerfil.Visible = false;
            tsmAdministrar.Visible = false;
            tsmParametrizacion.Visible = false;
            tsmProfesores.Visible = false;
            lblNombreApellido.Text = currentUser.persona.nombre.ToUpper() + " " + currentUser.persona.apellido.ToUpper();
            verificarPermisos();
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            cHome.realizarLogOut();
            Utilities.Navegar.Open(this, new FrmLogin());
        }

        private void tspCambiarPassword_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmCambiarPassword());
        }

        #region SubMenuAdministrar
        private void tspGestionarPersonas_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmPersonas());
        }

        private void tspGestionarRoles_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmRoles());
        }

        private void tspGestionarUsuarios_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmUsuarios());
        }
        #endregion


        #region SubMenuParametrizacion
        private void tspGestionarEjercicios_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmEjercicios());
        }

        private void tspGestionarMusculos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmMusculos());
        }

        private void tspGestionarObjetivos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmObjetivos());
        }

        private void tspGestionarTipoEjercicios_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmTipoEjercicios());
        }

        private void tspGestionarTipoEntrenamientos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmTiposEntrenamientos());
        }

        private void tspGestionarAlumnos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmAlumnos());
        }
        #endregion


        #region Permisos

        public void verificarPermisos()
        {
            List<Rol> roles = currentUser.roles.ToList();

            foreach (Rol rol in roles)
            {
                foreach (Permiso permiso in rol.permisos)
                {
                    if (permiso.nombre == "Modificar Password" && tspCambiarPassword.Visible == false)
                    {
                        tsmPerfil.Visible = true;
                        tspCambiarPassword.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Usuarios" && tspGestionarUsuarios.Visible == false)
                    {
                        tsmAdministrar.Visible = true;
                        tspGestionarUsuarios.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Personas" && tspGestionarPersonas.Visible == false)
                    {
                        tsmAdministrar.Visible = true;
                        tspGestionarPersonas.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Roles" && tspGestionarRoles.Visible == false)
                    {
                        tsmAdministrar.Visible = true;
                        tspGestionarRoles.Visible = true;
                    }


                    if (permiso.nombre == "Consultar Ejercicios" && tspGestionarEjercicios.Visible == false)
                    {
                        tsmParametrizacion.Visible = true;
                        tspGestionarEjercicios.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Musculos" && tspGestionarMusculos.Visible == false)
                    {
                        tsmParametrizacion.Visible = true;
                        tspGestionarMusculos.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Objetivos" && tspGestionarObjetivos.Visible == false)
                    {
                        tsmParametrizacion.Visible = true;
                        tspGestionarObjetivos.Visible = true;
                    }

                    if (permiso.nombre == "Consultar Tipos de Ejercicio" && tspGestionarTipoEjercicios.Visible == false)
                    {
                        tsmParametrizacion.Visible = true;
                        tspGestionarTipoEjercicios.Visible = true;
                    }


                    if (permiso.nombre == "Consultar Tipos de Entrenamiento" && tspGestionarTipoEntrenamientos.Visible == false)
                    {
                        tsmParametrizacion.Visible = true;
                        tspGestionarTipoEntrenamientos.Visible = true;
                    }


                    if (permiso.nombre == "Consultar Alumnos" && tspGestionarAlumnos.Visible == false)
                    {
                        tsmProfesores.Visible = true;
                        tspGestionarAlumnos.Visible = true;
                    }

                    if (permiso.nombre == "Login-Logout" && tspLoginLogout.Visible == false)
                    {
                        tsmAuditoria.Visible = true;
                        tspLoginLogout.Visible = true;
                    }

                    if (permiso.nombre == "Ciclos" && tspCiclos.Visible == false)
                    {
                        tsmAuditoria.Visible = true;
                        tspCiclos.Visible = true;
                    }

                    if (permiso.nombre == "Tablero" && tspTablero.Visible == false)
                    {
                        tsmReportes.Visible = true;
                        tspTablero.Visible = true;
                    }
                    
                    if (permiso.nombre == "Resguardo" && tspResguardo.Visible == false)
                    {
                        tsmResguardoRestauracion.Visible = true;
                        tspResguardo.Visible = true;
                    }

                    if (permiso.nombre == "Restauracion" && tspRestauracion.Visible == false)
                    {
                        tsmResguardoRestauracion.Visible = true;
                        tspRestauracion.Visible = true;
                    }
                    
                }
            }

        }


        #endregion


        private void tspLoginLogout_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmLoginLogout());
        }

        private void tspCiclos_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new FrmCiclosAuditoria());

        }

        private void tspTablero_Click(object sender, EventArgs e)
        {

        }

        private void tspMedidasAlumnos_Click(object sender, EventArgs e)
        {
            
        }

        private void tspResguardo_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new BackUp.frmExportar());
        }

        private void tspRestauracion_Click(object sender, EventArgs e)
        {
            Utilities.Navegar.OpenNewTab(new BackUp.frmImportar());
        }
    }
}
