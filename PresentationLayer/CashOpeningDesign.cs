using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport;
using CommonSupport.EntityLayer;
using Domain_Layer;
using System.Globalization;

namespace PresentationLayer
{
    public partial class CashOpeningDesign : Form
    {
        public CashOpeningDesign()
        {
            InitializeComponent();
        }
        private void CashOpeningDesign_Load(object sender, EventArgs e)
        {
             ListDataStart();
            statusStrip1.Cursor = Cursors.Hand;
        }

        private void ListDataStart()
        {
            lblUser.Text = UserLoginCache.user;
            lblFechaAper.Text = Convert.ToString(DateTime.Now);

            MoneyModel money = new MoneyModel();
            cboMoneda.DataSource = money.ListMoney("");
            cboMoneda.ValueMember = "_ID";
            cboMoneda.DisplayMember = "_MONEY";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            if (txtBillete.Text != string.Empty && txtMoneda.Text != string.Empty)
            {
                double Suma = Convert.ToDouble(txtBillete.Text) + Convert.ToDouble(txtMoneda.Text);
                string Total = string.Format(nfi, "{0:C}", Suma);
                txtTotal.Text = Total;
            }
            else
                if (txtBillete.Text != string.Empty)
                {
                    double Valor = Convert.ToDouble(txtBillete.Text);
                    string Total2 = string.Format(nfi, "{0:C}", Valor);
                    txtTotal.Text = Total2;
                }
        }
        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {
            // dar formato
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            double moneyIni = Convert.ToDouble(txtMoneda.Text);
            string moneda = string.Format(nfi, "{0:C}", moneyIni);
            txtMoneda.Text = moneda;
        }

        private void txtBillete_MouseLeave(object sender, EventArgs e)
        {
            // Aqui formato de moneda
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            if (txtBillete.Text != string.Empty)
            {
                double montoIni = Convert.ToDouble(txtBillete.Text);
                string Billete = string.Format(nfi, "{0:C}", montoIni);
                txtBillete.Text = Billete;
            }
        }
        
        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            CashEntity Entity = new CashEntity();
            int ValorArque;
            if (textBox3.Text != string.Empty)
                ValorArque = Convert.ToInt32(textBox3.Text);
            else
                ValorArque = 0;
            Entity._NUMARQ = ValorArque;
            Entity._USUARI = UserLoginCache.user;
            Entity._FCHAPE = Convert.ToDateTime(lblFechaAper.Text);
            Entity._TIPMON = cboMoneda.Text;
            Entity._MONAPE = Convert.ToDouble(txtTotal.Text);
            CashModel model = new CashModel();
            model.CashOpeninModel(Entity);
            this.Close();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
