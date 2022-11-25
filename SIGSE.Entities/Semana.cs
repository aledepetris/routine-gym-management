using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Semana
    {
        #region Propiedades
        public int idSemana { get; set; }
        public List<Dia> dias { get; set; }
        public EstadoSemana estado { get; set; }
        public int orden { get; set; }
        public DateTime fecha_inicio { get; set; }
        #endregion

        #region Metodos
        public Semana()
        {
            dias = new List<Dia>();
        }

        public Semana(int cantDias)
        {
            dias = new List<Dia>();
            estado = EstadoSemana.BORRADOR;
            Dia dia;
            for (int i = 0; i < cantDias; i++)
            {
                dia = new Dia();
                dias.Add(dia);
            }
        }

        public DateTime calcularFechaFin()
        {
            DateTime fecha_fin;
            fecha_fin = fecha_inicio.AddDays(7);
            return fecha_fin;
        }


        public Dia obtenerDia(int codDia)
        {
            return dias.Find(x => x.idDia == codDia);
        }
        #endregion

    }
}
