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
    public partial class EmployeesUpdateNew : Form
    {
        public EmployeesUpdateNew()
        {
            InitializeComponent();
        }

        public void ListPais()
        {
            PaisModel model = new PaisModel();
            cboPais.DataSource = model.ListPais("");
            cboPais.ValueMember = "ID";
            cboPais.DisplayMember = "NOMPAI";

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

        public void Genero()
        {
            GenderModel model = new GenderModel();
            cboGenero.DataSource = model.ListGender("");
            cboGenero.DisplayMember = "_GENERO";
            cboGenero.ValueMember = "_CODGEN";
        }

        public void CivilStatus()
        {
            CivilStatusModel model = new CivilStatusModel();
            cboEstdCivil.DataSource = model.ListCivil("");
            cboEstdCivil.ValueMember = "_ESTCOD";
            cboEstdCivil.DisplayMember = "_ESTADO";
        }

        public void TipDocuemt()
        {
            DocumentTypeModel model = new DocumentTypeModel();
            cboDoc.DataSource = model.ListDocuemt("");
            cboDoc.ValueMember = "_IDDOC";
            cboDoc.DisplayMember = "_IDDOC";
        }

        public void TipUser()
        {
            UserTypeModel model = new UserTypeModel();
            cboTipUser.DataSource = model.ListUsers("");
            cboTipUser.ValueMember = "_ID";
            cboTipUser.DisplayMember = "_TIPOUS";
        }

        public void BranchList()
        {
            BranchOfficeModel model = new BranchOfficeModel();
            comboBox1.DataSource = model.ListBranch();
            comboBox1.ValueMember = "IDAUSUC";
            comboBox1.DisplayMember = "DESCSU";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboboxProvincia();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboboxDistric();
        }

        private void EmployeesUpdateNew_Load(object sender, EventArgs e)
        {
            dtpFechContr.Format = DateTimePickerFormat.Short;
            dtpNacim.Format = DateTimePickerFormat.Short;
        }

        string texto;
        private void txtNomb_TextChanged(object sender, EventArgs e)
        {
            if (btnNew.Text != "Grabar")
            {
                texto = txtNomb.Text;
                texto = texto.Substring(0, 1);
            }
        }

        private void txtApePater_TextChanged(object sender, EventArgs e)
        {
            if (btnNew.Text != "Grabar")
            {
                textBox1.Text = texto + txtApePater.Text;
            }
        }

        public int ID;
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?", "¡ADD NEW ITEM!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && btnNew.Text != "Grabar")
                {
                    EmployeesEntity entity = new EmployeesEntity();
                    entity._IDTIPD = cboDoc.SelectedValue.ToString();
                    entity._NUMDOC = txtNumDoc.Text;
                    entity._NOMEMP = txtNomb.Text;
                    entity._APEPAT = txtApePater.Text;
                    entity._APEMAT = txtApeMater.Text;
                    entity._FECHNA = Convert.ToDateTime(dtpNacim.Value);
                    entity._FECHCO = Convert.ToDateTime(dtpFechContr.Value);
                    entity._IDGENE = cboGenero.SelectedValue.ToString();
                    entity._DIRECC = txtDirecc.Text;
                    entity._IDDIST = Convert.ToInt32(cboDistri.SelectedValue);
                    entity._IDESTC = cboEstdCivil.SelectedValue.ToString();
                    entity._NUMCEL = txtNumCel.Text;
                    entity._CORREO = txtCorreo.Text;
                    entity._NUMHIJ = Convert.ToInt32(NumeHij.Value);
                    entity._SALARI = Convert.ToDouble(txtSalario.Text);
                    entity._IDAUSUC = Convert.ToInt32(comboBox1.SelectedValue);
                    EmployeeModel model = new EmployeeModel();
                    model.InsertEmployees(entity);

                    UserEntity userEntity = new UserEntity();
                    userEntity._USUARI = textBox1.Text;
                    userEntity._UPASSW = textBox2.Text;
                    userEntity._IDTIPO = Convert.ToInt32(cboTipUser.SelectedValue);
                    userEntity._NUMDNI = txtNumDoc.Text;
                    UserModel model2 = new UserModel();
                    model2.InsertUser(userEntity);
                }
                else if (result == DialogResult.Yes && btnNew.Text == "Grabar")
                {
                    EmployeesEntity entity = new EmployeesEntity();
                    entity._CODEMP = ID;
                    entity._IDTIPD = cboDoc.SelectedValue.ToString();
                    entity._NUMDOC = txtNumDoc.Text;
                    entity._NOMEMP = txtNomb.Text;
                    entity._APEPAT = txtApePater.Text;
                    entity._APEMAT = txtApeMater.Text;
                    entity._FECHNA = Convert.ToDateTime(dtpNacim.Value);
                    entity._FECHCO = Convert.ToDateTime(dtpFechContr.Value);
                    entity._IDGENE = cboGenero.SelectedValue.ToString();
                    entity._DIRECC = txtDirecc.Text;
                    entity._IDDIST = Convert.ToInt32(cboDistri.SelectedValue);
                    entity._IDESTC = cboEstdCivil.SelectedValue.ToString();
                    entity._NUMCEL = txtNumCel.Text;
                    entity._CORREO = txtCorreo.Text;
                    entity._NUMHIJ = Convert.ToInt32(NumeHij.Value);
                    entity._SALARI = Convert.ToDouble(txtSalario.Text);
                    entity._IDAUSUC = Convert.ToInt32(comboBox1.SelectedValue);
                    EmployeeModel model = new EmployeeModel();
                    model.UpdateEmployees(entity);

                    UserEntity userEntity = new UserEntity();
                    userEntity._NUMDNI = txtNumDoc.Text;
                    userEntity._IDTIPO = Convert.ToInt32(cboTipUser.SelectedValue);
                    UserModel model2 = new UserModel();
                    model2.UpdateUsertType(userEntity);
                }
                this.Close();
            }
        }

        bool ValidaCampos()
        {
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Text == string.Empty)
                    {
                        errorProvider1.SetError(ctr, "Campo Obligatorio");
                        break;
                    }
                    else
                    {
                        errorProvider1.SetError(ctr, null);
                        if (textBox2.Text == string.Empty)
                        {
                            errorProvider1.SetError(textBox2, "Ingrese una Contraseña Válida");
                            break;
                        }
                        else
                            errorProvider1.SetError(textBox2, null);
                    }
                }
            }
            return true;
        }
    }
}
