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
using FuntionalLayer;

namespace PresentationLayer
{
    public partial class ProductDesign : Form
    {
        public ProductDesign()
        {
            InitializeComponent();
            panel1.Click += new EventHandler(ToggleFuntion);
            togglePanel.Click += new EventHandler(ToggleFuntion);
            panel2.Click += new EventHandler(ToggleFuntion);
            panel6.Click += new EventHandler(ToggleFuntion);
        }
        private void ProductDesign_Load(object sender, EventArgs e)
        {
            ListProducts("");
        }

        private void ListProducts(string condition)
        {
            ProductModel prodMod = new ProductModel();
            dataGridReportes.DataSource = prodMod.ListProducts(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListProducts(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ToggleFuntion(object sender, EventArgs e)
        {
            string IDP = dataGridReportes.CurrentRow.Cells["_CODPROD"].Value.ToString();
            string IDP2 = string.Copy(IDP);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductUpdateNew update = new ProductUpdateNew();
            update.StartPosition = FormStartPosition.CenterScreen;
            update.Combobox();
            update.txtID.Text = dataGridReportes.CurrentRow.Cells["_CODPROD"].Value.ToString();
            update.txtdesc.Text = dataGridReportes.CurrentRow.Cells["_DESCPRO"].Value.ToString();
            update.cboProcedencia.Text = dataGridReportes.CurrentRow.Cells["_PROCEDENCIA"].Value.ToString();
            update.cboUnidMed.Text = dataGridReportes.CurrentRow.Cells["_UMSTOCK"].Value.ToString();
            update.txtVol.Text = dataGridReportes.CurrentRow.Cells["_VOLPROD"].Value.ToString();
            update.cboEstado.Text = dataGridReportes.CurrentRow.Cells["_CODEST"].Value.ToString();
            update.txtCanRes.Text = dataGridReportes.CurrentRow.Cells["_CANTRES"].Value.ToString();
            update.dtpProd.Text = dataGridReportes.CurrentRow.Cells["_FECHPROD"].Value.ToString();
            update.dtpVen.Text = dataGridReportes.CurrentRow.Cells["_FECHVEN"].Value.ToString();
            update.txtFact.Text = dataGridReportes.CurrentRow.Cells["_FACTOR"].Value.ToString();
            update.ListLine();
            update.cboLinea.Text = dataGridReportes.CurrentRow.Cells["_CODLINE"].Value.ToString();
            update.ListClass();
            update.cboClassProduct.Text = dataGridReportes.CurrentRow.Cells["_CODCLASS"].Value.ToString();
            update.txtPreUnit.Text = dataGridReportes.CurrentRow.Cells["_PREUNIT"].Value.ToString();
            update.txtcan.Text = dataGridReportes.CurrentRow.Cells["_CANTPRO"].Value.ToString();
            update.txtCodBarr.Text = dataGridReportes.CurrentRow.Cells["_CODBARR"].Value.ToString();
            update.txtImpuest.Text = dataGridReportes.CurrentRow.Cells["IMPUEST"].Value.ToString();
            update.btnNew.Text = "Grabar";
            update.txtcan.Enabled = false;
            update.ShowDialog();
            ListProducts("");
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            ProductUpdateNew MyNew = new ProductUpdateNew();
            MyNew.StartPosition = FormStartPosition.CenterScreen;
            ProductModel model = new ProductModel();
            MaxID NewID = new MaxID();
            MyNew.txtID.Text = Convert.ToString(model.PreoductID(NewID));
            MyNew.Combobox();
            MyNew.ListLine();
            MyNew.ListClass();
            MyNew.btnNew.Text = "Registrar";
            MyNew.ShowDialog();
            ListProducts("");
        }

        private void dataGridReportes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridReportes.Columns[e.ColumnIndex].Name == "_UNIDADES")
            {
                if (Convert.ToInt32(e.Value) <= 5)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dataGridReportes.Font, FontStyle.Bold);
                }
            }
        }

        private void dataGridReportes_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridReportes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PrintDocumentFuntion documen = new PrintDocumentFuntion();
            documen.PrintngDocuemts(dataGridReportes);
        }
    }
}
