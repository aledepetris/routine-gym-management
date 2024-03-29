﻿using SIGSE.Bussines;
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

            PersonaManager.actualizarCiclosAlumnos();

            Context.SigseContext sigse = Context.SigseContext.obtenerInstancia();
            if (RolesManager.obtenerRolPorNombre(sigse, "Administrador") == null)
            {


                if (PermisoManager.obtenerPermisoPorNombre(sigse, "BackUp") == null)
                {
                    PermisoCompuesto permisosCompuesto;
                    permisosCompuesto = new PermisoCompuesto("BackUp");

                    permisosCompuesto.agregarNodo(new PermisoSimple("Resguardo"));
                    permisosCompuesto.agregarNodo(new PermisoSimple("Restauracion"));

                    PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                    rol.permisos.Add(permisosCompuesto);

                    foreach (PermisoSimple simple in permisosCompuesto.permisos)
                    {
                        rol.permisos.Add(simple);
                    }
                }

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Auditoria") == null)
                {
                    PermisoCompuesto permisosCompuesto;
                    permisosCompuesto = new PermisoCompuesto("Auditoria");

                    permisosCompuesto.agregarNodo(new PermisoSimple("Login-Logout"));
                    permisosCompuesto.agregarNodo(new PermisoSimple("Ciclos"));

                    PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                    rol.permisos.Add(permisosCompuesto);

                    foreach (PermisoSimple simple in permisosCompuesto.permisos)
                    {
                        rol.permisos.Add(simple);
                    }
                }

                if (PermisoManager.obtenerPermisoPorNombre(sigse, "Reportes") == null)
                {
                    PermisoCompuesto permisosCompuesto;
                    permisosCompuesto = new PermisoCompuesto("Reportes");

                    permisosCompuesto.agregarNodo(new PermisoSimple("Tablero"));
                    permisosCompuesto.agregarNodo(new PermisoSimple("Medidas Alumnos"));
                    
                    PermisoManager.agregarPermiso(sigse, permisosCompuesto);
                    rol.permisos.Add(permisosCompuesto);

                    foreach (PermisoSimple simple in permisosCompuesto.permisos)
                    {
                        rol.permisos.Add(simple);
                    }
                }


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
                alumno.sexo = "Masculino";
                alumno.DNI = 36477909;
                alumno.fechaInicio = DateTime.Today;
                alumno.fechaNacimiento = DateTime.Today;
                alumno.mail = "aledepetris@gmail.com";
                alumno.telefono = "3401418966";


                profesor.nombre = "Celina";
                profesor.apellido = "Reymundo";
                profesor.sexo = "Femenino";
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

            if (ObjetivoManager.obtenerObjetivoPorId(sigse, 1) == null)
            {
                ObjetivoManager.agregarObjetivos(sigse, new Objetivo("Fuerza", "-", 2, 4));
                ObjetivoManager.agregarObjetivos(sigse, new Objetivo("Hipertrofia", "-", 4, 5));
                ObjetivoManager.agregarObjetivos(sigse, new Objetivo("Bajar Peso", "-", 2, 3));
            }

            if (MusculoManager.obtenerMusculoPorId(sigse, 1) == null)
            {
                MusculoManager.agregarMusculos(sigse, new Musculo("Biceps"));
                MusculoManager.agregarMusculos(sigse, new Musculo("Pantorrillas"));
                MusculoManager.agregarMusculos(sigse, new Musculo("Triceps"));
                MusculoManager.agregarMusculos(sigse, new Musculo("Gemelos"));
                MusculoManager.agregarMusculos(sigse, new Musculo("Homoplatos"));
            }

            if (TipoEjercicioManager.obtenerTipoEjercicioPorId(sigse, 1) == null)
            {
                TipoEjercicio push = new TipoEjercicio("Push");
                TipoEjercicio pull = new  TipoEjercicio("Pull");
                TipoEjercicio torso = new TipoEjercicio("Torso");
                TipoEjercicio pierna = new TipoEjercicio("Pierna");
                TipoEjercicio cardio = new TipoEjercicio("Cardio");
                TipoEjercicio musc = new TipoEjercicio("Musculos Aislados");

                TipoEjercicioManager.agregarTipoEjercicios(sigse, push);
                TipoEjercicioManager.agregarTipoEjercicios(sigse, pull);
                TipoEjercicioManager.agregarTipoEjercicios(sigse, torso);
                TipoEjercicioManager.agregarTipoEjercicios(sigse, pierna);
                TipoEjercicioManager.agregarTipoEjercicios(sigse, cardio);
                TipoEjercicioManager.agregarTipoEjercicios(sigse, musc);


                List<TipoEjercicio> tipoEjercicios = new List<TipoEjercicio>();
                tipoEjercicios.Clear();
                tipoEjercicios.Add(push);
                tipoEjercicios.Add(pull);
                tipoEjercicios.Add(torso);
                tipoEjercicios.Add(pierna);
                tipoEjercicios.Add(musc);
                TipoEntrenamientoManager.agregarTipoEntrenamientos(sigse, new TipoEntrenamiento("Fullbody", tipoEjercicios));


                List<TipoEjercicio> tipoEjercicios1 = new List<TipoEjercicio>();
                tipoEjercicios1.Clear();
                tipoEjercicios1.Add(push);
                tipoEjercicios1.Add(pull);
                tipoEjercicios1.Add(torso);
                tipoEjercicios1.Add(pierna);
                tipoEjercicios1.Add(musc);
                tipoEjercicios1.Add(cardio);
                TipoEntrenamientoManager.agregarTipoEntrenamientos(sigse, new TipoEntrenamiento("Fullbody-Cardio", tipoEjercicios1));

                List<TipoEjercicio> tipoEjercicios2 = new List<TipoEjercicio>();
                tipoEjercicios2.Clear();
                tipoEjercicios2.Add(push);
                tipoEjercicios2.Add(pull);
                TipoEntrenamientoManager.agregarTipoEntrenamientos(sigse, new TipoEntrenamiento("Push-Pull", tipoEjercicios2));

                List<TipoEjercicio> tipoEjercicios3 = new List<TipoEjercicio>();
                tipoEjercicios3.Clear();
                tipoEjercicios3.Add(torso);
                tipoEjercicios3.Add(pierna);
                TipoEntrenamientoManager.agregarTipoEntrenamientos(sigse, new TipoEntrenamiento("Torso-Pierna", tipoEjercicios3));

                List<TipoEjercicio> tipoEjercicios4 = new List<TipoEjercicio>();
                tipoEjercicios4.Clear();
                tipoEjercicios4.Add(musc);
                TipoEntrenamientoManager.agregarTipoEntrenamientos(sigse, new TipoEntrenamiento("Musculos Aislados", tipoEjercicios4));

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmLogin.obtenerInstancia());
        }
    }



}