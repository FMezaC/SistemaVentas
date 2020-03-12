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
    public partial class DistricDesign : Form
    {
        public DistricDesign()
        {
            InitializeComponent();
        }

        private void DistricDesign_Load(object sender, EventArgs e)
        {
            listDistritc("");
        }

        private void listDistritc(string contition)
        {
            DistricModel model = new DistricModel();
            dtagrid.DataSource = model.ListDistric(contition);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listDistritc(txtBuscar.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ListCombobox();
            btnGrabar.Text = "Registrar";
            ClearItems();
        }

        private void ListCombobox()
        {
            PaisModel model1 = new PaisModel();
            cboPais.DataSource = model1.ListPais("");
            cboPais.DisplayMember = "NOMPAI";
            cboPais.ValueMember = "ID";

            ComboboxProvincia();
            panel1.Visible = true;
        }

        private void ComboboxProvincia()
        {
            ProvinceModel model2 = new ProvinceModel();
            cboProvincia.DataSource = model2.FilterProvince(Convert.ToInt32(cboPais.SelectedValue));
            cboProvincia.DisplayMember = "_NOMPRO";
            cboProvincia.ValueMember = "_ID";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void cboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboboxProvincia();
        }

        private void dtagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtagrid.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                ListCombobox();
                textBox1.Text = dtagrid.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                textBox2.Text = dtagrid.Rows[e.RowIndex].Cells["NombClass"].Value.ToString();
                cboPais.Text = dtagrid.CurrentRow.Cells["PAIS"].Value.ToString();
                ComboboxProvincia();
                cboProvincia.Text = dtagrid.CurrentRow.Cells["_NOMPRO"].Value.ToString();                
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (this.dtagrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Esta Seguro que Desea Elimiar Datos?", "¡USER QUESTIONS!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DistricEntity entity = new DistricEntity();
                    entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    DistricModel model = new DistricModel();
                    model.DeleteDistric(entity);
                    listDistritc("");
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem() == true)
            {
                DialogResult result = MessageBox.Show("¿Esta Seguro que Desea Agregar Datos?", "¡USER QUESTIONS!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    DistricEntity entity = new DistricEntity();
                    entity._CODDIS = textBox1.Text;
                    entity._NOMDIS = textBox2.Text;
                    entity._CODPR = Convert.ToInt32(cboProvincia.SelectedValue);
                    DistricModel model = new DistricModel();
                    model.InsertDistric(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    DistricEntity entity = new DistricEntity();
                    entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    entity._CODDIS = textBox1.Text;
                    entity._NOMDIS = textBox2.Text;
                    entity._CODPR = Convert.ToInt32(cboProvincia.SelectedValue);
                    DistricModel model = new DistricModel();
                    model.UpdateDistric(entity);
                }
                panel1.Visible = false;
                ClearItems();
                listDistritc("");
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
                    errorProvider1.SetError(textBox2, "Ingrese Nombre Distrito");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }

        private void ClearItems()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        
    }
}
