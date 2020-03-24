using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuntionalLayer;
using Domain_Layer;
using CommonSupport.EntityLayer;

namespace PresentationLayer
{
    public partial class AccountSeatNewUpdate : Form
    {
        public AccountSeatNewUpdate()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountSeatNewUpdate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        public void ListChartCounts(string condition)
        {
            ChartCountModel model = new ChartCountModel();
            comboBox1.DataSource = model.Filter(condition);
            comboBox1.ValueMember = "_ID";
            comboBox1.DisplayMember = "_DESCRIP";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                suma = suma + Convert.ToDouble(row.Cells["DEBE"].Value);
                textBox3.Text = Convert.ToString(suma);
            }

            double SumHaber = 0;
            foreach (DataGridViewRow row2 in dataGridView1.Rows)
            {
                SumHaber = SumHaber + Convert.ToDouble(row2.Cells["HABER"].Value);
                textBox4.Text = Convert.ToString(SumHaber);
            }

            AcountSetFuntion funtion = new AcountSetFuntion();
            textBox5.Text = funtion.ResidueCount(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            if (Convert.ToDouble(textBox5.Text) != 0)
            {
                textBox5.BackColor = Color.Red;
                textBox5.ForeColor = Color.White;
            }
            else
            {
                textBox5.BackColor = Color.LightGray;
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ListChartCounts(textBox6.Text);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text != "Grabar")
            {
                RegisterAccountSet();
            }
            else if (btnNew.Text != "Registrar")
            {
                UpdateAccountSet();
            }
            if (Validar())
            {
                FlaatSlanshDesign design = new FlaatSlanshDesign();
                design.title = "Manteniendo asiento contable";
                design.StartPosition = FormStartPosition.CenterScreen;
                design.ShowDialog();
            } 
        }

        public int MyID;
        private void RegisterAccountSet()
        {
            if (Validar())
            {
                AccountSeatModel model = new AccountSeatModel();
                MyID = Convert.ToInt32(model.MaxID());
                AccountSeatEntity entity = new AccountSeatEntity();
                entity._IDASI = MyID;
                entity._NUMASI = textBox1.Text;
                entity._FECHA = dateTimePicker1.Value;
                entity._NOTA = textBox2.Text;
                entity._TOTDEB = Convert.ToDouble(textBox3.Text);
                entity._TOTHAB = Convert.ToDouble(textBox4.Text);
                entity._RESTAN = Convert.ToDouble(textBox5.Text);
                entity._IDCUENT = Convert.ToInt32(comboBox1.SelectedValue);
                model.InsertASI(entity);

                AccountSeatDetEntity entity2 = new AccountSeatDetEntity();
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    entity2._CONCEP = (string)rows.Cells["CONCEP"].Value ?? "";
                    entity2._DETALL = (string)rows.Cells["DETALLE"].Value ?? "";
                    entity2._DEBE = Convert.ToDouble(rows.Cells["DEBE"].Value);
                    entity2._HAER = Convert.ToDouble(rows.Cells["HABER"].Value);
                    entity2._IDASI = MyID;
                    AccountSeatDetModel model2 = new AccountSeatDetModel();
                    model2.InsertDet(entity2);
                }
                this.Close();
            }
        }

        private void UpdateAccountSet()
        {
            if (Validar())
            {
                AccountSeatModel model = new AccountSeatModel();
                AccountSeatEntity entity = new AccountSeatEntity();
                entity._IDASI = MyID;
                entity._NUMASI = textBox1.Text;
                entity._FECHA = dateTimePicker1.Value;
                entity._NOTA = textBox2.Text;
                entity._TOTDEB = Convert.ToDouble(textBox3.Text);
                entity._TOTHAB = Convert.ToDouble(textBox4.Text);
                entity._RESTAN = Convert.ToDouble(textBox5.Text);
                entity._IDCUENT = Convert.ToInt32(comboBox1.SelectedValue);
                model.UpdateASI(entity);

                AccountSeatDetEntity entity2 = new AccountSeatDetEntity();
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    entity2._IDDET = Convert.ToInt32(rows.Cells["ID"].Value);
                    entity2._CONCEP = (string)rows.Cells["CONCEP"].Value ?? "";
                    entity2._DETALL = (string)rows.Cells["DETALLE"].Value ?? "";
                    entity2._DEBE = Convert.ToDouble(rows.Cells["DEBE"].Value);
                    entity2._HAER = Convert.ToDouble(rows.Cells["HABER"].Value);
                    AccountSeatDetModel model2 = new AccountSeatDetModel();
                    model2.UpdateDET(entity2);
                }
                this.Close();
            }
        }

        bool Validar()
        {
            if (textBox1.Text== string.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese Un Número de asiento válido!");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                if (textBox2.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox2, "Ingrese Una nota de referencia!");
                }
                else
                {
                    errorProvider1.SetError(textBox2, null);
                    return true;
                }
            }
            return false;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl text = (DataGridViewTextBoxEditingControl)e.Control;
            text.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
            text.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        public void ListDetall(int IDASI)
        {
            AccountSeatDetModel model = new AccountSeatDetModel();
            dataGridView1.DataSource = model.LisDetall(IDASI);
        }
    }
}
