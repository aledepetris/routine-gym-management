using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Objetivo
    {
        #region Propiedades
        public int idObjetivo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int diasMinimo { get; set; }
        public int diasMaximo { get; set; }
        #endregion

        #region Metodos
        public Objetivo()
        {

        }

        public Objetivo(string nombre, string descripcion, int diasMinimo, int diasMaximo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.diasMinimo = diasMinimo;
            this.diasMaximo = diasMaximo;
        }
        #endregion

    }
}
