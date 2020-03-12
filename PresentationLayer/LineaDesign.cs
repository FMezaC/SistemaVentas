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
using CommonSupport.EntityLayer;

namespace PresentationLayer
{
    public partial class LineaDesign : Form
    {
        public LineaDesign()
        {
            InitializeComponent();
        }

        private void LineaDesign_Load(object sender, EventArgs e)
        {
            ListLine("");
        }

        private void ListLine(string condition)
        {
            LineModel model = new LineModel();
            dtgLine.DataSource = model.MyList(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LineModel model = new LineModel();
            dtgLine.DataSource = model.MyList(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtgLine.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtgLine.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                textBox2.Text = dtgLine.Rows[e.RowIndex].Cells["NombLinea"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Show();
            }
            else if (this.dtgLine.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Estaseguro que desea eliminar?", "¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LineEntity entity = new LineEntity();
                    entity._CODLINE = Convert.ToDouble(textBox1.Text);
                    LineModel model = new LineModel();
                    model.DeleteLine(entity);
                    ListLine("");
                    txtBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            LineModel model = new LineModel();
            MaxID ID = new MaxID();
            textBox1.Text =Convert.ToString(model.NewID(ID));
            btnGrabar.Text = "Registrar";
            panel1.Visible = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem())
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea agregar datos?", "¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    LineEntity entity = new LineEntity();
                    entity._CODLINE = Convert.ToDouble(textBox1.Text);
                    entity._LINEA = textBox2.Text;
                    LineModel model = new LineModel();
                    model.InsertLine(entity);
                }
                else if (result ==DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    LineEntity entity = new LineEntity();
                    entity._CODLINE = Convert.ToDouble(textBox1.Text);
                    entity._LINEA = textBox2.Text;
                    LineModel model = new LineModel();
                    model.UpdateLine(entity);
                }
                panel1.Visible = false;
                textBox2.Clear();
                ListLine("");
            }
        }

        bool ValidatItem()
        {
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Igrese Nombre Linea");
                return false;
            }
            errorProvider1.SetError(textBox2, null);
            return true;
        }
    }
}
