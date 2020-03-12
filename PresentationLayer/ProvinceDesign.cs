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
    public partial class ProvinceDesign : Form
    {
        public ProvinceDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProvinceDesign_Load(object sender, EventArgs e)
        {
            ListProvincia("");
        }

        private void ListProvincia(string condition)
        {
            ProvinceModel model = new ProvinceModel();
            dtagrid.DataSource = model.ListProvince(condition);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CargarPais();
            panel1.Visible = true;
            btnGrabar.Text = "Registrar";
            ClearItems();
        }

        private void CargarPais()
        {
            PaisModel model = new PaisModel();
            cboPais.DataSource = model.ListPais("");
            cboPais.ValueMember = "ID";
            cboPais.DisplayMember = "NOMPAI";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidatItem() == true)
            {
                DialogResult result = MessageBox.Show("¿Estas Seguro que desea Agregar datos?", "REGISTRAR", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnGrabar.Text != "Grabar")
                {
                    ProvinceEntity entity = new ProvinceEntity();
                    entity._CODPRO = txtCod.Text;
                    entity._NOMPRO = txtNom.Text;
                    entity._IDPAIS = Convert.ToInt32(cboPais.SelectedValue);
                    ProvinceModel model = new ProvinceModel();
                    model.RegistrerProvince(entity);
                }
                else if (result == DialogResult.Yes && btnGrabar.Text == "Grabar")
                {
                    ProvinceEntity entity = new ProvinceEntity();
                    entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    entity._CODPRO = txtCod.Text;
                    entity._NOMPRO = txtNom.Text;
                    entity._IDPAIS = Convert.ToInt32(cboPais.SelectedValue);
                    ProvinceModel model = new ProvinceModel();
                    model.UpdateProvince(entity);
                }
                panel1.Visible = false;
                ClearItems();
                ListProvincia("");
            }
        }

        bool ValidatItem()
        {
            if (txtCod.Text == "")
            {
                errorProvider1.SetError(txtCod, "Ingrese un ID");
            }
            else
            {
                errorProvider1.SetError(txtCod, null);
                if (txtNom.Text == "")
                {
                    errorProvider1.SetError(txtNom, "Ingrese Nombre Provincia");
                }
                else
                {
                    errorProvider1.SetError(txtNom, null);
                    return true;
                }
            }
            return false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListProvincia(txtBuscar.Text);
        }

        private void dtagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtagrid.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                CargarPais();
                txtCod.Text = dtagrid.Rows[e.RowIndex].Cells["Codio"].Value.ToString();
                txtNom.Text = dtagrid.Rows[e.RowIndex].Cells["Provincia"].Value.ToString();
                cboPais.Text = dtagrid.Rows[e.RowIndex].Cells["Pais"].Value.ToString();
                btnGrabar.Text = "Grabar";
                panel1.Visible = true;
            }
            else if (this.dtagrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult reslt = MessageBox.Show("¿Está seguro que desea eliminar item?","¡DELETE ITEM!", MessageBoxButtons.YesNo);
                if (reslt == DialogResult.Yes)
                {
                    ProvinceEntity entity = new ProvinceEntity();
                    entity._ID = Convert.ToInt32(dtagrid.CurrentRow.Cells["ID"].Value);
                    ProvinceModel model = new ProvinceModel();
                    model.DeleteProvince(entity);
                }
                ListProvincia("");
                panel1.Visible = false;
            }
        }

        private void ClearItems()
        {
            txtCod.Clear();
            txtNom.Clear();
        }
    }
}
