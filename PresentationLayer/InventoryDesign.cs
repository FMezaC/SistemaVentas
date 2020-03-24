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
    public partial class InventoryDesign : Form
    {
        public InventoryDesign()
        {
            InitializeComponent();
        }
        private void InventoryDesign_Load(object sender, EventArgs e)
        {
            ListProducts("");
            statusStrip1.Cursor = Cursors.Hand;
        }

        private void ListProducts(string filter)
        {
            ProductModel model = new ProductModel();
            dataGridReportes.DataSource = model.ListProducts(filter);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListProducts(txtBuscar.Text);
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DownloandExcelFuntion function = new DownloandExcelFuntion();
            ConvertListToDataTable convert = new ConvertListToDataTable();
            ProductModel model = new ProductModel();
            DataTable table = convert.ToDataTable(model.ListProducts(txtBuscar.Text));
            string appPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            function.BuildExcel(table, appPath + @"-Inventarios.xlsx");
            //Lamar al backgroundWorker
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.showAlert("Descarga Exitosa...", FlaatSlanshDesign.enmType.Success);
        }
    }
}
