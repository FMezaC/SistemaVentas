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
    public partial class ChartCountDesign : Form
    {
        public ChartCountDesign()
        {
            InitializeComponent();
        }

        private void ChartCountDesign_Load(object sender, EventArgs e)
        {
            ListCounts("");
        }

        private void ListCounts(string condition)
        {
            ChartCountModel model = new ChartCountModel();
            dtagrid.DataSource = model.ListCount(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListCounts(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int COD;
        private void dtagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtagrid.Columns[e.ColumnIndex].Name =="btnEditar")
            {
                COD = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                textBox1.Text = dtagrid.CurrentRow.Cells["Numero"].Value.ToString();
                textBox2.Text = dtagrid.CurrentRow.Cells["Descrip"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtagrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?", "¡ADD ITEMS!", MessageBoxButtons.YesNo);
                if (true)
                {
                    ChartCountEntity entity = new ChartCountEntity();
                    entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    ChartCountModel model = new ChartCountModel();
                    model.DeleteCount(entity);
                    ListCounts("");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnGrabar.Text = "Registrar";
            textBox1.Clear();
            textBox2.Clear();
            panel1.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?", "¡ADD ITEMS!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
            {
                ChartCountEntity entity = new ChartCountEntity();
                entity._CTA = Convert.ToInt32(textBox1.Text);
                entity._DESCRIP = textBox2.Text;
                ChartCountModel model = new ChartCountModel();
                model.InsertCount(entity);
            }
            else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
            {
                ChartCountEntity entity = new ChartCountEntity();
                entity._ID = COD;
                entity._CTA = Convert.ToInt32(textBox1.Text);
                entity._DESCRIP = textBox2.Text;
                ChartCountModel model = new ChartCountModel();
                model.UpdateCount(entity);
            }
            panel1.Visible = false;
            ListCounts("");
        }
    }
}
