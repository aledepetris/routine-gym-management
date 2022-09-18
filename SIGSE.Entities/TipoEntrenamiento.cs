using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class TipoEntrenamiento
    {
        #region Propiedades
        public int idTipoEntrenamiento { get; set; }
        public string nombre { get; set; }
        public List<TipoEjercicio> tipos_ejercicios { get; set; }
        #endregion


        #region Metodos
        public TipoEntrenamiento()
        {
            this.tipos_ejercicios = new List<TipoEjercicio>();
        }

        public TipoEntrenamiento(string nombre, List<TipoEjercicio> tipos_ejercicios)
        {
            this.nombre = nombre;
            this.tipos_ejercicios = tipos_ejercicios;
        }

        public TipoEjercicio obtenerTipoEjercicio(int codigo)
        {
            return tipos_ejercicios.Find(x => x.idTipoEjercicio == codigo);
        }
        #endregion

    }
}
