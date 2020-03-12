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
    public partial class UserTypeDesign : Form
    {
        public UserTypeDesign()
        {
            InitializeComponent();
        }

        private void UserTypeDesign_Load(object sender, EventArgs e)
        {
            ListTypeUser("");
        }

        private void ListTypeUser(string condition)
        {
            UserTypeModel model = new UserTypeModel();
            dtagridClass.DataSource = model.ListUsers(condition);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListTypeUser(txtBuscar.Text);
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

        private void dtagridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtagridClass.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtagridClass.CurrentRow.Cells["Nomb"].Value.ToString();
                textBox2.Text = dtagridClass.CurrentRow.Cells["User"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtagridClass.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserTypeEntity entity = new UserTypeEntity();
                    entity._ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["Codio"].Value);
                    UserTypeModel model = new UserTypeModel();
                    model.DeleteUserType(entity);
                    ListTypeUser("");
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox())
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?","¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    UserTypeEntity entity = new UserTypeEntity();
                    entity._CODTIP = textBox1.Text;
                    entity._TIPOUS = textBox2.Text;
                    UserTypeModel model = new UserTypeModel();
                    model.InsertUserType(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    UserTypeEntity entity = new UserTypeEntity();
                    entity._ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["Codio"].Value);
                    entity._CODTIP = textBox1.Text;
                    entity._TIPOUS = textBox2.Text;
                    UserTypeModel model = new UserTypeModel();
                    model.UpdateUserType(entity);
                }
                panel1.Visible = false;
                ListTypeUser("");
            }
        }

        private bool ValidateTextBox()
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese un ID de usuario");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                if (textBox2.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox2, "Ingrese Tipo Usuario");
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
