﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class CicloManager
    {
        public static List<Entities.Ciclo> obtenerCiclos(Context.SigseContext sigseContext)
        {
            return sigseContext.ciclos.ToList();
        }

        public static Entities.Ciclo obtenerCicloPorId(Context.SigseContext sigseContext, int id)
        {
            return sigseContext.ciclos.Where(x => x.idCiclo == id)
                .Include(x => x.semanas
                .Select(b => b.dias
                .Select(d => d.ejercicios
                .Select(e => e.ejercicio))))
                .FirstOrDefault();
        }
    

        public static void agregarCiclos(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            sigseContext.ciclos.Add(ciclo);
            sigseContext.SaveChanges();
        }

        public static bool eliminarCiclo(Context.SigseContext sigseContext, Entities.Ciclo ciclo)
        {
            
            foreach (var semana in ciclo.semanas)
            {
                List<Entities.Dia> dias = semana.dias.ToList();
                foreach (var dia in dias)
                {
                    dia.ejercicios.ToList().ForEach(e => sigseContext.ejercicios_instesidad.Remove(e));
                }
                dias.ForEach(p => sigseContext.dias.Remove(p));

            }

            sigseContext.semanas.RemoveRange(ciclo.semanas);
            sigseContext.ciclos.Remove(ciclo);
            sigseContext.SaveChanges();

            return true;

        }


        public static void modificarCiclo(Context.SigseContext sigseContext, Entities.Alumno alumno, Entities.Ciclo oCiclo, DateTime inicio, Entities.Objetivo oObjetivo, int cantSemanas, Entities.TipoEntrenamiento oTipoEntrenamiento, int cantDias)
        {
            oCiclo.tipo_entrenamiento = oTipoEntrenamiento;
            oCiclo.objetivo = oObjetivo;

            if (oCiclo.cant_dias != cantDias || oCiclo.semanas.Count != cantSemanas)
            {
                oCiclo.fecha_inicio = inicio;
                oCiclo.cant_dias = cantDias;

                foreach (var semana in oCiclo.semanas)
                {
                    List<Entities.Dia> ddias = semana.dias.ToList();
                    foreach (var dia in ddias)
                    {
                        dia.ejercicios.ToList().ForEach(e => sigseContext.ejercicios_instesidad.Remove(e));
                    }
                    ddias.ForEach(p => sigseContext.dias.Remove(p));
                }

                oCiclo.semanas.ToList().ForEach(s => sigseContext.semanas.Remove(s));

                for (int i = 0; i < cantSemanas; i++)
                {
                    var semana = new Entities.Semana(cantDias);
                    oCiclo.semanas.Add(semana);
                }
            }

            sigseContext.Entry(oCiclo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();

        }
    }

}
