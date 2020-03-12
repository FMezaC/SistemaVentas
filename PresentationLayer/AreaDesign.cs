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
    public partial class AreaDesign : Form
    {
        public AreaDesign()
        {
            InitializeComponent();
        }

        private void AreaDesign_Load(object sender, EventArgs e)
        {
            ListAre("");
        }
        private void ListAre(string condition)
        {
            AreaModel model = new AreaModel();
            dtgLista.DataSource = model.ListArea(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListAre(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnGrabar.Text = "Registrar";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void dtgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgLista.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtgLista.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                textBox2.Text = dtgLista.Rows[e.RowIndex].Cells["NombClass"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtgLista.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que desea eliminar el registro? ", "DELETE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AreaEntity entity = new AreaEntity();
                    entity._ID = Convert.ToInt32(dtgLista.CurrentRow.Cells["ID"].Value);
                    AreaModel model = new AreaModel();
                    model.DeleteArea(entity);
                    ListAre("");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem() ==true)
            {
                DialogResult result = MessageBox.Show("¿Estas seguro que desea agregar Datos?", "ADD ITEMS", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    AreaEntity entity = new AreaEntity();
                    entity._IDRB = textBox1.Text;
                    entity._RUBRO = textBox2.Text;
                    AreaModel model = new AreaModel();
                    model.InsertArea(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    AreaEntity entity = new AreaEntity();
                    entity._ID = Convert.ToInt32(dtgLista.CurrentRow.Cells["ID"].Value);
                    entity._IDRB = textBox1.Text;
                    entity._RUBRO = textBox2.Text;
                    AreaModel model = new AreaModel();
                    model.UpdatetArea(entity);
                }
                panel1.Visible = false;
                textBox1.Clear();
                textBox2.Clear();
                ListAre("");
            }
        }

        bool ValidatItem()
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ingrese un ID");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "Ingrese Nombre Rubro");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }
    }
}
