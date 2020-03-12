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

namespace PresentationLayer
{
    public partial class SalesCancellationsDesign : Form
    {
        public SalesCancellationsDesign()
        {
            InitializeComponent();
        }

        private void SalesCancellationsDesign_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            ListSales(dateTimePicker1.Value, dateTimePicker2.Value, "");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListSales(DateTime fech01, DateTime fech02, string cade)
        {
            SalesCancellationsModel model = new SalesCancellationsModel();
            dataGrid.DataSource = model.ListSales(fech01, fech02, cade);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListSales(dateTimePicker1.Value, dateTimePicker2.Value, txtBuscar.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ListSales(dateTimePicker1.Value, dateTimePicker2.Value, txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListSales(dateTimePicker1.Value, dateTimePicker2.Value, txtBuscar.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SalesCancellationsUpdateDesign design = new SalesCancellationsUpdateDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.ShowDialog();
            ListSales(dateTimePicker1.Value, dateTimePicker2.Value, "");
        }
    }
}
