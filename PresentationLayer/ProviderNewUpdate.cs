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
    public partial class ProviderNewUpdate : Form
    {
        public ProviderNewUpdate()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListRub(string condition)
        {
            AreaModel model = new AreaModel();
            cboRub.DataSource = model.ListArea(condition);
            cboRub.ValueMember = "_ID";
            cboRub.DisplayMember = "_RUBRO";
            Activity();
        }

        public void Pais()
        {
            PaisModel model = new PaisModel();
            cboPais.DataSource = model.ListPais("");
            cboPais.ValueMember = "ID";
            cboPais.DisplayMember = "NOMPAI";
            Province();
        }

        public void Province()
        {
            ProvinceModel model = new ProvinceModel();
            cboProvinc.DataSource = model.FilterProvince(Convert.ToInt32(cboPais.SelectedValue));
            cboProvinc.ValueMember = "_ID";
            cboProvinc.DisplayMember = "_NOMPRO";
            DistricList();
        }

        private void cboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Province();
        }

        public void DistricList()
        {
            DistricModel model = new DistricModel();
            cboDistri.DataSource = model.FilterDistric(Convert.ToInt32(cboProvinc.SelectedValue));
            cboDistri.ValueMember = "_ID";
            cboDistri.DisplayMember = "_NOMDIS";
        }

        private void cboProvinc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DistricList();
        }

        public void Activity()
        {
            ActivityModel model = new ActivityModel();
            cboActv.DataSource = model.FilterActivity(Convert.ToInt32(cboRub.SelectedValue));
            cboActv.ValueMember = "_ID";
            cboActv.DisplayMember = "_ACTEMP";
        }

        private void cboRub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Activity();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea agregar datos?","¡ADD ITEMS!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && btnNew.Text != "Grabar")
            {
                ProviderEntity entity = new ProviderEntity();
                entity._IDEMP = Convert.ToDouble(txtID.Text);
                entity._RUC = Convert.ToDouble(txtRuc.Text);
                entity._EMPRUB = txtNom.Text;
                entity._CODPOST = Convert.ToDouble(txtPost.Text);
                entity._PROVEMP = cboProvinc.Text;
                entity._CIUDAD = cboDistri.Text;
                entity._TELEF = textTelf.Text;
                entity._EMAIL = txtCorr.Text;
                entity._IDRUB = Convert.ToInt32(cboRub.SelectedValue);
                entity._IDACTEMP = Convert.ToInt32(cboActv.SelectedValue);
                entity._EMPDIR = txtDirecc.Text;
                ProvidersModel model = new ProvidersModel();
                model.InsertProvider(entity);
            }
            else if (result == DialogResult.Yes && btnNew.Text == "Grabar")
            {
                ProviderEntity entity = new ProviderEntity();
                entity._IDEMP = Convert.ToDouble(txtID.Text);
                entity._RUC = Convert.ToDouble(txtRuc.Text);
                entity._EMPRUB = txtNom.Text;
                entity._CODPOST = Convert.ToDouble(txtPost.Text);
                entity._PROVEMP = cboProvinc.Text;
                entity._CIUDAD = cboDistri.Text;
                entity._TELEF = textTelf.Text;
                entity._EMAIL = txtCorr.Text;
                entity._IDRUB = Convert.ToInt32(cboRub.SelectedValue);
                entity._IDACTEMP = Convert.ToInt32(cboActv.SelectedValue);
                entity._EMPDIR = txtDirecc.Text;
                ProvidersModel model = new ProvidersModel();
                model.UpdateProvider(entity);
            }
            this.Close();
        }
    }
}
