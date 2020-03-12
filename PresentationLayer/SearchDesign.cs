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

namespace PresentationLayer
{
    public partial class SearchDesign : Form
    {
        public SearchDesign()
        {
            InitializeComponent();
        }

        private void labelCirculo2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string search;
        public void ListDataSearch()
        {
            switch (search)
            {
                case "Productos":
                    label3.Text = "PRODUCTO:";
                    ProductModel model = new ProductModel();
                    dataGridView1.DataSource = model.ListProducts(textBox4.Text);
                    break;
                case "Clientes":
                    label3.Text = "CLIENTE:";
                    CustumerModel model2 = new CustumerModel();
                    dataGridView1.DataSource = model2.CustumerList(textBox4.Text);
                    break;
                case "Empleados":
                    label3.Text = "EMPLEADO:";
                    EmployeeModel model3 = new EmployeeModel();
                    dataGridView1.DataSource = model3.ListEmployee(textBox4.Text);
                    break;
                case "Proveedor":
                    label3.Text = "PROVEEDOR:";
                    ProvidersModel model4 = new ProvidersModel();
                    dataGridView1.DataSource = model4.ListProviders(textBox4.Text);
                    break;
                case "Cuentas":
                    label3.Text = "CUENTA:";
                    CountModel model5 = new CountModel();
                    dataGridView1.DataSource = model5.ListCount(textBox4.Text);
                    break;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ListDataSearch();
            label2.Text = Convert.ToString(dataGridView1.RowCount);
        }

        public string DNI;
        public string DATOS;
        public string CODPROD;
        public string PRODUC;

        public string NUMCUEN;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (search)
            {
                case "Productos":
                    CODPROD = dataGridView1.CurrentRow.Cells["_CODPROD"].Value.ToString();
                    PRODUC = dataGridView1.CurrentRow.Cells["_DESCPRO"].Value.ToString();
                    break;
                case "Clientes":
                    DNI = dataGridView1.CurrentRow.Cells["_NUMDNI"].Value.ToString();
                    DATOS = dataGridView1.CurrentRow.Cells["_NOMCLI"].Value.ToString() + " " +
                    dataGridView1.CurrentRow.Cells["_APEPAT"].Value.ToString() + " " +
                    dataGridView1.CurrentRow.Cells["_APEMAT"].Value.ToString();
                    break;
                case "Empleados":
                    DNI = dataGridView1.CurrentRow.Cells["_NUMDOC"].Value.ToString();
                    DATOS = dataGridView1.CurrentRow.Cells["_NOMEMP"].Value.ToString() + " " +
                    dataGridView1.CurrentRow.Cells["_APEPAT"].Value.ToString() + " " +
                    dataGridView1.CurrentRow.Cells["_APEMAT"].Value.ToString();
                    CODPROD = dataGridView1.CurrentRow.Cells["_USUARIO"].Value.ToString();
                    PRODUC = dataGridView1.CurrentRow.Cells["_TIPUSER"].Value.ToString();
                    break;
                case "Proveedor":
                    DNI = dataGridView1.CurrentRow.Cells["_IDEMP"].Value.ToString();
                    DATOS = dataGridView1.CurrentRow.Cells["_EMPRUB"].Value.ToString();
                    break;
                case "Cuentas":
                    DNI = dataGridView1.CurrentRow.Cells["NUMCUEN"].Value.ToString();
                    DATOS = dataGridView1.CurrentRow.Cells["NOMBUSU"].Value.ToString() + " / " +
                        dataGridView1.CurrentRow.Cells["ENTIDAD"].Value.ToString();
                    NUMCUEN = dataGridView1.CurrentRow.Cells["IDCUENT"].Value.ToString();
                    break;
            }
            this.Close();
        }

        private void SearchDesign_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(dataGridView1.RowCount);
        }
    }
}
