using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport.EntityLayer;
using Domain_Layer;
using FuntionalLayer;

namespace PresentationLayer
{
    public partial class EmployeePaymentsDesign : Form
    {
        public EmployeePaymentsDesign()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListEmployePay(DateTime StarDT, DateTime EndDT)
        {
            EmployeePaymentsModel model = new EmployeePaymentsModel();
            dataGridReportes.DataSource = model.ListPayments(StarDT, EndDT);
        }

        private void EmployeePaymentsDesign_Load(object sender, EventArgs e)
        {
            ListEmployePay(dTPInicio.Value, dTPFin.Value);
            statusStrip1.Cursor = Cursors.Hand;
        }

        private void dTPInicio_ValueChanged(object sender, EventArgs e)
        {
            ListEmployePay(dTPInicio.Value, dTPFin.Value);
        }

        private void dTPFin_ValueChanged(object sender, EventArgs e)
        {
            ListEmployePay(dTPInicio.Value, dTPFin.Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DownloandExcelFuntion function = new DownloandExcelFuntion();
            ConvertListToDataTable convert = new ConvertListToDataTable();
            EmployeePaymentsModel model = new EmployeePaymentsModel();
            DataTable table = convert.ToDataTable(model.ListPayments(dTPInicio.Value, dTPFin.Value));
            string appPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            function.BuildExcel(table, appPath + @"-PagoEmpleados.xlsx");
            //Lamar al backgroundWorker
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.StartPosition = FormStartPosition.CenterScreen;
            desing.showAlert("Descarga Exitosa...", FlaatSlanshDesign.enmType.Success);
        }
    }
}
