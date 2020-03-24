using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport.EntityLayer;
using CommonSupport;
using Domain_Layer;

namespace PresentationLayer
{
    public partial class BillingDesign : Form
    {
        public BillingDesign()
        {
            InitializeComponent();
        }

        private void BillingDesign_Load(object sender, EventArgs e)
        {
            ListTypePay();
            ListTypeMoney();
            ListTypeBilling("");
            ListStates();
            statusStrip1.Cursor = Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListStates()
        {
            StateGeneralModel model = new StateGeneralModel();
            comboBox3.DataSource = model.ListState();
            comboBox3.DisplayMember = "_ESTADO";
            comboBox3.ValueMember = "_ESTADO";
        }

        private void ListTypePay()
        {
            TypePayModel model = new TypePayModel();
            comboBox1.DataSource = model.ListPay("");
            comboBox1.ValueMember = "_ID";
            comboBox1.DisplayMember = "_DESCRIP";
        }

        private void ListTypeMoney()
        {
            MoneyModel model = new MoneyModel();
            comboBox2.DataSource = model.ListMoney("");
            comboBox2.ValueMember = "_ID";
            comboBox2.DisplayMember = "_MONEY";
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Clientes";
            design.ListDataSearch();
            design.ShowDialog();
            textBox4.Text = design.DNI;
            textBox5.Text = design.DATOS;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerNewUpdate design = new CustomerNewUpdate();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.ComboboxList();
            design.ListPis();
            //design.btnNew.Text = "Registrar";
            design.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Productos";
            design.ListDataSearch();
            design.ShowDialog();
            textBox7.Text = design.CODPROD;
            label11.Text = design.PRODUC;
            textBox7.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListTypeBilling(textBox1.Text);
        }

        private void ListTypeBilling(string ID)
        {
            BillingTypeModel model = new BillingTypeModel();
            comboBox4.DataSource = model.ListBillingType(ID);
            comboBox4.DisplayMember = "_FACTURA";
            comboBox4.ValueMember = "_CODFACT";
        }

        decimal Descuento = 0;
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar ==(int)Keys.Enter)
            {
                try
                {
                    if (textBox7.Text != string.Empty)
                    {
                        ProductModel model = new ProductModel();
                        List<ProductEntity> MyList = new List<ProductEntity>();
                        MyList = model.FilterProdct(Convert.ToDouble(textBox7.Text));
                        int Dispon = 0;
                        for (int i = 0; i < MyList.Count; i++)
                        {
                            Dispon = MyList[i]._CANTPRO - Convert.ToInt32(MyList[i]._CANTRES);
                            foreach (DataGridViewRow rows in dataGridView1.Rows)
                            {
                                if (MyList[i]._CODBARR == rows.Cells["CodProd"].Value.ToString())
                                {
                                    Dispon = Dispon - Convert.ToInt32(rows.Cells["CantProd"].Value);
                                }
                            }
                        }
                        if (Dispon > 0)
                        {
                            OfertsModel model2 = new OfertsModel();
                            List<OfertsEntity> MyList2 = new List<OfertsEntity>();
                            MyList2 = model2.ListOferts("");
                            int cantOfert = 0;
                            for (int j = 0; j < MyList2.Count; j++)
                            {
                                if (MyList2[j]._FECHFINAL >= DateTime.Now && MyList2[j]._FECHIICIO <= DateTime.Now)
                                {
                                    cantOfert = MyList2[j]._CANTPRO;

                                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                                    {
                                        if (MyList2[j]._CODBARR == rows.Cells["CodProd"].Value.ToString())
                                            cantOfert = cantOfert - Convert.ToInt32(rows.Cells["CantProd"].Value);
                                    }
                                    if (cantOfert > 0)
                                    {
                                        if (textBox7.Text == Convert.ToString(MyList2[j]._CODPROD) || textBox7.Text == MyList2[j]._CODBARR)
                                            Descuento = Descuento + (MyList2[j]._DESCUENTO * Convert.ToDecimal(MyList2[j]._PREUNIT) / 100);
                                    }
                                }
                            }
                            AddCarrito(Convert.ToDouble(textBox7.Text));
                            label11.Text = "";
                            textBox7.Clear();
                        }
                        else
                            label11.Text = "¡PRODUCTO SIN STOCK!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        decimal impuest = 0;
        private void AddCarrito(double Condicion)
        {
            int cant = 1;
            double SubTotal = 0;
            bool ban = false;

            ProductModel model = new ProductModel();
            List<ProductEntity> MyList = new List<ProductEntity>();
            MyList = model.FilterProdct(Condicion);
            string codbarr = "";
            for (int i = 0; i < MyList.Count; i++)
            {
                codbarr = MyList[i]._CODBARR;
            }

            if (dataGridView1.RowCount == 0)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    dataGridView1.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO,MyList[i]._UMSTOCK,
                    cant, MyList[i]._PREUNIT, Convert.ToDouble(MyList[i]._PREUNIT * cant));
                    impuest = impuest + (Convert.ToDecimal(MyList[i]._PREUNIT * cant) * MyList[i]._IMPUEST / 100);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == codbarr)
                    {
                        ban = true;
                        break;
                    }
                    ban = false;
                }
                if (!ban)
                {
                    for (int i = 0; i < MyList.Count; i++)
                    {
                        dataGridView1.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO, MyList[i]._UMSTOCK,
                        cant, MyList[i]._PREUNIT, Convert.ToDouble(MyList[i]._PREUNIT * cant));
                        impuest = impuest + (Convert.ToDecimal(MyList[i]._PREUNIT * cant) * MyList[i]._IMPUEST / 100);
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dataGridView1[0, i].Value) == codbarr)
                        {
                            cant = Convert.ToInt32(dataGridView1[3, i].Value) + 1;
                            SubTotal = Convert.ToDouble(dataGridView1[4, i].Value) * cant;
                            dataGridView1[3, i].Value = cant;
                            dataGridView1[5, i].Value = SubTotal;
                            for (int J = 0; J < MyList.Count; J++)
                            {
                                impuest = impuest + (Convert.ToDecimal(MyList[J]._PREUNIT * 1) * MyList[J]._IMPUEST / 100);
                            }
                            break;
                        }
                    }
                }
            }
        }
        
        decimal bonif = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            if (dataGridView1.RowCount > 0)
            {
                decimal subTotal = 0;
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    subTotal = subTotal + Convert.ToDecimal(rows.Cells["SubTot"].Value);
                }
                string Total = string.Format(nfi, "{0:C}", subTotal);
                textBox8.Text = Total;
                string imp = string.Format(nfi, "{0:C}", impuest);
                textBox10.Text = imp;

                string descu = string.Format(nfi, "{0:C}", Descuento);
                textBox2.Text = descu;
                
                if (textBox4.Text != string.Empty)
                {
                    BonusModel ModelBNF = new BonusModel();
                    List<BonusEntity> ListBonus = new List<BonusEntity>();
                    ListBonus = ModelBNF.ListBonusCustomer("");
                    for (int i = 0; i < ListBonus.Count; i++)
                    {
                        if (textBox4.Text == ListBonus[i]._NUMDOC && ListBonus[i]._FCHFIN >= DateTime.Now && ListBonus[i]._ESTADO != "FINALIZADO")
                            bonif = Convert.ToDecimal(textBox8.Text) * ListBonus[i]._DESCUE / 100;
                        else
                            bonif = 0;
                    }
                }
                string bonus = string.Format(nfi, "{0:C}", bonif);
                textBox9.Text = bonus;

                decimal TotalP = (Convert.ToDecimal(textBox10.Text) + Convert.ToDecimal(textBox8.Text)) - (Convert.ToDecimal(textBox9.Text) + Convert.ToDecimal(textBox2.Text));
                string TotPstr = string.Format(nfi, "{0:C}", TotalP);
                textBox3.Text = TotPstr;
            }
        }
        
        void CleartItems()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            for (int i = 0; i < dataGridView1.RowCount; i--)
            {
                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                else
                    break;
            }
        }

        bool validarTextbox()
        {
            if (textBox5.Text == string.Empty)
            {
                errorProvider1.SetError(textBox5, "Seleccione un Cliente a Facturar.");
            }
            else
            {
                errorProvider1.SetError(textBox5, null);
                if (dataGridView1.RowCount > 0)
                {
                    errorProvider1.SetError(textBox7, null);
                    return true;
                }
                else
                    errorProvider1.SetError(textBox7, "No hay Productos para la Factura.");
            }
            return false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (validarTextbox())
            {
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    BillingDetailEntity BDEntity = new BillingDetailEntity();
                    BDEntity._CODPRO = Convert.ToDouble(rows.Cells["CodProd"].Value);
                    BDEntity._DESCRI = rows.Cells["descrip"].Value.ToString();
                    BDEntity._UNIMED = rows.Cells["UniMedi"].Value.ToString();
                    BDEntity._CANTID = Convert.ToInt32(rows.Cells["CantProd"].Value);
                    BDEntity._PREUIT = Convert.ToDouble(rows.Cells["PREUNIT"].Value);
                    BDEntity._SUBTOT = Convert.ToDouble(rows.Cells["SubTot"].Value);
                    BillingModel BDModel = new BillingModel();
                    BDModel.InsertDetailBilling(BDEntity);
                }

                BillingEntity EntityBG = new BillingEntity();
                EntityBG._TIPFAC = comboBox4.Text;
                EntityBG._FCHFAC = dateTimePicker1.Value;
                EntityBG._FCHVEN = dateTimePicker2.Value;
                EntityBG._BNFDOC = textBox4.Text;
                EntityBG._TIPPAG = comboBox1.Text;
                EntityBG._TIPMON = comboBox2.Text;
                EntityBG._ESTADO = comboBox3.Text;
                EntityBG._SUBTOT = Convert.ToDouble(textBox8.Text);
                EntityBG._BONIFI = Convert.ToDouble(textBox9.Text);
                EntityBG._IMPUST = Convert.ToDouble(textBox10.Text);
                EntityBG._DESCUE = Convert.ToDouble(textBox2.Text);
                EntityBG._TOTPAG = Convert.ToDouble(textBox3.Text);
                EntityBG._USUARI = UserLoginCache.user;
                BillingModel ModelBG = new BillingModel();
                ModelBG.InsertBillig(EntityBG);

                FlaatSlanshDesign design = new FlaatSlanshDesign();
                design.StartPosition = FormStartPosition.CenterScreen;
                design.title = "Generando Factura...";
                design.ShowDialog();
                CleartItems();
            }
        }
    }
}
