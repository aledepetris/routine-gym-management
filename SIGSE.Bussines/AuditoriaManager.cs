using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGSE;

namespace SIGSE.Bussines
{
    public class AuditoriaManager
    {
        public static void crearAuditoriaCiclo(Context.SigseContext sigseContext, Entities.Alumno alumno, Entities.Ciclo ciclo, string usuario, int idCicloo)
        {
            Entities.Auditoria.AuditoriaCiclos audiCiclo = new Entities.Auditoria.AuditoriaCiclos(idCicloo);
            audiCiclo.nombreAlumno = alumno.nombrecompleto;

            Entities.Auditoria.MovimientosCiclo movimientosCiclo = new Entities.Auditoria.MovimientosCiclo();

            movimientosCiclo.acción = "ALTA";

            movimientosCiclo.fecha_actividad = DateTime.Now;
            movimientosCiclo.usuario = usuario;

            movimientosCiclo.cant_dias = ciclo.cant_dias;
            movimientosCiclo.cant_semanas = ciclo.semanas.Count();
            movimientosCiclo.estado = ciclo.estado;
            movimientosCiclo.fecha_inicio = ciclo.fecha_inicio;
            movimientosCiclo.tipo_entrenamiento = ciclo.tipo_entrenamiento;
            movimientosCiclo.objetivo = ciclo.objetivo.nombre;

            audiCiclo.movimientosCiclo.Add(movimientosCiclo);

            sigseContext.auditoria_ciclos.Add(audiCiclo);
            sigseContext.SaveChanges();

        }

        public static void actualizarAuditoriaCiclo(Context.SigseContext sigseContext, Entities.Ciclo ciclo, string usuario)
        {
            Entities.Auditoria.AuditoriaCiclos audiCiclo = sigseContext.auditoria_ciclos
                .Where(x => x.idCiclo == ciclo.idCiclo)
                .Include(x => x.movimientosCiclo)
                .FirstOrDefault();


            Entities.Auditoria.MovimientosCiclo movimientosCiclo = new Entities.Auditoria.MovimientosCiclo();
            movimientosCiclo.acción = "MODIFICACIÓN";

            movimientosCiclo.fecha_actividad = DateTime.Now;
            movimientosCiclo.usuario = usuario;

            movimientosCiclo.cant_dias = ciclo.cant_dias;
            movimientosCiclo.cant_semanas = ciclo.semanas.Count();
            movimientosCiclo.estado = ciclo.estado;
            movimientosCiclo.fecha_inicio = ciclo.fecha_inicio;
            movimientosCiclo.tipo_entrenamiento = ciclo.tipo_entrenamiento;
            movimientosCiclo.objetivo = ciclo.objetivo.nombre;

            audiCiclo.movimientosCiclo.Add(movimientosCiclo);

            sigseContext.Entry(audiCiclo).State = System.Data.Entity.EntityState.Modified;
            sigseContext.SaveChanges();
        }



    }

}
