using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Ejercicio
    {
        #region Propiedades
        public int idEjercicio { get; set; }
        public bool tiempo { get; set; } // Si la cantidad de Repeticiones son por cantidad o segundos.
        public string nombre { get; set; }
        public List<Musculo> musculos { get; set; }
        public bool total { get; set; } // Si el ejercicio se hace en total o para cada extremidad
        public List<TipoEjercicio> tipos_ejercicios { get; set; }
        #endregion


        #region Meotodos
        public Ejercicio()
        {
            musculos = new List<Musculo>();
            tipos_ejercicios = new List<TipoEjercicio>();
        }

        public Ejercicio(string nombre, bool tiempo, List<Musculo> musculos, bool total, List<TipoEjercicio> tipos_ejercicios)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.musculos = musculos;
            this.total = total;
            this.tipos_ejercicios = tipos_ejercicios;

        }

        public TipoEjercicio obtenerTipoEjercicio(int codigo)
        {
            return tipos_ejercicios.Find(x => x.idTipoEjercicio == codigo);
        }

        public Musculo obtenerMusculo(int codigo)
        {
            return musculos.Find(x => x.idMusculo == codigo);
        }
        #endregion

    }
}
