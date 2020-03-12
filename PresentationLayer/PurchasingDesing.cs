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

namespace PresentationLayer
{
    public partial class PurchasingDesing : Form
    {
        public PurchasingDesing()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PurchasingUpdateNew desing = new PurchasingUpdateNew();
            desing.ShowDialog();
        }

        private void PurchasingDesing_Load(object sender, EventArgs e)
        {
            DateTime stardate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            DateTime enddate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            ListDataPurcharse(stardate, enddate);
        }

        private void ListDataPurcharse(DateTime StarDate, DateTime EndDate)
        {
            PurcharseModel model = new PurcharseModel();
            dataGridReportes.DataSource = model.ListPurcharse(StarDate, EndDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime stardate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            DateTime enddate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            ListDataPurcharse(stardate, enddate);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime stardate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            DateTime enddate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            ListDataPurcharse(stardate, enddate);
        }
    }
}
