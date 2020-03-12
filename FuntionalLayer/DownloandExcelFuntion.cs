using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport.EntityLayer;

namespace FuntionalLayer
{
    public class DownloandExcelFuntion
    {
        public void ExcelExport(DataGridView grid)
        {
        //    SaveFileDialog fichero = new SaveFileDialog();
        //    fichero.Filter = "Excel [*.xlsx]|*xlm";
        //    fichero.FileName = "Mi Archivo";
        //    if (fichero.ShowDialog() == DialogResult.OK)
        //    {
        //        Microsoft.Office.Interop.Excel.Application aplicaion;
        //        aplicaion = new Microsoft.Office.Interop.Excel.Application();
        //        Workbook libro;
        //        Worksheet hoja;
        //        libro = aplicaion.Workbooks.Add();
        //        hoja = aplicaion.Worksheets.Add();
        //        int IndiceColumn = 0;
        //        foreach (DataGridViewColumn nombre in grid.Columns)
        //        {
        //            IndiceColumn++;
        //            hoja.Cells[1, IndiceColumn] = nombre.Name;
        //        }
        //        for (int i = 1; i < grid.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < grid.Columns.Count - 1; j++)
        //            {
        //                if ((grid.Rows[i].Cells[j].Value == null) == false)
        //                    hoja.Cells[i + 1, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        //libro.SaveAs(fichero.FileName, XlFileFormat.xlWorkbookNormal);
        //        libro.Close(true);
        //        aplicaion.Quit();
        //    }
        }

    }
}
