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
    public partial class MesuareDesign : Form
    {
        public MesuareDesign()
        {
            InitializeComponent();
        }

        private void MesuareDesign_Load(object sender, EventArgs e)
        {
            ListMesuare("");
        }

        private void ListMesuare(string condition)
        {
            MesuareModel model = new MesuareModel();
            dtagrid.DataSource = model.ListMesuare(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListMesuare(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            btnGrabar.Text = "Registrar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox())
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?","¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    MesuareEntity entity = new MesuareEntity();
                    entity._IDUMS = textBox1.Text;
                    entity._UMSTOCK = textBox2.Text;
                    MesuareModel model = new MesuareModel();
                    model.InsertMesuare(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    MesuareEntity entity = new MesuareEntity();
                    entity._IDUMS = textBox1.Text;
                    entity._UMSTOCK = textBox2.Text;
                    MesuareModel model = new MesuareModel();
                    model.UpdateMesuare(entity);
                }
                ListMesuare("");
                panel1.Visible = false;
            }
        }

        private bool ValidateTextBox()
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Igrese un ID de medida.");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                if (textBox2.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox2, "Ingrese Unidad de medida");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }

        private void dtagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtagrid.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtagrid.CurrentRow.Cells["Codio"].Value.ToString();
                textBox2.Text = dtagrid.CurrentRow.Cells["Nomb"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtagrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Esta Seguro que desea eliminar?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MesuareEntity entity = new MesuareEntity();
                    entity._IDUMS = dtagrid.CurrentRow.Cells["Codio"].Value.ToString();
                    MesuareModel model = new MesuareModel();
                    model.DeleteMesuare(entity);
                }
                ListMesuare("");
                panel1.Visible = false;
            }
        }
    }
}
