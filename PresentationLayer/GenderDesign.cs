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
    public partial class GenderDesign : Form
    {
        public GenderDesign()
        {
            InitializeComponent();
        }

        private void GenderDesign_Load(object sender, EventArgs e)
        {
            ListGender("");
        }

        private void ListGender(string condition)
        {
            GenderModel model = new GenderModel();
            dtagrid.DataSource = model.ListGender(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListGender(txtBuscar.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnGrabar.Text = "Registrar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ClearTextBox();
        }

        private void dtagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtagrid.Columns[e.ColumnIndex].Name =="btnEditar")
            {
                textBox1.Text = dtagrid.CurrentRow.Cells["Codio"].Value.ToString();
                textBox2.Text = dtagrid.CurrentRow.Cells["Nomb"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtagrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Estas Seguro que desea Eliminar Datos?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GenderEntity Entity = new GenderEntity();
                    Entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    GenderModel model = new GenderModel();
                    model.DeleteGender(Entity);
                    ListGender("");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem() == true)
            {
                DialogResult result = MessageBox.Show("¿Estas seguro que desea agregar datos?", "REGISTER NEW ITEM", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    GenderEntity Entity = new GenderEntity();
                    Entity._CODGEN = textBox1.Text;
                    Entity._GENERO = textBox2.Text;
                    GenderModel model = new GenderModel();
                    model.InsertGender(Entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    GenderEntity Entity = new GenderEntity();
                    Entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    Entity._CODGEN = textBox1.Text;
                    Entity._GENERO = textBox2.Text;
                    GenderModel model = new GenderModel();
                    model.UpdateGender(Entity);
                }
                ClearTextBox();
                ListGender("");
                panel1.Visible = false;
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
                    errorProvider1.SetError(textBox2, "Ingrese Nombre Género");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }

        private void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
