using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SalesCancellationsUpdateDesign : Form
    {
        public SalesCancellationsUpdateDesign()
        {
            InitializeComponent();
        }

        public void CancellationsDesing()
        {
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.title = "Anulando Venta";
            desing.StartPosition = FormStartPosition.CenterScreen;
            desing.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAnular")
            {
                dataGridView1.CurrentRow.Cells["btnAnular"].ToolTipText = "Anular";
            }
        }
    }
}
