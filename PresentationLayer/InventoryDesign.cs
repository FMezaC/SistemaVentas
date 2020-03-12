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
    public partial class InventoryDesign : Form
    {
        public InventoryDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryDesign_Load(object sender, EventArgs e)
        {
            ListProducts("");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
