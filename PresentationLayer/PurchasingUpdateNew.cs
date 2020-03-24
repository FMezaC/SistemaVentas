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
using System.Globalization;

namespace PresentationLayer
{
    public partial class PurchasingUpdateNew : Form
    {
        public PurchasingUpdateNew()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchasingUpdateNew_Load(object sender, EventArgs e)
        {
            LoadMoney();
            ListStates();
            ListTypePay();
            MaxIDGenerate();
        }

        private void MaxIDGenerate()
        {
            OrdersModel Mcount = new OrdersModel();
            textBox1.Text = Convert.ToString(Mcount.MaxIdCount());
            textBox11.Text = Convert.ToString(DateTime.Now.Year.ToString() + " - " + DateTime.Now.Month.ToString());
        }
        private void LoadMoney()
        {
            MoneyModel model = new MoneyModel();
            comboBox2.DataSource = model.ListMoney("");
            comboBox2.ValueMember = "_ID";
            comboBox2.DisplayMember = "_MONEY";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Proveedor";
            design.ListDataSearch();
            design.ShowDialog();
            textBox4.Text = design.DNI;
            textBox5.Text = design.DATOS;
        }

        // varible gobal
        private string NUMCUENT;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Cuentas";
            design.ListDataSearch();
            design.ShowDialog();
            textBox9.Text = design.DNI;
            textBox12.Text = design.DATOS;
            NUMCUENT = design.NUMCUEN;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ban = false;
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    string codbarr = "";
                    ProductModel model = new ProductModel();
                    List<ProductEntity> MyList = new List<ProductEntity>();
                    // cargamos la lista de productos
                    MyList = model.FilterProdct(Convert.ToDouble(textBox7.Text));
                    // recorremos la lista
                    for (int i = 0; i < MyList.Count; i++)
                    {
                        // guardamos el codigo de barra
                        codbarr = MyList[i]._CODBARR;
                    }
                    if (textBox7.Text != string.Empty)
                    {
                        // verificamos si la grilla ya tiene productos
                        if (dataGridView1.RowCount == 0)
                        {
                            errorProvider1.SetError(label11, null);
                            for (int i = 0; i < MyList.Count; i++)
                            {
                                // Agrega el primer producto
                                dataGridView1.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO, MyList[i]._UMSTOCK,
                                0,0,1, MyList[i]._PREUNIT, Convert.ToDouble(MyList[i]._PREUNIT * 1));
                            }
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                // Verificamos ya existe esteproducto en la grilla
                                if (Convert.ToString(row.Cells[0].Value) == codbarr)
                                {
                                    ban = true;
                                    break;
                                }
                                ban = false;
                            }
                            // valida existencia
                            if (ban)
                                // Muestra error
                                errorProvider1.SetError(label11, "EL PRODUCTO YA FUE AÑADIDO");
                            else
                            {
                                //Agrega 
                                errorProvider1.SetError(label11, null);
                                for (int i = 0; i < MyList.Count; i++)
                                {
                                    dataGridView1.Rows.Add(MyList[i]._CODBARR, MyList[i]._DESCPRO, MyList[i]._UMSTOCK,
                                    0,0,1, MyList[i]._PREUNIT, Convert.ToDouble(MyList[i]._PREUNIT * 1));
                                }
                            }
                        }
                    }
                    textBox7.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "";
            double igv = 0;
            double subTot = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double suma = 0;
                double impt = 0;
                // calcula impuesto
                impt = impt + (Convert.ToDouble(row.Cells["IGV"].Value) * 
                    (Convert.ToDouble(row.Cells["PREUNIT"].Value) * Convert.ToDouble(row.Cells["CantProd"].Value))) / 100;
                // calcula subtotal
                suma = suma + Convert.ToDouble(row.Cells["PREUNIT"].Value) * Convert.ToDouble(row.Cells["CantProd"].Value);
                // comvierte la suma en un formato moneda
                string Total = string.Format(nfi, "{0:C}", suma);
                int hasta = Total.Length - 2;
                //añadimos el subtotal sin igv
                row.Cells["SubTot"].Value = Convert.ToString(Total.Substring(0, hasta));
                //almacenamos el igv en una columna oculta
                row.Cells["Impuesto"].Value = impt;
                //suma subtotales 
                subTot += Convert.ToDouble(row.Cells["SubTot"].Value);
                // suma impuestos
                igv += impt;
            }
            textBox10.Text = Convert.ToString(igv);
            textBox8.Text = Convert.ToString(subTot);
            double total = (Convert.ToDouble(textBox10.Text) + Convert.ToDouble(textBox8.Text))-
                (Convert.ToDouble(textBox13.Text)+Convert.ToDouble(textBox2.Text));
            textBox3.Text = Convert.ToString(total);
        }

        //Metodo de Insertar
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // Metodo de verificar
        bool validarTextbox()
        {
            if (textBox5.Text == string.Empty)
                errorProvider1.SetError(textBox5, "Seleccione un Proveedor.");
            else
            {
                errorProvider1.SetError(textBox5, null);
                if (textBox12.Text == string.Empty)
                    errorProvider1.SetError(textBox12, "Seleccione una Cuenta.");                
                else
	              {
                    errorProvider1.SetError(textBox12, null);
                    if (dataGridView1.RowCount > 0)
                    {
                        errorProvider1.SetError(textBox7, null);
                        return true;
                    }
                    else
                        errorProvider1.SetError(textBox7, "No hay Productos para la Compra.");
                  }
            }
            return false;
        }

        // Metodo de limpiar
        void ClearItems()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }

            for (int i = 0; i < dataGridView1.RowCount; i--)
            {
                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                else
                    break;
            }
            DateTime date = DateTime.Now;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;
        }
    }
}
