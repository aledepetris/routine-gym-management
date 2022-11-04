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
    public partial class FrmRoles : MetroFramework.Forms.MetroForm
    {
        private Usuario currentUser;
        private RolesController cRoles;
        string ACCION;

        public FrmRoles()
        {
            cRoles = RolesController.obtenerInstancia();
            currentUser = cRoles.obtenerSesionUsuario();
            InitializeComponent();
        }

        private void FrmRoles_Activated(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTrvPermisos();
            panelFrm.Visible = false;
            cargarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = "A";
            limpiarTrvPermisos();
            panelFrm.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ACCION = "M";
            if (gridRoles.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Rol de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridRoles.SelectedItems[0].Text);
            cargarPermisos(cRoles.obtenerRolPorId(id));
            panelFrm.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridRoles.SelectedItems.Count == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Rol de la lista", "ATENCION!",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Warning,
                                    100);
                return;
            }
            int id = int.Parse(gridRoles.SelectedItems[0].Text);

            Rol rol = cRoles.obtenerRolPorId(id);
            cRoles.eliminarRol(rol);
            cargarLista();
            return;
        }

        private void cargarLista()
        {
            gridRoles.Items.Clear();
            List<Rol> listaRoles = cRoles.obtenerListaRoles();

            foreach (Rol rol in listaRoles)
            {
                string[] row =
                {
                    rol.idRol.ToString(),
                    rol.nombre
                };

                var listViewItem = new ListViewItem(row);
                gridRoles.Items.Add(listViewItem);
            }
        }

        private void cargarPermisos(Rol rol)
        {
            limpiarTrvPermisos();
            txtIDRol.Text = rol.idRol.ToString();
            txtNombre.Text = rol.nombre;

            foreach (Permiso permiso in rol.permisos)
            {
                if (permiso.GetType().Name == "PermisoCompuesto")
                {
                    PermisoCompuesto pCompuesto = (PermisoCompuesto)permiso;
                    foreach (TreeNode nodo_raiz in trvPermisos.Nodes)
                    {
                        if (nodo_raiz.Text == permiso.nombre)
                        {
                            trvPermisos.AfterCheck -= trvPermisos_AfterCheck;
                            nodo_raiz.Checked = true;
                            List<Permiso> listaPermisos = new List<Permiso>();
                            listaPermisos = pCompuesto.permisos;

                            foreach (Permiso permisoHijo in listaPermisos)
                            {
                                foreach (TreeNode nodo_hijo in nodo_raiz.Nodes)
                                {
                                    if (nodo_hijo.Text == permisoHijo.nombre)
                                    {
                                        trvPermisos.AfterCheck -= trvPermisos_AfterCheck;
                                        nodo_hijo.Checked = true;

                                        if (permisoHijo.GetType().Name == "PermisoCompuesto")
                                        {
                                            PermisoCompuesto pp = (PermisoCompuesto)permisoHijo;
                                            pp = cRoles.obtenerPermisoCompuestoPorId(pp.idPermiso);
                                            foreach (Permiso permisoNieto in pp.obtenerNodos())
                                            {
                                                foreach (TreeNode nodo_nieto in nodo_hijo.Nodes)
                                                {
                                                    if (nodo_nieto.Text == permisoNieto.nombre)
                                                    {
                                                        trvPermisos.AfterCheck -= trvPermisos_AfterCheck;
                                                        nodo_nieto.Checked = true;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            foreach (TreeNode nodo_hijo in nodo_raiz.Nodes)
                            {
                                trvPermisos.AfterCheck -= trvPermisos_AfterCheck;
                                if (nodo_hijo.Text == permiso.nombre)
                                {
                                    nodo_hijo.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
            trvPermisos.AfterCheck += trvPermisos_AfterCheck;
        }

        private void trvPermisos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            trvPermisos.AfterCheck -= trvPermisos_AfterCheck;

            if (e.Node.Parent != null)
            {
                bool result = false;
                foreach (TreeNode nodo in e.Node.Parent.Nodes)
                {
                    if (nodo.Checked)
                    {
                        result = true;
                        break;
                    }

                }
                e.Node.Parent.Checked = result;

                if (e.Node.Parent.Parent != null)
                {
                    bool result2 = false;
                    if (result)
                    {
                        e.Node.Parent.Parent.Checked = result;

                    }
                    else
                    {
                        foreach (TreeNode nodo2 in e.Node.Parent.Parent.Nodes)
                        {
                            if (nodo2.Checked)
                            {
                                result2 = true;
                                break;
                            }
                        }
                        e.Node.Parent.Parent.Checked = result2;
                    }
                }
            }

            if (e.Node.Nodes.Count > 0)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;

                    foreach (TreeNode node2 in node.Nodes)
                    {
                        node2.Checked = node.Checked;

                    }

                }
            }

            trvPermisos.AfterCheck += trvPermisos_AfterCheck;
        }

        private void limpiarTrvPermisos()
        {
            txtIDRol.Text = "";
            txtNombre.Text = "";
            foreach (TreeNode nodo_raiz in trvPermisos.Nodes)
            {
                nodo_raiz.Checked = false;

                foreach (TreeNode nodo_hijo in nodo_raiz.Nodes)
                {
                    nodo_hijo.Checked = false;

                    foreach (TreeNode nodo_nieto in nodo_hijo.Nodes)
                    {
                        nodo_nieto.Checked = false;
                    }
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            #region Validaciones
            int nodesCount = 0;
            foreach (TreeNode nodo_raiz in trvPermisos.Nodes)
            {
                if (nodo_raiz.Checked)
                {
                    nodesCount += 1;
                    break;
                }
            }
            if (nodesCount == 0)
            {
                MetroMessageBox.Show(this, "Debe seleccionar un Permisodel Arbol.", "Error!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MetroMessageBox.Show(this, "Complete los campos obligatorios", "ERROR!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error,
                    100);
                return;
            }
            #endregion

            Rol rol;

            if (ACCION == "A")
            {
                rol = new Rol();
                rol.nombre = txtNombre.Text;
                rol.permisos = new List<Permiso>();
            }
            else
            {
                rol = cRoles.obtenerRolPorId(int.Parse(txtIDRol.Text));
                rol.permisos.Clear();
            }

            foreach (TreeNode nodo_raiz in trvPermisos.Nodes)
            {
                if (nodo_raiz.Checked)
                {
                    PermisoCompuesto pc = (PermisoCompuesto)cRoles.obtenerPermisoPorNombre(nodo_raiz.Text.ToString());
                    rol.permisos.Add(pc);

                    foreach (TreeNode nodo_hijo in nodo_raiz.Nodes)
                    {
                        if (nodo_hijo.Checked)
                        {
                            if (nodo_hijo.Nodes.Count == 0)
                            {
                                Permiso ps = cRoles.obtenerPermisoPorNombre(nodo_hijo.Text.ToString());
                                pc.agregarNodo(ps);
                                rol.permisos.Add(ps);
                            }
                            else
                            {
                                PermisoCompuesto pc2 = (PermisoCompuesto)cRoles.obtenerPermisoPorNombre(nodo_hijo.Text.ToString());

                                foreach (TreeNode nodo_nieto in nodo_hijo.Nodes)
                                {
                                    if (nodo_nieto.Checked)
                                    {
                                        Permiso ps = cRoles.obtenerPermisoPorNombre(nodo_hijo.Text.ToString());
                                        pc.agregarNodo(ps);
                                        rol.permisos.Add(ps);
                                    }
                                }
                                pc.agregarNodo(pc2);
                                rol.permisos.Add(pc2);
                            }
                        }
                    }
                }
            }

            cRoles.guardarRol(rol);

            limpiarTrvPermisos();
            panelFrm.Visible = false;
            cargarLista();
        }
    }
}
