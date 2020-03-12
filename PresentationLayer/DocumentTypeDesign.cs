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
    public partial class DocumentTypeDesign : Form
    {
        public DocumentTypeDesign()
        {
            InitializeComponent();
        }

        private void DocumentTypeDesign_Load(object sender, EventArgs e)
        {
            ListDocuemt("");
        }

        private void ListDocuemt(string condition)
        {
            DocumentTypeModel model = new DocumentTypeModel();
            dtagridClass.DataSource = model.ListDocuemt(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DocumentTypeModel model = new DocumentTypeModel();
            dtagridClass.DataSource = model.ListDocuemt(txtBuscar.Text);
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

        private void dtagridClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtagridClass.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                textBox1.Text = dtagridClass.CurrentRow.Cells["Nomb"].Value.ToString();
                textBox2.Text = dtagridClass.CurrentRow.Cells["_DOCUM"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (dtagridClass.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult reslt = MessageBox.Show("¿Está Seguro que desea Eliminar?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (reslt == DialogResult.Yes)
                {
                    DocumentTypeEntity entity = new DocumentTypeEntity();
                    entity._ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["Codio"].Value);
                    DocumentTypeModel model = new DocumentTypeModel();
                    model.DeleteDocument(entity);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox())
            {
                DialogResult result = MessageBox.Show("¿Está seguro quedesea agregar datos?", "¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (result== DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    DocumentTypeEntity entity = new DocumentTypeEntity();
                    entity._IDDOC = textBox1.Text;
                    entity._DOCUM = textBox2.Text;
                    DocumentTypeModel model = new DocumentTypeModel();
                    model.InsertDocument(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    DocumentTypeEntity entity = new DocumentTypeEntity();
                    entity._ID = Convert.ToInt32(dtagridClass.CurrentRow.Cells["Codio"].Value);
                    entity._IDDOC = textBox1.Text;
                    entity._DOCUM = textBox2.Text;
                    DocumentTypeModel model = new DocumentTypeModel();
                    model.UpdateDocument(entity);
                }
                panel1.Visible = false;
                ListDocuemt("");
            }
        }

        private bool ValidateTextBox()
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese ID de Docuemnto");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                if (textBox2.Text ==string.Empty)
                {
                    errorProvider1.SetError(textBox2, "Ingrese Nombre Documento");
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
