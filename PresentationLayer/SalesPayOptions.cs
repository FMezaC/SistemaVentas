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
using CommonSupport;
using Domain_Layer;
using FuntionalLayer;
using System.Globalization;

namespace PresentationLayer
{
    public partial class SalesPayOptions : Form
    {
        public SalesPayOptions()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesPayOptions_Load(object sender, EventArgs e)
        {
            ListTypePay();
        }

        private void ListTypePay()
        {
            TypePayModel model = new TypePayModel();
            comboBox1.DataSource = model.ListPay("");
            comboBox1.ValueMember = "_ID";
            comboBox1.DisplayMember = "_DESCRIP";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) != 1)
            {
                checkBox1.Enabled = true;
                if (checkBox1.Checked == true)
                    numericUpDown1.Enabled = true;
                else
                    numericUpDown1.Enabled = false;
            }
            else
                checkBox1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            if (textBox2.Text != string.Empty)
            {
               double Devolu = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text);
                if (Devolu < 0)
                    textBox3.Text = "0";
                else
                {
                    string split = string.Format(nfi, "{0:C}", Devolu);
                    textBox3.Text = split;
                }
                double Deuda = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                if (Deuda >= 0)
                    textBox4.Text = Convert.ToString(Deuda);
                else
                    textBox4.Text = "0";
            }
            else
                textBox2.Text = "0";
        }

        public string Clientes, IGV, Descuento, opciones;
        public int ID;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                PayEntity entity = new PayEntity();
                entity._CODVEN = ID;
                entity._TICOMP = comboBox1.Text;
                entity._TOTPAG = Convert.ToDouble(textBox1.Text);
                entity._MONTOP = Convert.ToDouble(textBox2.Text);
                entity._VUELTO = Convert.ToDouble(textBox3.Text);
                entity._DEUDAP = Convert.ToDouble(textBox4.Text);
                if (numericUpDown1.Enabled)
                    entity._NUMCUO = Convert.ToInt32(numericUpDown1.Value);
                else
                    entity._NUMCUO = 0;
                PayModel model = new PayModel();
                model.InsertPay(entity);
                if (textBox4.Text != "0")
                {
                    textBox1.Text = textBox4.Text;
                    textBox2.Text = "0";
                }
                this.Close();
                ImprimirTicket();
            }
            SalesEntity entity2 = new SalesEntity();
            entity2._IDVENT = ID;
            SalesModel model2 = new SalesModel();
            model2.UpdateSalesState(entity2);
        }
        
        public void ImprimirTicket()
        {
            TiketFuntion ticket = new TiketFuntion();
            ticket.AbreCajon();
            // Datos de la cabezera

            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            for (int i = 0; i < MyList.Count; i++)
            {
                ticket.TextoCentro(MyList[i]._NOMEMP);
                ticket.TextoCentro("RAZ. SOCIAL: " + MyList[i]._RASOCI);
                ticket.TextoCentro("DIREC: " + MyList[i]._DIRECC);
                ticket.TextoCentro("TELF: " + MyList[i]._TELEF);
                ticket.TextoCentro("RUC: " + Convert.ToString(MyList[i]._NUMRUC));
                ticket.TextoCentro("EMAIL: " + MyList[i]._CORREO);
                ticket.Textoizquierda("");
                ticket.textoExtremo("CAJA", "TICKET Nº " + ID);
                ticket.LineasAsterisco();
            }
            

            // Subcabecera
            ticket.Textoizquierda("CAJERO: " + UserLoginCache.user);
            ticket.Textoizquierda("CLIENTE: " + Clientes);
            ticket.Textoizquierda("");
            ticket.textoExtremo("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.LineasAsterisco();


            // Articulo avender 
            ticket.EncabezadoVenta();
            ticket.LineasAsterisco();
            
            SalesDetailModel model2 = new SalesDetailModel();
            List<DetailSalesEntity> MyDetail = new List<DetailSalesEntity>();
            MyDetail = model2.ListDetail(ID);
            for (int i = 0; i < MyDetail.Count; i++)
            {
                ticket.AgregarArticulo(MyDetail[i]._DESPRO, MyDetail[i]._CANPRO,
                Convert.ToDecimal(MyDetail[i]._PREUNT), Convert.ToDecimal(MyDetail[i]._SUBTOT));
            }
            ticket.LineasAsterisco();
            // agregar subtotales

            ticket.Agregartotales("IGV: ", Convert.ToDecimal(IGV));
            ticket.Agregartotales("DESCUENTO: ", Convert.ToDecimal(Descuento));
            ticket.Agregartotales("IMPORTE: ", Convert.ToDecimal(textBox2.Text));
            ticket.Agregartotales("VUELTO: ", Convert.ToDecimal(textBox3.Text));
            ticket.LienasGuion();
            ticket.Agregartotales("TOTAL: ", Convert.ToDecimal(textBox1.Text));

            // texto Final
            ticket.Textoizquierda("");
            ticket.TextoCentro("!GRACIAS POR SU COMPRA¡");
            ticket.imprimirTicket("Microsoft XPS Document Writer");// Nombre de la impresora

            //OpenFileDialog odf = new OpenFileDialog();
            //if (DialogResult.OK == odf.ShowDialog(this))
            //{
            //    PrintDialog pd = new PrintDialog();
            //    pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            //    if (DialogResult.OK == pd.ShowDialog(this))
            //    {
            //        RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, odf.FileName);
            //    }
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != false)
                numericUpDown1.Enabled = true;
            else
                numericUpDown1.Enabled = false;
        }
    }
}
