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
        }
        private void ProductDesign_Load(object sender, EventArgs e)
        {
            ListProducts("");
            statusStrip1.Cursor = Cursors.Hand;
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
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ProductUpdateNew MyNew = new ProductUpdateNew();
            MyNew.StartPosition = FormStartPosition.CenterScreen;
            ProductModel model = new ProductModel();
            MyNew.txtID.Text = Convert.ToString(model.PreoductID());
            MyNew.Combobox();
            MyNew.ListLine();
            MyNew.ListClass();
            MyNew.btnNew.Text = "Registrar";
            MyNew.ShowDialog();
            ListProducts("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DownloandExcelFuntion function = new DownloandExcelFuntion();
            ConvertListToDataTable convert = new ConvertListToDataTable();
            ProductModel model = new ProductModel();
            DataTable table = convert.ToDataTable(model.ListProducts(txtBuscar.Text));
            string appPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            function.BuildExcel(table, appPath + @"-Productos.xlsx");
            //Lamar al backgroundWorker
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.showAlert("Descarga Exitosa...", FlaatSlanshDesign.enmType.Success);
        }
    }
}
