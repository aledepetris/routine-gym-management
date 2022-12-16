using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Bussines.TemplateReport
{

    public class RutinaSemanalCsv : RutinaSemanalAbs
    {
        StringBuilder csv_file;
        private List<object[]> allLines;

        protected override void inicializarDocumento()
        {
            csv_file = new StringBuilder();
        }

        protected override void ajustarTextos() { }


        protected override void generarDocumento(Semana sem)
        {
            int cDia = 1;
            foreach(Dia dia in sem.dias)
            { 
                int count = 1;
                allLines = (from ej in dia.ejercicios
                            select new object[]
                            {
                                count++,
                                ej.ejercicio.nombre,
                                ej.series,
                                ej.repeticiones,
                                ej.peso,
                                ej.descanso

                            }).ToList();

                csv_file.AppendLine("DIA " + cDia);
                csv_file.AppendLine("#,Ejercicios,Series,Repeticiones,Peso,Descanso");
                allLines.ForEach(line =>
                {
                    csv_file.AppendLine(string.Join(",", line));
                });
                csv_file.AppendLine();
                cDia++;
            }
        }

        protected override string guardarAndObtenerRuta()
        {
            string p_strPath = Directory.GetCurrentDirectory() + "\\rutina.csv";

            if (File.Exists(p_strPath))
                File.Delete(p_strPath);

            File.WriteAllText(p_strPath, csv_file.ToString());

            return p_strPath;
        }
    }
}
