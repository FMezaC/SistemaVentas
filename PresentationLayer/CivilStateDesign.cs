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
    public partial class CivilStateDesign : Form
    {
        public CivilStateDesign()
        {
            InitializeComponent();
        }

        private void CivilStateDesign_Load(object sender, EventArgs e)
        {
            ListCivil("");
        }

        private void ListCivil(string condition)
        {
            CivilStatusModel model = new CivilStatusModel();
            dtagrid.DataSource = model.ListCivil(condition);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListCivil(txtBuscar.Text);
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
                DialogResult Result = MessageBox.Show("¿Esta seguro que desea Eliminar?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    CivilStatusEntity delete = new CivilStatusEntity();
                    delete._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    CivilStatusModel model = new CivilStatusModel();
                    model.DeleteCivil(delete);
                }
                ListCivil("");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnGrabar.Text = "Registrar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        void ClearTextbox()
        {
            textBox1.Clear();
            textBox2.Clear();
            panel1.Visible = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem()==true)
            {
                DialogResult Result = MessageBox.Show("¿Esta seguro que desea Agregar Datos?", "¡ADD NEW ITEM!", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    CivilStatusEntity entity = new CivilStatusEntity();
                    entity._ESTCOD = textBox1.Text;
                    entity._ESTADO = textBox2.Text;
                    CivilStatusModel model = new CivilStatusModel();
                    model.InsertCivil(entity);
                }
                else if (Result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    CivilStatusEntity Update = new CivilStatusEntity();
                    Update._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    Update._ESTCOD = textBox1.Text;
                    Update._ESTADO = textBox2.Text;
                    CivilStatusModel model = new CivilStatusModel();
                    model.UpdateCivil(Update);
                }
                ClearTextbox();
                ListCivil("");
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
                    errorProvider1.SetError(textBox2, "Ingrese Estado Civil");
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
