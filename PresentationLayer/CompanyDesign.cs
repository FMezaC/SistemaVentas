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
    public partial class CompanyDesign : Form
    {
        public CompanyDesign()
        {
            InitializeComponent();
        }

        private void CompanyDesign_Load(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(DateTime.Now.Year+" - " + (DateTime.Now.Month));
            ListCompany();
        }

        int ID;
        private void ListCompany()
        {
            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            int contador = MyList.Count;
            for (int i = 0; i < contador; i++)
            {
                ID = MyList[i]._ID;
                textBox1.Text = Convert.ToString(MyList[i]._NUMRUC);
                textBox2.Text = MyList[i]._NOMEMP;
                textBox6.Text = MyList[i]._RASOCI;
                ListActivity();
                comboBox2.Text = MyList[i]._ACTIVI;
                ListPais();
                comboBox3.Text = MyList[i]._PAIS;
                ListProvince();
                comboBox4.Text = MyList[i]._PROVIN;
                ListDistrict();
                comboBox5.Text = MyList[i]._DISTRI;
                textBox4.Text = MyList[i]._DIRECC;
                textBox3.Text = MyList[i]._CORREO;
                maskedTextBox1.Text = MyList[i]._TELEF;
                maskedTextBox2.Text = MyList[i]._MOVIL;
            }
        }
        
        private void ListActivity()
        {
            AreaModel model = new AreaModel();
            comboBox2.DataSource = model.ListArea("");
            comboBox2.ValueMember = "_RUBRO";
            comboBox2.DisplayMember = "_RUBRO";
        }

        private void ListPais()
        {
            PaisModel model = new PaisModel();
            comboBox3.DataSource = model.ListPais("");
            comboBox3.ValueMember = "ID";
            comboBox3.DisplayMember = "NOMPAI";
        }
        private void ListProvince()
        {
            ProvinceModel model = new ProvinceModel();
            comboBox4.DataSource = model.FilterProvince(Convert.ToInt32(comboBox3.SelectedValue));
            comboBox4.ValueMember = "_ID";
            comboBox4.DisplayMember = "_NOMPRO";
        }

        private void ListDistrict()
        {
            DistricModel model = new DistricModel();
            comboBox5.DataSource = model.FilterDistric(Convert.ToInt32(comboBox4.SelectedValue));
            comboBox5.ValueMember = "_NOMDIS";
            comboBox5.DisplayMember = "_NOMDIS";
        }

        private void btnSabe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de actualizar Datos?", "¡UPDATE ITEMS!", MessageBoxButtons.YesNo);
            if (ValidateTextBox() && result == DialogResult.Yes)
            {
                CompanyEntity entity = new CompanyEntity();
                entity._ID = ID;
                entity._NUMRUC = Convert.ToDouble(textBox1.Text);
                entity._NOMEMP = textBox2.Text;
                entity._RASOCI = textBox6.Text;
                entity._ACTIVI = comboBox2.Text;
                entity._PAIS = comboBox3.Text;
                entity._PROVIN = comboBox4.Text;
                entity._DISTRI = comboBox5.Text;
                entity._DIRECC = textBox4.Text;
                entity._CORREO = textBox3.Text;
                entity._TELEF = maskedTextBox1.Text;
                entity._MOVIL = maskedTextBox2.Text;
                CompanyModel model = new CompanyModel();
                model.UpdateCompany(entity);
            }
            ListCompany();
        }

        bool ValidateTextBox()
        {
            string error = "Todos Los Campos Son Obligatorios";
            foreach (TextBox txt in groupBox1.Controls)
            {
                if (txt.Text == string.Empty)
                {
                    errorProvider1.SetError(txt, error);
                    return false;
                }
                else
                {
                    errorProvider1.SetError(txt, null);
                    foreach (TextBox txt2 in groupBox2.Controls)
                    {
                        if (txt2.Text == string.Empty)
                        {
                            errorProvider1.SetError(txt2, error);
                            return false;
                        }
                        else
                        {
                            errorProvider1.SetError(txt2, null);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListProvince();
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListDistrict();
        }
    }
}
