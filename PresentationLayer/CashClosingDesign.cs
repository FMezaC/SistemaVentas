using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport.EntityLayer;
using Domain_Layer;
using CommonSupport;

namespace PresentationLayer
{
    public partial class CashClosingDesign : Form
    {
        public CashClosingDesign()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashClosingDesign_Load(object sender, EventArgs e)
        {
            ListData();
            ListMoney();
        }

        private void ListData()
        {
            CashModel model = new CashModel();
            CashOutputEntity Entity = new CashOutputEntity();
            model.CashDataModel(Entity);

            txtArqueo.Text = Convert.ToString(Entity._ARQUEO);
            txtFactura.Text = Convert.ToString(Entity._FACTURA);
            txtMontoIni.Text = Convert.ToString(Entity._MONTO);
            txtFechaApe.Text = Convert.ToString(Entity._FCHAPE);
            txtVentas.Text = Convert.ToString(Entity._VENTAS);
            txtUser.Text = UserLoginCache.user;
            txtFechCierre.Text = Convert.ToString(DateTime.Now);
        }

        private void ListMoney()
        {
            MoneyModel model = new MoneyModel();
            comboBox1.DataSource = model.ListMoney("");
            comboBox1.ValueMember = "_ID";
            comboBox1.DisplayMember = "_MONEY";
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            SavedCashData();
            UpdateSalesBilling();
            this.Close();
        }

        private void SavedCashData()
        {
            CashEntity Entity = new CashEntity();
            Entity._FCHCIE = Convert.ToDateTime(txtFechCierre.Text);
            Entity._TOTVEN = Convert.ToDouble(txtVentas.Text);
            Entity._TOTFAC = Convert.ToDouble(txtFactura.Text);
            Entity._TOTCIE = Convert.ToDouble(txtTotal.Text);
            Entity._FALTAN = Convert.ToDouble(txtFaltante.Text);
            Entity._SOBRAN = Convert.ToDouble(txtSobrante.Text);
            CashModel model = new CashModel();
            model.UpdateCashModel(Entity);
        }

        private void UpdateSalesBilling()
        {
            CashModel model = new CashModel();
            model.UpdateSalesModel();
            model.UpdateBillingModel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtBillete.Text != string.Empty && txtMoneda.Text != string.Empty)
            {
                double sumaTot = Convert.ToDouble(txtMontoIni.Text) + Convert.ToDouble(txtFactura.Text) +
                Convert.ToDouble(txtVentas.Text);
                txtTotal.Text = Convert.ToString(sumaTot);
                double ValorMoney = Convert.ToDouble(txtBillete.Text) + Convert.ToDouble(txtMoneda.Text) - Convert.ToDouble(txtTotal.Text);

                if (ValorMoney > 0)
                {
                    txtSobrante.Text = Convert.ToString(ValorMoney); txtFaltante.Text = "0";
                }
                else if (ValorMoney < 0)
                {
                    txtFaltante.Text = Convert.ToString(ValorMoney); txtSobrante.Text = "0";
                }
                else
                {
                    txtSobrante.Text = "0"; txtFaltante.Text = "0";
                }
            }
        }
    }
}
