using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using SIGSE.Entities;

namespace SIGSE.FormsUI.Excel
{
    public class RutinaSemanal
    {
        public static string create(Semana sem)
        {
            // Creating an instance
            // of ExcelPackage
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();

            int count = 1;
            foreach (Dia dia in sem.dias)
            {
                var workSheet = excel.Workbook.Worksheets.Add("Dia" + count.ToString());
                workSheet.TabColor = System.Drawing.Color.Black;
                workSheet.DefaultRowHeight = 12;
                workSheet.Row(1).Height = 20;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;

                // Headers
                workSheet.Cells[1, 1].Value = "#";
                workSheet.Cells[1, 2].Value = "Ejercicio";
                workSheet.Cells[1, 3].Value = "Series";
                workSheet.Cells[1, 4].Value = "Repeticiones";
                workSheet.Cells[1, 5].Value = "Peso";
                workSheet.Cells[1, 6].Value = "Descanso";

                int recordIndex = 2;

                foreach (var ej in dia.ejercicios)
                {
                    workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1);
                    workSheet.Cells[recordIndex, 2].Value = ej.ejercicio.nombre;
                    workSheet.Cells[recordIndex, 3].Value = ej.series;
                    workSheet.Cells[recordIndex, 4].Value = ej.repeticiones;
                    workSheet.Cells[recordIndex, 5].Value = ej.peso;
                    workSheet.Cells[recordIndex, 6].Value = ej.descanso;
                    recordIndex++;
                }

                workSheet.Column(1).AutoFit();
                workSheet.Column(2).AutoFit();
                workSheet.Column(3).AutoFit();
                workSheet.Column(4).AutoFit();
                workSheet.Column(5).AutoFit();
                workSheet.Column(6).AutoFit();

                count++;
            }

            string p_strPath = Directory.GetCurrentDirectory() + "\\rutina.xlsx";

            if (File.Exists(p_strPath))
                File.Delete(p_strPath);

            FileStream objFileStrm = File.Create(p_strPath);
            objFileStrm.Close();

            File.WriteAllBytes(p_strPath, excel.GetAsByteArray());
            excel.Dispose();

            return p_strPath;
        }

    }
}
