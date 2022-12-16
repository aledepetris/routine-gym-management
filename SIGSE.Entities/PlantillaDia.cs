using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class PlantillaDia
    {
        #region Propiedades

        public int codigo { get; set; }
        public string nombre { get; set; }
        public List<EjercicioIntensidad> ejercicios { get; set; }

        #endregion

        public PlantillaDia()
        {

        }
    }
}
