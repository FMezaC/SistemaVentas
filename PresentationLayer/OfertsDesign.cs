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
    public partial class OfertsDesign : Form
    {
        public OfertsDesign()
        {
            InitializeComponent();
        }

        private void OfertsDesign_Load(object sender, EventArgs e)
        {
            ListOferts("");
        }

        private void ListOferts(string conditions)
        {
            OfertsModel model = new OfertsModel();
            dataGridReportes.DataSource = model.ListOferts(conditions);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListOferts(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OfertsNewUpdateDesign design = new OfertsNewUpdateDesign();
            design.btnNew.Text = "Registrar";
            design.estado();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.ShowDialog();
            ListOferts("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OfertsNewUpdateDesign design = new OfertsNewUpdateDesign();
            design.btnNew.Text = "Grabar";
            design.estado();
            design.comboBox1.Text = dataGridReportes.CurrentRow.Cells["ESTADO"].Value.ToString();
            design.textBox2.Text = dataGridReportes.CurrentRow.Cells["TIPODESCT"].Value.ToString();
            design.dateTimePicker1.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FECHIICIO"].Value);
            design.dateTimePicker2.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FECHFINAL"].Value);
            design.textBox3.Text = dataGridReportes.CurrentRow.Cells["DESCUENTO"].Value.ToString();
            design.ID_OFT = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_ID"].Value);
            design.CargarGrilla();
            design.RemoveBD = "BD";
            design.StartPosition = FormStartPosition.CenterScreen;
            design.ShowDialog();
            ListOferts("");
        }
    }
}
