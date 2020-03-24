using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain_Layer;
using FuntionalLayer;

namespace PresentationLayer
{
    public partial class AccountingSeatDesing : Form
    {
        public AccountingSeatDesing()
        {
            InitializeComponent();
        }
        private void AccountingSeatDesing_Load(object sender, EventArgs e)
        {
            ListAccoun(dateTimePicker1.Value, DateTime.Now);
            statusStrip2.Cursor = Cursors.Hand;
        }

        private void ListAccoun(DateTime fech1, DateTime fech2)
        {
            AccountSeatModel model = new AccountSeatModel();
            dataGridReportes.DataSource = model.ListAccoun(fech1, fech2);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListAccoun(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ListAccoun(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DownloandExcelFuntion function = new DownloandExcelFuntion();
            ConvertListToDataTable convert = new ConvertListToDataTable();
            AccountSeatModel model = new AccountSeatModel();
            DataTable table = convert.ToDataTable(model.ListAccoun(dateTimePicker1.Value, dateTimePicker2.Value));
            string appPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            function.BuildExcel(table, appPath + @"-AsientosContables.xlsx");
            //Lamar al backgroundWorker
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.showAlert("Descarga Exitosa...", FlaatSlanshDesign.enmType.Success);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AccountSeatNewUpdate Design = new AccountSeatNewUpdate();
            Design.StartPosition = FormStartPosition.CenterScreen;
            Design.ListChartCounts("");
            Design.btnNew.Text = "Registrar";
            Design.ShowDialog();
            ListAccoun(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridReportes.SelectedRows.Count > 0)
            {
                AccountSeatNewUpdate design = new AccountSeatNewUpdate();
                design.ListDetall(Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_IDASI"].Value));
                design.ListChartCounts("");
                design.comboBox1.Text = dataGridReportes.CurrentRow.Cells["IDCUENT"].Value.ToString() + " - " + dataGridReportes.CurrentRow.Cells["CUENTA"].Value.ToString();
                design.textBox1.Text = dataGridReportes.CurrentRow.Cells["NUMASI"].Value.ToString();
                design.textBox2.Text = dataGridReportes.CurrentRow.Cells["NOTA"].Value.ToString();
                design.MyID = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_IDASI"].Value);
                design.dateTimePicker1.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FECHA"].Value.ToString());
                design.btnNew.Text = "Grabar";
                design.StartPosition = FormStartPosition.CenterScreen;
                design.ShowDialog();
                ListAccoun(dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }
    }
}
