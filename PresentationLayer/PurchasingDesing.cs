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

namespace PresentationLayer
{
    public partial class PurchasingDesing : Form
    {
        public PurchasingDesing()
        {
            InitializeComponent();
        }
        private void PurchasingDesing_Load(object sender, EventArgs e)
        {
            statusStrip1.Cursor = Cursors.Hand;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PurchasingUpdateNew desing = new PurchasingUpdateNew();
            desing.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
