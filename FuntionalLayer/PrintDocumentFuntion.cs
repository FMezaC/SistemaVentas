using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuntionalLayer
{
    public class PrintDocumentFuntion
    {
        public void PrintngDocuemts(DataGridView gridview)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.DocumentName = "My Name Doc 01";
            
            doc.PrintPage += delegate (object ev, PrintPageEventArgs arg)
            {
                const int DGV_top = 33;
                int left = arg.MarginBounds.Left, top = arg.MarginBounds.Top;
                foreach (DataGridViewColumn col in gridview.Columns)
                {
                    arg.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 11, FontStyle.Bold), 
                    Brushes.DeepSkyBlue, left, top);
                    left += col.Width;
                    if (col.Index < gridview.ColumnCount - 1)
                        arg.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (gridview.RowCount - 1) * DGV_top);
                }
                left = arg.MarginBounds.Left;
                arg.Graphics.FillRectangle(Brushes.Black, left, top+40, arg.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in gridview.Rows)
                {
                    if (row.Index == gridview.RowCount - 1) break;
                    left = arg.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        arg.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 9), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_top;
                    arg.Graphics.DrawLine(Pens.Gray, arg.MarginBounds.Left, top, arg.MarginBounds.Right, top);
                }
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            ppd.ShowDialog();
        }
    }
}
