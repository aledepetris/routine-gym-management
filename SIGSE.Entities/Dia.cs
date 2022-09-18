using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Dia
    {
        #region Propiedades

        public int idDia { get; set; }
        public List<EjercicioIntensidad> ejercicios { get; set; }

        #endregion


        #region Metodos
        public Dia()
        {
            ejercicios = new List<EjercicioIntensidad>();
        }

        public EjercicioIntensidad obtenerEjercicioIntensidad(int codigo)
        {
            return ejercicios.Find(x => x.idEjercicioIntensidad == codigo);
        }
        #endregion


    }
}
