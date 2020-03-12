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

namespace PresentationLayer
{
    public partial class CustumerDesign : Form
    {
        public CustumerDesign()
        {
            InitializeComponent();
        }

        private void CustumerDesign_Load(object sender, EventArgs e)
        {
            ListCustumers("");
        }

        private void ListCustumers(string condition)
        {
            CustumerModel cusmod = new CustumerModel();
            dataGridReportes.DataSource = cusmod.CustumerList(condition);
        }

        private void txtbuscarCli_TextChanged(object sender, EventArgs e)
        {
            ListCustumers(txtbuscarCli.Text);
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerNewUpdate Update = new CustomerNewUpdate();
            Update.ID = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["CODCLI"].Value);
            Update.ComboboxList();
            Update.ListPis();
            Update.cboPais.Text = dataGridReportes.CurrentRow.Cells["NOMPAI"].Value.ToString();
            Update.ComboboxProvincia();
            Update.cboProv.Text = dataGridReportes.CurrentRow.Cells["NOMPRO"].Value.ToString();
            Update.ComboboxDistric();
            Update.cboDistri.Text = dataGridReportes.CurrentRow.Cells["DISTRI"].Value.ToString();
            Update.txtNomb.Text = dataGridReportes.CurrentRow.Cells["NOMCLI"].Value.ToString();
            Update.txtApePater.Text = dataGridReportes.CurrentRow.Cells["APEPAT"].Value.ToString();
            Update.txtApeMater.Text = dataGridReportes.CurrentRow.Cells["APEMAT"].Value.ToString();
            Update.cboDoc.Text = dataGridReportes.CurrentRow.Cells["TIPDOC"].Value.ToString();
            Update.txtNumDoc.Text = dataGridReportes.CurrentRow.Cells["NUMDOC"].Value.ToString();
            Update.dtpNacim.Value = Convert.ToDateTime(dataGridReportes.CurrentRow.Cells["FCHANA"].Value.ToString());
            Update.txtCorreo.Text = dataGridReportes.CurrentRow.Cells["CORREO"].Value.ToString();
            Update.cboGenero.Text = dataGridReportes.CurrentRow.Cells["GENERO"].Value.ToString();
            Update.cboEstdCivil.Text = dataGridReportes.CurrentRow.Cells["ESTCIVIL"].Value.ToString();
            Update.txtNumCel.Text = dataGridReportes.CurrentRow.Cells["NUMCEL"].Value.ToString();
            Update.txtocupass.Text = dataGridReportes.CurrentRow.Cells["OCUPAS"].Value.ToString();
            Update.txtDirecc.Text = dataGridReportes.CurrentRow.Cells["DIRECCION"].Value.ToString();
            Update.StartPosition = FormStartPosition.CenterScreen;
            Update.btnNew.Text = "Grabar";
            Update.txtNumDoc.Enabled = false;
            Update.cboDoc.Enabled = false;
            Update.ShowDialog();
            ListCustumers("");
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CustomerNewUpdate newUpda = new CustomerNewUpdate();
            newUpda.StartPosition = FormStartPosition.CenterScreen;
            newUpda.ComboboxList();
            newUpda.ListPis();
            newUpda.btnNew.Text = "Registrar";
            newUpda.ShowDialog();
            ListCustumers("");
        }
    }
}
