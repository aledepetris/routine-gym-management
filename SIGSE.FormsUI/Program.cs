using SIGSE.Bussines;
using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGSE.FormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Rol rol = new Rol();
            rol.nombre = "Administrador";
            rol.permisos = new List<Permiso>();

            Context.SigseContext sigse = Context.SigseContext.obtenerInstancia();
            if (RolesManager.obtenerRolPorNombre(sigse, "Administrador") == null)
            {

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Perfil") == null)
                {
                    PermisoCompuesto permisosCompuesto;
                    permisosCompuesto = new PermisoCompuesto("Perfil");

                    permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Password"));

                    PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                    rol.permisos.Add(permisosCompuesto);

                    foreach (PermisoSimple simple in permisosCompuesto.permisos)
                    {
                        rol.permisos.Add(simple);
                    }
                }

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Seguridad") == null)
                {
                    PermisoCompuesto permisoAbuelo;
                    permisoAbuelo = new PermisoCompuesto("Seguridad");

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Personas") == null)
                    {

                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Personas");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Personas"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Personas"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Personas"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Personas"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Usuarios") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Usuarios");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Usuarios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Usuarios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Usuarios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Usuarios"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }
                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Roles") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Roles");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Roles"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Roles"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Roles"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Roles"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    PermisoManager.agregarPermiso(sigse, permisoAbuelo);
                    rol.permisos.Add(permisoAbuelo);

                }

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Parametrizacion") == null)
                {
                    PermisoCompuesto permisoAbuelo;
                    permisoAbuelo = new PermisoCompuesto("Parametrizacion");

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Ejercicios") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Ejercicios");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Ejercicios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Ejercicios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Ejercicios"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Ejercicios"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Musculos") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Musculos");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Musculos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Musculos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Musculos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Musculos"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }

                    }
                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Objetivos") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Objetivos");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Objetivos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Objetivos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Objetivos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Objetivos"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }

                    }
                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Tipos de Ejercicio") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Tipos de Ejercicio");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Tipos de Ejercicio"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Tipos de Ejercicio"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Tipos de Ejercicio"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Tipos de Ejercicio"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Tipos de Entrenamiento") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Tipos de Entrenamiento");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Tipos de Entrenamiento"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Tipos de Entrenamiento"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Tipos de Entrenamiento"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Tipos de Entrenamiento"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    PermisoManager.agregarPermiso(sigse, permisoAbuelo);
                    rol.permisos.Add(permisoAbuelo);

                }

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Profesores") == null)
                {
                    PermisoCompuesto permisoAbuelo;
                    permisoAbuelo = new PermisoCompuesto("Profesores");

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Gestionar Alumnos") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Gestionar Alumnos");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Alumnos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Agregar Alumnos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Modificar Alumnos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Gestionar Ciclos"));
                        permisosCompuesto.agregarNodo(new PermisoSimple("Eliminar Alumnos"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    if (PermisoManager.obtenerPermisoPorNombre(sigse, "Informes") == null)
                    {
                        PermisoCompuesto permisosCompuesto;
                        permisosCompuesto = new PermisoCompuesto("Informes");

                        permisosCompuesto.agregarNodo(new PermisoSimple("Consultar Informes"));

                        permisoAbuelo.agregarNodo(permisosCompuesto);
                        // PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                        rol.permisos.Add(permisosCompuesto);

                        foreach (PermisoSimple simple in permisosCompuesto.permisos)
                        {
                            rol.permisos.Add(simple);
                        }
                    }

                    PermisoManager.agregarPermiso(sigse, permisoAbuelo);
                    rol.permisos.Add(permisoAbuelo);

                }
                RolesManager.agregarRol(sigse, rol);
            }

            if (PersonaManager.obtenerPesonaPorEmail(sigse, "aledepetris@gmail.com") == null)
            {
                #region cargaDatosPersona
                Alumno alumno = new Alumno();
                Profesor profesor = new Profesor();

                alumno.activo = true;
                alumno.nombre = "Alejandro";
                alumno.apellido = "Depetris";
                alumno.DNI = 36477909;
                alumno.fechaInicio = DateTime.Today;
                alumno.fechaNacimiento = DateTime.Today;
                alumno.mail = "aledepetris@gmail.com";
                alumno.telefono = "3401418966";


                profesor.nombre = "Celina";
                profesor.apellido = "Reymundo";
                profesor.DNI = 32000000;
                profesor.fechaNacimiento = DateTime.Today;
                profesor.mail = "celirey@gmail.com";
                profesor.telefono = "3401418966";
                profesor.crearListaAlumnos();
                profesor.agregarAlumno(alumno);

                PersonaManager.agregarPersonas(sigse, alumno);
                PersonaManager.agregarPersonas(sigse, profesor);

                Usuario user = new Usuario();
                user.activo = true;
                user.username = "aledepetris";
                user.password = "123456";
                user.persona = alumno;

                UsuarioManager.agregarUsuario(sigse, user);

                user.username = "celi";
                user.password = "123";
                user.persona = profesor;
                user.roles = new List<Rol>();
                user.roles.Add(rol);

                UsuarioManager.agregarUsuario(sigse, user);
                #endregion cargaDatosUsuarios 
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmLogin.obtenerInstancia());
        }
    }
}


/*
 DELETE
  FROM [SigseContext].[dbo].Usuarios

  DELETE
  FROM [SigseContext].[dbo].UsuarioRols
    
  DELETE
  FROM [SigseContext].[dbo].RolPermisoes

  DELETE
  FROM [SigseContext].[dbo].Rols

  DELETE
  FROM [SigseContext].[dbo].Permisoes

  DELETE
  FROM [SigseContext].[dbo].Personas
 */
