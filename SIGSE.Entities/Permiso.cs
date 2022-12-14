using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public abstract class Permiso
    {
        public int idPermiso { get; set; }
        public string nombre { get; set; }

        public abstract void crearListaPermiso();
        public abstract void agregarNodo(Permiso perm);
        public abstract IList<Permiso> obtenerNodos();

    }

    public class PermisoSimple : Permiso
    {
        public PermisoSimple()
        {

        }

        public PermisoSimple(string nombre)
        {
            this.nombre = nombre;
        }

        public override void agregarNodo(Permiso perm) {}

        public override void crearListaPermiso() {}

        public override IList<Permiso> obtenerNodos()
        {
            return null;
        }
    }

    public class PermisoCompuesto : Permiso
    {
        public List<Permiso> permisos { get; set; }

        public PermisoCompuesto()
        {

        }

        public PermisoCompuesto(string nombre)
        {
            this.nombre = nombre;
            crearListaPermiso();
        }

        public PermisoCompuesto(string nombre, List<Permiso> permisos)
        {
            this.nombre = nombre;
            this.permisos = permisos;
        }

        public override void crearListaPermiso()
        {
            permisos = new List<Permiso>();
        }

        public override void agregarNodo(Permiso perm)
        {
            permisos.Add(perm);

        }

        public override IList<Permiso> obtenerNodos()
        {
            return permisos.ToArray();
        }
    }

}
