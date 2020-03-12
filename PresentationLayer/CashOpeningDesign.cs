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
        
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashOpeningDesign_Load(object sender, EventArgs e)
        {
             ListDataStart();
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
            if (txtBillete.Text != string.Empty && txtMoneda.Text != string.Empty)
            {
                double Suma = Convert.ToDouble(txtBillete.Text) + Convert.ToDouble(txtMoneda.Text);
                string Total = Convert.ToString(Suma.ToString("C2", CultureInfo.CurrentCulture));
                int Hasta = Total.Length - 2;
                txtTotal.Text = Convert.ToString(Total.Substring(0, Hasta));
            }
            else
                if (txtBillete.Text != string.Empty)
                {
                    double Valor = Convert.ToDouble(txtBillete.Text);
                    string Total2 = Convert.ToString(Valor.ToString("C2", CultureInfo.CurrentCulture));
                    int Hasta2 = Total2.Length - 2;
                    txtTotal.Text = Convert.ToString(Total2.Substring(0, Hasta2));
                }
        }
        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {
            // dar formato
            double moneyIni = Convert.ToDouble(txtMoneda.Text);
            string moneda = Convert.ToString(moneyIni.ToString("C2", CultureInfo.CurrentCulture));
            int split = moneda.Length - 2;
            txtMoneda.Text = Convert.ToString(moneda.Substring(0, split));
        }

        private void txtBillete_MouseLeave(object sender, EventArgs e)
        {
            // Aqui formato de moneda
            if (txtBillete.Text != string.Empty)
            {
                double montoIni = Convert.ToDouble(txtBillete.Text);
                string Billete = Convert.ToString(montoIni.ToString("C2", CultureInfo.CurrentCulture));
                int split = Billete.Length - 2;
                txtBillete.Text = Convert.ToString(Billete.Substring(0, split));
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
