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
using Domain_Layer;
using CommonSupport;

namespace PresentationLayer
{
    public partial class SalesDesign : Form
    {
        public SalesDesign()
        {
            InitializeComponent();
        }
        
        private void SalesDesign_Load(object sender, EventArgs e)
        {
            
        }

        decimal Impuest = 0;
        private void AddCarrito(double Condicion)
        {
            int cant = 1;
            double SubTotal =0;
            bool ban = false;
            
            ProductModel model = new ProductModel();
            List<ProductEntity> MyList = new List<ProductEntity>();
            MyList = model.FilterProdct(Condicion);
            string codbarr = "";
            for (int i = 0; i < MyList.Count; i++)
            {
                codbarr = MyList[i]._CODBARR;
            }

            if (dataGridViewSales.RowCount == 0)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    dataGridViewSales.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO, MyList[i]._PREUNIT,
                    cant, Convert.ToDouble(MyList[i]._PREUNIT * cant));
                    Impuest = Impuest +((MyList[i]._PREUNIT * 1) * MyList[i]._IMPUEST / 100);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewSales.Rows)
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
                        dataGridViewSales.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO, MyList[i]._PREUNIT,
                        cant, Convert.ToDouble(MyList[i]._PREUNIT * cant));
                        Impuest = Impuest + ((MyList[i]._PREUNIT * cant) * MyList[i]._IMPUEST / 100);
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridViewSales.Rows.Count; i++)
                    {
                        if (Convert.ToString(dataGridViewSales[0, i].Value) == codbarr)
                        {
                            cant = Convert.ToInt32(dataGridViewSales[3, i].Value) + 1;
                            SubTotal = Convert.ToDouble(dataGridViewSales[2, i].Value) * cant;
                            dataGridViewSales[3, i].Value = cant;
                            dataGridViewSales[4, i].Value = SubTotal;
                            for (int j = 0; j < MyList.Count; j++)
                            {
                                Impuest = Impuest + ((MyList[j]._PREUNIT * 1) * MyList[j]._IMPUEST / 100);
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Clientes";
            design.ListDataSearch();
            design.ShowDialog();
            textBox2.Text = design.DNI;
            textBox3.Text = design.DATOS;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Productos";
            design.ListDataSearch();
            design.ShowDialog();
            textBox1.Text = design.CODPROD;
            textBox1.Focus();
        }

        decimal Descuento = 0;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != string.Empty)
                    {
                        ProductModel model = new ProductModel();
                        List<ProductEntity> MyList = new List<ProductEntity>();
                        MyList = model.FilterProdct(Convert.ToDouble(textBox1.Text));
                        int Dispon=0;
                        
                        for (int i = 0; i < MyList.Count; i++)
                        {
                            Dispon = MyList[i]._CANTPRO - Convert.ToInt32(MyList[i]._CANTRES);
                            foreach (DataGridViewRow rows in dataGridViewSales.Rows)
                            {
                                if (MyList[i]._CODBARR == rows.Cells["CodProd"].Value.ToString())
                                    Dispon = Dispon - Convert.ToInt32(rows.Cells["cantPed"].Value);
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

                                    foreach (DataGridViewRow rows in dataGridViewSales.Rows)
                                    {
                                        if (MyList2[j]._CODBARR == rows.Cells["CodProd"].Value.ToString())
                                            cantOfert = cantOfert - Convert.ToInt32(rows.Cells["cantPed"].Value);
                                    }
                                    if (cantOfert > 0)
                                    {
                                        if (textBox1.Text == Convert.ToString(MyList2[j]._CODPROD) || textBox1.Text == MyList2[j]._CODBARR)
                                            Descuento = Descuento + (MyList2[j]._DESCUENTO * Convert.ToDecimal(MyList2[j]._PREUNIT) / 100);
                                    }
                                }
                            }
                            AddCarrito(Convert.ToDouble(textBox1.Text));
                            label3.Text = "";
                            textBox1.Clear();
                        }
                        else
                            label3.Text = "¡PRODUCTO SIN STOCK!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dataGridViewSales.Rows.Count > 0)
            {
                double suma = 0;
                decimal pagar = 0;
                foreach (DataGridViewRow row in dataGridViewSales.Rows)
                {
                    suma = suma + Convert.ToDouble(row.Cells["SubTotal"].Value);
                    string subTot = Convert.ToString(suma.ToString("C2", CultureInfo.CurrentCulture));
                    int fn = subTot.Length - 2;
                    txtSubTot.Text = Convert.ToString(subTot.Substring(0, fn));

                }
                if (txtIGV.Text == string.Empty)
                {
                    txtIGV.Text = Convert.ToString("0");
                    if (txtDesc.Text == string.Empty)
                        txtDesc.Text = Convert.ToString("0");
                }
                
                pagar = Convert.ToDecimal(txtSubTot.Text) + Convert.ToDecimal(txtIGV.Text) - Descuento;
                
                string Total = Convert.ToString(pagar.ToString("C2", CultureInfo.CurrentCulture));
                int hasta = Total.Length - 2;
                txtTotPag.Text = Convert.ToString(Total.Substring(0, hasta));

                string impst = Convert.ToString(Impuest.ToString("C2", CultureInfo.CurrentCulture));
                int hst2 = impst.Length - 2;
                txtIGV.Text = Convert.ToString(impst.Substring(0, hst2));

                string descu = Convert.ToString(Descuento.ToString("C2", CultureInfo.CurrentCulture));
                int hast3 = descu.Length - 2;
                txtDesc.Text = Convert.ToString(descu.Substring(0, hast3));
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc.Text == string.Empty)
                txtDesc.Text = "0";
        }

        //private static void Moneda(ref TextBox cajaMoney)
        //{
        //    string n = string.Empty;
        //    double b = 0;
        //    cajaMoney.Text.Replace(",","").Replace(".","");
        //    if (n.Equals(""))
        //        n = "";
        //    n = n.PadLeft(3, '0');
        //    if (n.Length>3 && n.Substring(0,1) == "0")
        //        n = n.Substring(1, n.Length - 1);
        //    b = Convert.ToDouble(n) / 100;
        //    cajaMoney.Text = string.Format("{0:C2}", b);
        //    //cajaMoney.Text = b.ToString("{0:C2}");
        //}

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea quitar producto?","¡REMOVE ITEM!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && dataGridViewSales.RowCount > 0)
                dataGridViewSales.Rows.Remove(dataGridViewSales.CurrentRow);
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            if (ValidItems() == null)
            {
                ActualizarStock();
                VentaProductos();
            }
        }

        private void VentaProductos()
        {
            int MyNewID;
            MaxID ID = new MaxID();
            SalesModel model = new SalesModel();
            MyNewID = model.MaxID(ID);
            SalesEntity entity = new SalesEntity();
            entity._IDVENT = MyNewID;
            if (textBox2.Text != string.Empty)
                entity._IDCLIE = Convert.ToInt32(textBox2.Text);
            else
                entity._IDCLIE = 21212121;
            entity._IDCAJE = UserLoginCache.NumDocum;
            entity._FECHVE = DateTime.Now;
            entity._SUBTOT = Convert.ToDouble(txtSubTot.Text);
            entity._IGV = Convert.ToDouble(txtIGV.Text);
            entity._DESCUE = Convert.ToDouble(txtDesc.Text);
            entity._TOTPAG = Convert.ToDouble(txtTotPag.Text);
            model.RegisterSales(entity);

            foreach (DataGridViewRow item in dataGridViewSales.Rows)
            {
                DetailSalesEntity entity2 = new DetailSalesEntity();
                entity2._IDVENT = MyNewID;
                entity2._CODPRO = Convert.ToDouble(item.Cells["CodProd"].Value);
                entity2._DESPRO = item.Cells["DescProd"].Value.ToString();
                entity2._PREUNT = Convert.ToDouble(item.Cells["PreUnit"].Value);
                entity2._CANPRO = Convert.ToInt32(item.Cells["cantPed"].Value);
                entity2._SUBTOT = Convert.ToDouble(item.Cells["SubTotal"].Value);
                SalesDetailModel model2 = new SalesDetailModel();
                model2.InsertSalesDatail(entity2);
            }

            SalesPayOptions design = new SalesPayOptions();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.textBox1.Text = txtTotPag.Text;
            if (textBox3.Text != string.Empty)
                design.Clientes = textBox3.Text;
            else
                design.Clientes = "PÚBLICO GENERAL";
            design.IGV = txtIGV.Text;
            design.Descuento = txtDesc.Text;
            design.ID = MyNewID;
            design.ShowDialog();
            ClaerItems();
        }

        private void ActualizarStock()
        {
            foreach (DataGridViewRow item in dataGridViewSales.Rows)
            {
                ProductModel model = new ProductModel();
                ProductEntity entity = new ProductEntity();
                entity._CODPROD = Convert.ToDouble(item.Cells["CodProd"].Value);
                
                List<ProductEntity> MyList = new List<ProductEntity>();
                MyList = model.FilterProdct(Convert.ToDouble(item.Cells["CodProd"].Value));
                int Dispon = 0;
                for (int i = 0; i < MyList.Count; i++)
                {
                    Dispon = MyList[i]._CANTPRO - Convert.ToInt32(item.Cells["cantPed"].Value);
                }
                entity._CANTPRO = Dispon;
                model.UpdateStock(entity);
            }
        }

        private string ValidItems()
        {
            string MSGError = "NO HAY PRODUCTO DISPONIBLE PARA LA VENTA!.";
            if (dataGridViewSales.RowCount == 0) { return label3.Text = MSGError; }
            else { return label3.Text = null;  }
        }

        private void ClaerItems()
        {
            txtTotPag.Clear();
            txtSubTot.Clear();
            txtDesc.Clear();
            txtIGV.Clear();
            textBox2.Clear();
            textBox3.Clear();
            for (int i = 0; i < dataGridViewSales.RowCount; i--)
            {
                if (dataGridViewSales.RowCount != 0)
                    dataGridViewSales.Rows.Remove(dataGridViewSales.CurrentRow);
                else
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult rest = MessageBox.Show("¿Está seguro que desea cancelar la venta?","SALES", MessageBoxButtons.YesNo);
            if (rest == DialogResult.Yes)
                ClaerItems();
        }
    }
}
