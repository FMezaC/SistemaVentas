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
    public partial class CustomerNewUpdate : Form
    {
        public CustomerNewUpdate()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ComboboxList()
        {
            DocumentTypeModel model = new DocumentTypeModel();
            cboDoc.DataSource = model.ListDocuemt("");
            cboDoc.DisplayMember = "_IDDOC";
            cboDoc.ValueMember = "_IDDOC";

            GenderModel model2 = new GenderModel();
            cboGenero.DataSource = model2.ListGender("");
            cboGenero.DisplayMember = "_GENERO";
            cboGenero.ValueMember = "_CODGEN";

            CivilStatusModel model3 = new CivilStatusModel();
            cboEstdCivil.DataSource = model3.ListCivil("");
            cboEstdCivil.ValueMember = "_ESTCOD";
            cboEstdCivil.DisplayMember = "_ESTADO";
        }

        public void ListPis()
        {
            PaisModel model1 = new PaisModel();
            cboPais.DataSource = model1.ListPais("");
            cboPais.DisplayMember = "NOMPAI";
            cboPais.ValueMember = "ID";

            ComboboxProvincia();
        }

        public void ComboboxProvincia()
        {
            ProvinceModel model2 = new ProvinceModel();
            cboProv.DataSource = model2.FilterProvince(Convert.ToInt32(cboPais.SelectedValue));
            cboProv.DisplayMember = "_NOMPRO";
            cboProv.ValueMember = "_ID";

            ComboboxDistric();
        }

        public void ComboboxDistric()
        {
            DistricModel model2 = new DistricModel();
            cboDistri.DataSource = model2.FilterDistric(Convert.ToInt32(cboProv.SelectedValue));
            cboDistri.DisplayMember = "_NOMDIS";
            cboDistri.ValueMember = "_ID";
        }

        private void CustomerNewUpdate_Load(object sender, EventArgs e)
        {
            dtpNacim.Format = DateTimePickerFormat.Short;
        }

        private void cboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboboxProvincia();
        }

        private void cboProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboboxDistric();
        }

        public int ID;
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (ValidarTextBox())
            {
                DialogResult Result = MessageBox.Show("¿Está seguro que desea agregar datos?", "¡ADD ITEM!", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes && btnNew.Text != "Grabar")
                {
                    if (ValID())
                    {
                        CustumerEntity entity = new CustumerEntity();
                        entity._TIPDOC = cboDoc.SelectedValue.ToString();
                        entity._NUMDNI = txtNumDoc.Text;
                        entity._NOMCLI = txtNomb.Text;
                        entity._APEPAT = txtApePater.Text;
                        entity._APEMAT = txtApeMater.Text;
                        entity._FECHNA = dtpNacim.Value;
                        entity._GENERO = cboGenero.SelectedValue.ToString();
                        entity._ESTCVI = cboEstdCivil.SelectedValue.ToString();
                        entity._DIRECC = txtDirecc.Text;
                        entity._DISTRI = cboDistri.Text;
                        entity._CEMAIL = txtCorreo.Text;
                        entity._NUMCEL = txtNumCel.Text;
                        entity._OCUPAS = txtocupass.Text;
                        CustumerModel model = new CustumerModel();
                        model.InsertCustrumer(entity);
                    }
                }
                else if (Result == DialogResult.Yes && btnNew.Text == "Grabar")
                {
                    CustumerEntity entity = new CustumerEntity();
                    entity._CODCLI = ID;
                    entity._TIPDOC = cboDoc.SelectedValue.ToString();
                    entity._NUMDNI = txtNumDoc.Text;
                    entity._NOMCLI = txtNomb.Text;
                    entity._APEPAT = txtApePater.Text;
                    entity._APEMAT = txtApeMater.Text;
                    entity._FECHNA = dtpNacim.Value;
                    entity._GENERO = cboGenero.SelectedValue.ToString();
                    entity._ESTCVI = cboEstdCivil.SelectedValue.ToString();
                    entity._DIRECC = txtDirecc.Text;
                    entity._DISTRI = cboDistri.Text;
                    entity._CEMAIL = txtCorreo.Text;
                    entity._NUMCEL = txtNumCel.Text;
                    entity._OCUPAS = txtocupass.Text;
                    CustumerModel model = new CustumerModel();
                    model.UpdateCustomer(entity);
                }
                this.Close();
            }
        }

        bool ValidarTextBox()
        {
            foreach (Control ctr in groupBox2.Controls )
            {
                if (ctr is TextBox)
                {
                    if (ctr.Text == string.Empty)
                    {
                        errorProvider1.SetError(ctr, "¡Todos los campos son obligatorios!");
                        break;
                    }
                    else
                    {
                        errorProvider1.SetError(ctr, null);
                        return true;
                    }
                }
            }
            return false;
        }

        bool ValID()
        {
            CustumerModel model = new CustumerModel();
            List<CustumerEntity> MyList = new List<CustumerEntity>();
            MyList = model.CustumerList("");
            bool existe = true;
            int contador = MyList.Count();
            for (int i = 0; i < contador; i++)
            {
                if (MyList[i]._NUMDNI == txtNumDoc.Text)
                {
                    errorProvider1.SetError(txtNumDoc, "Número Documento ya se encuentra Registrado");
                    existe = false;
                    break;
                }
            }
            if (existe)
            {
                errorProvider1.SetError(txtNumDoc, null);
                return true;
            }
            return false;
        }
    }
}
