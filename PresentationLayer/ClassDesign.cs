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
    public partial class ClassDesign : Form
    {
        public ClassDesign()
        {
            InitializeComponent();
        }

        private void ClassDesign_Load(object sender, EventArgs e)
        {
            ListClass("");
        }

        private void ListClass(string condition)
        {
            ClassModel model = new ClassModel();
            dtagridClass.DataSource = model.MyClassProduct(condition);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClassModel model = new ClassModel();
            dtagridClass.DataSource = model.MyClassProduct(txtBuscar.Text);
        }
        
        private void dtagridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtagridClass.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                ListLinea("");
                textBox1.Text = dtagridClass.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                textBox2.Text = dtagridClass.Rows[e.RowIndex].Cells["NombClass"].Value.ToString();
                comboBox1.Text = dtagridClass.Rows[e.RowIndex].Cells["Linea"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (this.dtagridClass.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que desea eliminar el registro?", "DELETE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClassEntity Delete = new ClassEntity();
                    Delete._CODCLASS = Convert.ToInt32(dtagridClass.Rows[e.RowIndex].Cells["Codio"].Value);
                    ClassModel model = new ClassModel();
                    model.DeleteClass(Delete);
                    ListClass(txtBuscar.Text);
                    txtBuscar.Focus();
                }
            }
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClassModel model = new ClassModel();
            textBox1.Text = Convert.ToString(model.NuevoCod());
            btnGrabar.Text = "Registrar";
            ListLinea("");
            panel1.Visible = true;
        }

        private void ListLinea(string condition)
        {
            LineModel model = new LineModel();
            comboBox1.DataSource = model.MyList(condition);
            comboBox1.ValueMember = "_CODLINE";
            comboBox1.DisplayMember = "_LINEA";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem())
            {
                DialogResult result = MessageBox.Show("¿Estas Seguro que desea Guardar los Datos?", "Registrar Clases",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    ClassEntity Entity = new ClassEntity();
                    Entity._CODCLASS = Convert.ToInt32(textBox1.Text);
                    Entity._CODLINE = Convert.ToDouble(comboBox1.SelectedValue);
                    Entity._CLASS = textBox2.Text;
                    ClassModel Model = new ClassModel();
                    Model.InsertClass(Entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    ClassEntity Entity = new ClassEntity();
                    Entity._CODCLASS = Convert.ToInt32(textBox1.Text);
                    Entity._CODLINE = Convert.ToDouble(comboBox1.SelectedValue);
                    Entity._CLASS = textBox2.Text;
                    ClassModel Model = new ClassModel();
                    Model.UpdateClass(Entity);
                }
                panel1.Visible = false;
                txtBuscar.Clear();
                txtBuscar.Focus();
                ListClass("");
            }
        }

        bool ValidatItem()
        {
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Ingrese Nombre Clase");
                return false;
            }
            errorProvider1.SetError(textBox2, null);
            return true;
        }

    }
}
