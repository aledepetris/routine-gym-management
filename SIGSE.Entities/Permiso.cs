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


        public abstract void crearListaPermisos();
        public abstract void agregarNodo(Permiso perm);
        public abstract IList<Permiso> obtenerNodos();
    }

    public class PermisoSimple : Permiso
    {
        public List<Permiso> permisos { get; set; }

        public override void crearListaPermisos()
        {
        }

        public override void agregarNodo(Permiso perm)
        {
        }

        public override IList<Permiso> obtenerNodos()
        {
            return null;
        }
    }

    public class PermisoCompuesto : Permiso
    {
        public List<Permiso> permisos { get; set; }

        public override void crearListaPermisos()
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
