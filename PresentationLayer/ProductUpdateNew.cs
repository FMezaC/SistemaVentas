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
    public partial class ProductUpdateNew : Form
    {
        public ProductUpdateNew()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductUpdateNew_Load(object sender, EventArgs e)
        {
            dtpProd.Format = DateTimePickerFormat.Short;
            dtpVen.Format = DateTimePickerFormat.Short;
        }

        StateModel model;
        LineModel Myline;
        ClassModel MyClass;
        OriginModel Origim;
        MesuareModel Mesure;
        public void Combobox()
        {
            // Estado 
            model = new StateModel();
            cboEstado.DataSource = model.ProductStatus("");
            cboEstado.ValueMember = "_CODEST";
            cboEstado.DisplayMember = "_ESTADO";
            
            //Procedencia
            Origim = new OriginModel();
            cboProcedencia.DataSource = Origim.OriginList("");
            cboProcedencia.ValueMember = "_CODPROCE";
            cboProcedencia.DisplayMember = "_DESCPROCE";

            // unidad Medida
            Mesure = new MesuareModel();
            cboUnidMed.DataSource = Mesure.ListMesuare("");
            cboUnidMed.ValueMember = "_UMSTOCK";
            cboUnidMed.DisplayMember = "_UMSTOCK";
        }

        public void ListLine()
        {
            // Linea
            Myline = new LineModel();
            cboLinea.DataSource = Myline.MyList("");
            cboLinea.ValueMember = "_CODLINE";
            cboLinea.DisplayMember = "_LINEA";
        }
        
        public void ListClass()
        {
            // Clases
            MyClass = new ClassModel();
            cboClassProduct.DataSource = MyClass.FIlterClass(Convert.ToInt32(cboLinea.SelectedValue));
            cboClassProduct.ValueMember = "_CODCLASS";
            cboClassProduct.DisplayMember = "_CLASS";
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?", "¡ADD ITEM!", MessageBoxButtons.YesNo);
            if (result== DialogResult.Yes && btnNew.Text != "Grabar")
            {
                ProductEntity entity = new ProductEntity();
                entity._CODPROD = Convert.ToDouble(txtID.Text);
                entity._DESCPRO = txtdesc.Text;
                entity._CANTPRO = Convert.ToInt32(txtcan.Text);
                entity._UMSTOCK = cboUnidMed.SelectedValue.ToString();
                entity._VOLPROD = Convert.ToDouble(txtVol.Text);
                entity._CODEST = cboEstado.SelectedValue.ToString();
                entity._CANTRES = Convert.ToDouble(txtCanRes.Text);
                entity._FECHVEN = dtpVen.Value;
                entity._FECHPROD = dtpProd.Value;
                entity._FACTOR = txtFact.Text;
                entity._CODLINE = cboLinea.SelectedValue.ToString();
                entity._PROCEDENCIA = cboProcedencia.SelectedValue.ToString();
                entity._CODBARR = txtCodBarr.Text;
                entity._CODCLASS = cboClassProduct.SelectedValue.ToString();
                entity._PREUNIT = Convert.ToDecimal(txtPreUnit.Text);
                entity._IMPUEST = Convert.ToDecimal(txtImpuest.Text);
                ProductModel model = new ProductModel();
                model.InsertProduct(entity);
            }
            else if (result == DialogResult.Yes && btnNew.Text == "Grabar")
            {
                ProductEntity entity = new ProductEntity();
                entity._CODPROD = Convert.ToDouble(txtID.Text);
                entity._DESCPRO = txtdesc.Text;
                entity._CANTPRO = Convert.ToInt32(txtcan.Text);
                entity._UMSTOCK = cboUnidMed.SelectedValue.ToString();
                entity._VOLPROD = Convert.ToDouble(txtVol.Text);
                entity._CODEST = cboEstado.SelectedValue.ToString();
                entity._CANTRES = Convert.ToDouble(txtCanRes.Text);
                entity._FECHVEN = dtpVen.Value;
                entity._FECHPROD = dtpProd.Value;
                entity._FACTOR = txtFact.Text;
                entity._CODLINE = cboLinea.SelectedValue.ToString();
                entity._PROCEDENCIA = cboProcedencia.SelectedValue.ToString();
                entity._CODBARR = txtCodBarr.Text;
                entity._CODCLASS = cboClassProduct.SelectedValue.ToString();
                entity._PREUNIT = Convert.ToDecimal(txtPreUnit.Text);
                entity._IMPUEST = Convert.ToDecimal(txtImpuest.Text);
                ProductModel model = new ProductModel();
                model.UpdateProduct(entity);
            }
            this.Close();
        }
        
        private void cboLinea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListClass();
        }
    }
}
