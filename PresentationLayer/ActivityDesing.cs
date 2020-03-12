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
    public partial class ActivityDesing : Form
    {
        public ActivityDesing()
        {
            InitializeComponent();
        }

        private void ActivityDesing_Load(object sender, EventArgs e)
        {
            ListActivity("");
        }

        private void ListActivity(string condition)
        {
            ActivityModel model = new ActivityModel();
            dtgLista.DataSource = model.ListActivity(condition);
        }

        private void ListArea()
        {
            AreaModel model = new AreaModel();
            comboBox1.DataSource = model.ListArea("");
            comboBox1.ValueMember = "_ID";
            comboBox1.DisplayMember = "_RUBRO";
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListActivity(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            btnGrabar.Text = "Registrar";
            ListArea();
            panel1.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void dtgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgLista.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                ListArea();
                textBox2.Text = dtgLista.CurrentRow.Cells["Nomb"].Value.ToString();
                comboBox1.Text = dtgLista.CurrentRow.Cells["_RUBRO"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtgLista.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar?", "¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ActivityEntity entity = new ActivityEntity();
                    entity._ID = Convert.ToInt32(dtgLista.CurrentRow.Cells["Codio"].Value);
                    ActivityModel model = new ActivityModel();
                    model.DeleteActivity(entity);
                }
                ListActivity("");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Ingrese Una Actidada Empresarial Válida");
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
                DialogResult result = MessageBox.Show("¿Está seguro de agregar datos?", "¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    ActivityEntity entity = new ActivityEntity();
                    entity._ACTEMP = textBox2.Text;
                    entity._IDRUB = Convert.ToInt32(comboBox1.SelectedValue);
                    ActivityModel model = new ActivityModel();
                    model.InsertActivity(entity);
                }
                else if(result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    ActivityEntity entity = new ActivityEntity();
                    entity._ID = Convert.ToInt32(dtgLista.CurrentRow.Cells["Codio"].Value);
                    entity._ACTEMP = textBox2.Text;
                    entity._IDRUB = Convert.ToInt32(comboBox1.SelectedValue);
                    ActivityModel model = new ActivityModel();
                    model.Update(entity);
                }
                panel1.Visible = false;
            }
            ListActivity("");
        }
    }
}
