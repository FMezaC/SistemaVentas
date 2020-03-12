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
    public partial class PaisDesign : Form
    {
        public PaisDesign()
        {
            InitializeComponent();
        }

        private void PaisDesign_Load(object sender, EventArgs e)
        {
            ListPais("");
        }
        private void ListPais(string condition)
        {
            PaisModel model = new PaisModel();
            dtagridClass.DataSource = model.ListPais(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListPais(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem() == true)
            {
                DialogResult result = MessageBox.Show("¿Estas Seguro que desea Agregar?", "Registrar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    PaisEntity entity = new PaisEntity();
                    entity.CODPAI = textBox1.Text;
                    entity.NOMPAI = textBox2.Text;
                    PaisModel model = new PaisModel();
                    model.RegisterPais(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    PaisEntity entity = new PaisEntity();
                    entity.CODPAI = textBox1.Text;
                    entity.NOMPAI = textBox2.Text;
                    entity.ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["IDP"].Value);
                    PaisModel model = new PaisModel();
                    model.UpdatePais(entity);
                }
                ListPais("");
                ClearItems();
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
                    errorProvider1.SetError(textBox2, "Ingrese Nombre Pais");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }

        private void dtagridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtagridClass.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtagridClass.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                textBox2.Text = dtagridClass.Rows[e.RowIndex].Cells["NombClass"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (this.dtagridClass.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                PaisEntity entity = new PaisEntity();
                entity.ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["IDP"].Value);
                PaisModel model = new PaisModel();
                model.DeletePais(entity);
                ListPais("");
                panel1.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnGrabar.Text = "Registrar";
            ClearItems();
        }
        private void ClearItems()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
