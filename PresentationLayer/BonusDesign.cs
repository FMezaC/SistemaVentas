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
    public partial class BonusDesign : Form
    {
        public BonusDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BonusNewUpdateDesign design = new BonusNewUpdateDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.LoadStates();
            design.ShowDialog();
            LoadListBonusCustomer("");
            txtBuscar.Clear();
        }

        private void BonusDesign_Load(object sender, EventArgs e)
        {
            LoadListBonusCustomer("");
        }

        private void LoadListBonusCustomer(string condition)
        {
            BonusModel model = new BonusModel();
            dataGridReportes.DataSource = model.ListBonusCustomer(condition);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BonusNewUpdateDesign design = new BonusNewUpdateDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.btnNew.Text = "Grabar";
            design.LoadStates();
            design.textBox1.Text = dataGridReportes.CurrentRow.Cells["NUMDOC"].Value.ToString();
            design.textBox4.Text = dataGridReportes.CurrentRow.Cells["BENEFI"].Value.ToString();
            design.textBox2.Text = dataGridReportes.CurrentRow.Cells["TIPBON"].Value.ToString();
            design.comboBox1.Text = dataGridReportes.CurrentRow.Cells["ESTADO"].Value.ToString();
            design.dateTimePicker1.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FECHIICIO"].Value);
            design.dateTimePicker2.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FECHFINAL"].Value);
            design.textBox3.Text = dataGridReportes.CurrentRow.Cells["DESCUENTO"].Value.ToString();
            design.ID = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_IDBONF"].Value);
            design.ShowDialog();
            LoadListBonusCustomer("");
            txtBuscar.Clear();
        }
    }
}
