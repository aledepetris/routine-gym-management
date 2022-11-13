using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities
{
    public class Ciclo
    {
        #region Propiedades
        public int idCiclo { get; set; }
        public DateTime fecha_inicio { get; set; }
        public List<Semana> semanas { get; set; }
        public Objetivo objetivo { get; set; }
        public EstadoCiclo estado { get; set; }
        public TipoEntrenamiento tipo_entrenamiento { get; set; }
        public int cant_dias { get; set; }
        #endregion

        #region Metodos
        public Ciclo()
        {

        }

        public Ciclo(DateTime inicio, Objetivo obj, int cantSemanas, TipoEntrenamiento tipoEnt, int cantDias)
        {
            this.fecha_inicio = inicio;
            this.semanas = new List<Semana>();
            this.objetivo = obj;
            this.estado = EstadoCiclo.BORRADOR;

            this.tipo_entrenamiento = tipoEnt;
            this.cant_dias = cantDias;

            Semana semana;
            for (int i = 0; i < cantSemanas; i++)
            {
                semana = new Semana(cantDias);
                this.semanas.Add(semana);
            }
        }

        public DateTime calcularFechaFin()
        {
            DateTime fecha_fin;
            fecha_fin = fecha_inicio.AddDays(7 * semanas.Count);
            return fecha_fin;
        }

        public static List<int> filtrarDias(Objetivo obj)
        {
            return Enumerable.Range(obj.diasMinimo, obj.diasMaximo).ToList<int>(); ;
        }

        public int obtenerCantidadSemanas()
        {
            return semanas.Count();
        }
        #endregion

    }
}
