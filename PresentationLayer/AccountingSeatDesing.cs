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
    public partial class AccountingSeatDesing : Form
    {
        public AccountingSeatDesing()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AccountSeatNewUpdate Design = new AccountSeatNewUpdate();
            Design.StartPosition = FormStartPosition.CenterScreen;
            Design.ListChartCounts("");
            Design.btnNew.Text = "Registrar";
            Design.ShowDialog();
            ListAccoun(dateTimePicker1.Value.AddDays(-1), dateTimePicker2.Value.AddDays(1));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountingSeatDesing_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            ListAccoun(dateTimePicker1.Value, DateTime.Now.AddDays(1));
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
