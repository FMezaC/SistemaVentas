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
    public partial class ProductStock : Form
    {
        public ProductStock()
        {
            InitializeComponent();
        }

        private void ProductStock_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarDatos(double condition)
        {
            ProductModel model = new ProductModel();
            List<ProductEntity> MyList = new List<ProductEntity>();
            MyList = model.FilterProdct(condition);
            int contador = MyList.Count;
            if (contador !=0)
            {
                for (int i = 0; i < contador; i++)
                {
                    txtdesc.Text = MyList[i]._DESCPRO;
                    txtestado.Text = MyList[i]._CODEST;
                    txtUniMed.Text = MyList[i]._UMSTOCK;
                    txtPreUnit.Text = Convert.ToString(MyList[i]._PREUNIT);
                    txtCodBarr.Text = MyList[i]._CODBARR;
                    txtFact.Text = MyList[i]._FACTOR;
                    txtCanRes.Text = Convert.ToString(MyList[i]._CANTRES);
                    txtcan.Text = Convert.ToString(MyList[i]._CANTPRO);
                }
            }
            else
            {
                MessageBox.Show("Producto No encontrado");
                LimpiTextBox();
            }
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != string.Empty)
                {
                    FiltrarDatos(Convert.ToDouble(txtID.Text));
                }
                else
                {
                    LimpiTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtID.Clear();
            }
        }

        private void LimpiTextBox()
        {
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ErrorController())
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea actualizar?", "¡UPDATE STOCK!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ProductEntity entity = new ProductEntity();
                    entity._CODPROD = Convert.ToDouble(txtID.Text);
                    entity._CANTPRO = Convert.ToInt32(txtcan.Text);
                    ProductModel model = new ProductModel();
                    model.UpdateStock(entity);
                    txtID.Clear();
                    txtID.Focus();
                }
            }
            
        }

        private bool ErrorController()
        {
            if (txtID.Text == string.Empty)
            {
                errorProvider1.SetError(txtID, "Ingrese ID Producto");
            }
            else
            {
                errorProvider1.SetError(txtID, null);
                if (txtcan.Text == string.Empty)
                {
                    errorProvider1.SetError(txtcan,"Ingrese Stock");
                }
                else
                {
                    errorProvider1.SetError(txtcan, null);
                    return true;
                }
            }
            return false;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
