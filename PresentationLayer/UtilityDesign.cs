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
    public partial class UtilityDesign : Form
    {
        public UtilityDesign()
        {
            InitializeComponent();
        }

        private void UtilityDesign_Load(object sender, EventArgs e)
        {
            ListUtility("");
        }

        private void ListUtility(string condition)
        {
            UtilityModel model = new UtilityModel();
            dataGridReportes.DataSource = model.ListUtility(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            UtilityModel model = new UtilityModel();
            dataGridReportes.DataSource = model.ListUtility(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
