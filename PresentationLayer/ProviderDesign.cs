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
    public partial class ProviderDesign : Form
    {
        public ProviderDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProviderDesign_Load(object sender, EventArgs e)
        {
            ListProviders("");
        }

        private void ListProviders(string conditions)
        {
            ProvidersModel model = new ProvidersModel();
            dataGridReportes.DataSource = model.ListProviders(conditions);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ProvidersModel model = new ProvidersModel();
            dataGridReportes.DataSource = model.ListProviders(txtBuscar.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ProviderNewUpdate model = new ProviderNewUpdate();
            model.ListRub("");
            model.Pais();
            ProvidersModel model2 = new ProvidersModel();
            MaxID entity = new MaxID();
            model.txtID.Text = Convert.ToString(model2.MaxID(entity));
            model.btnNew.Text = "Registrar";
            model.ShowDialog();
            ListProviders("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProviderNewUpdate design = new ProviderNewUpdate();
            design.txtID.Text = dataGridReportes.CurrentRow.Cells["_IDEMP"].Value.ToString();
            design.txtRuc.Text = dataGridReportes.CurrentRow.Cells["_RUC"].Value.ToString();
            design.txtNom.Text = dataGridReportes.CurrentRow.Cells["_EMPRUB"].Value.ToString();
            design.txtPost.Text = dataGridReportes.CurrentRow.Cells["_CODPOST"].Value.ToString();
            design.txtCorr.Text = dataGridReportes.CurrentRow.Cells["_EMAIL"].Value.ToString();
            design.textTelf.Text = dataGridReportes.CurrentRow.Cells["_TELEF"].Value.ToString();
            design.ListRub("");
            design.cboRub.Text = dataGridReportes.CurrentRow.Cells["_RUBRO"].Value.ToString();
            design.Activity();
            design.cboActv.Text = dataGridReportes.CurrentRow.Cells["_ACTEMP"].Value.ToString();
            design.Pais();
            design.cboPais.Text = dataGridReportes.CurrentRow.Cells["_PAIS"].Value.ToString();
            design.Province();
            design.cboProvinc.Text = dataGridReportes.CurrentRow.Cells["_PROVEMP"].Value.ToString();
            design.DistricList();
            design.cboDistri.Text = dataGridReportes.CurrentRow.Cells["_CIUDAD"].Value.ToString();
            design.txtDirecc.Text = dataGridReportes.CurrentRow.Cells["_EMPDIR"].Value.ToString();
            design.btnNew.Text = "Grabar";
            design.ShowDialog();
            ListProviders("");
        }
    }
}
