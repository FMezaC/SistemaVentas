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
    public partial class BonusNewUpdateDesign : Form
    {
        public BonusNewUpdateDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BonusNewUpdateDesign_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
        }

        public void LoadStates()
        {
            StateGeneralModel model = new StateGeneralModel();
            comboBox1.DataSource = model.ListState();
            comboBox1.DisplayMember = "_ESTADO";
            comboBox1.ValueMember = "_ESTADO";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchDesign search = new SearchDesign();
            search.StartPosition = FormStartPosition.CenterScreen;
            search.search = "Clientes";
            search.ListDataSearch();
            search.ShowDialog();
            textBox1.Text = search.DNI;
            textBox4.Text = search.DATOS;
        }

        public int ID;
        private void btnNew_Click(object sender, EventArgs e)
        {
            bool Bandera = true;
            if (ValidateItems())
            {
                if (btnNew.Text != "Grabar")
                {
                    BonusEntity Entity = new BonusEntity();
                    Entity._NUMDOC = textBox1.Text;
                    Entity._ESTADO = comboBox1.Text;
                    Entity._TIPBON = textBox2.Text;
                    Entity._DESCUE = Convert.ToDecimal(textBox3.Text);
                    Entity._FCHINI = dateTimePicker1.Value;
                    Entity._FCHFIN = dateTimePicker2.Value;
                    Entity._USUARI = UserLoginCache.user;
                    Entity._TIPBEN = "CLIENTE";
                    BonusModel model = new BonusModel();
                    List<BonusEntity> ListBonus = new List<BonusEntity>();
                    ListBonus = model.ListBonusCustomer("");
                    for (int i = 0; i < ListBonus.Count; i++)
                    {
                        if (ListBonus[i]._NUMDOC == textBox1.Text && ListBonus[i]._FCHFIN >= DateTime.Now)
                        {
                            Bandera = false;
                        }
                    }
                    if (Bandera)
                        model.InsertBonus(Entity);
                    else
                        errorProvider1.SetError(textBox1, "!El Cliente tiene una bonificación Activo¡");
                }
                else if(btnNew.Text != "Registrar")
                {
                    BonusEntity EntityUPD = new BonusEntity();
                    EntityUPD._IDBONF = ID;
                    EntityUPD._ESTADO = comboBox1.Text;
                    EntityUPD._TIPBON = textBox2.Text;
                    EntityUPD._DESCUE = Convert.ToDecimal(textBox3.Text);
                    EntityUPD._FCHINI = dateTimePicker1.Value;
                    EntityUPD._FCHFIN = dateTimePicker2.Value;
                    EntityUPD._USUARI = UserLoginCache.user;
                    BonusModel modelUPD = new BonusModel();
                    modelUPD.UpdateBonus(EntityUPD);
                }
                if (Bandera)
                    this.Close();
            }
        }

        private bool ValidateItems()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == string.Empty)
                    {
                        errorProvider1.SetError(item, "¡Compo Obligatorio!");
                        break;
                    }
                    else
                    {
                        errorProvider1.SetError(item, null);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
