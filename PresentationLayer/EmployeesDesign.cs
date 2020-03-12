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
    public partial class EmployeesDesign : Form
    {
        public EmployeesDesign()
        {
            InitializeComponent();
        }

        private void EmployeesDesign_Load(object sender, EventArgs e)
        {
            ListEmployees("");
        }

        private void ListEmployees(string condition)
        {
            EmployeeModel model = new EmployeeModel();
            dataGridReportes.DataSource = model.ListEmployee(condition);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            EmployeeModel model = new EmployeeModel();
            dataGridReportes.DataSource = model.ListEmployee(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmployeesUpdateNew model = new EmployeesUpdateNew();
            model.StartPosition = FormStartPosition.CenterScreen;
            model.ListPais();
            model.Genero();
            model.CivilStatus();
            model.TipDocuemt();
            model.TipUser();
            model.ShowDialog();
            ListEmployees("");
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeesUpdateNew design = new EmployeesUpdateNew();
            design.ListPais();
            design.cboPais.Text = dataGridReportes.CurrentRow.Cells["_PAIS"].Value.ToString();
            design.ComboboxProvincia();
            design.cboProv.Text = dataGridReportes.CurrentRow.Cells["_PROVIN"].Value.ToString();
            design.TipDocuemt();
            design.cboDoc.Text = dataGridReportes.CurrentRow.Cells["_IDTIPD"].Value.ToString();
            design.txtNumDoc.Text = dataGridReportes.CurrentRow.Cells["_NUMDOC"].Value.ToString();
            design.txtNomb.Text = dataGridReportes.CurrentRow.Cells["_NOMEMP"].Value.ToString();
            design.txtApePater.Text = dataGridReportes.CurrentRow.Cells["_APEPAT"].Value.ToString();
            design.txtApeMater.Text = dataGridReportes.CurrentRow.Cells["_APEMAT"].Value.ToString();
            design.dtpNacim.Text = dataGridReportes.CurrentRow.Cells["_FECHNA"].Value.ToString();
            design.dtpFechContr.Text = dataGridReportes.CurrentRow.Cells["_FECHCO"].Value.ToString();
            design.Genero();
            design.cboGenero.Text = dataGridReportes.CurrentRow.Cells["_IDGENE"].Value.ToString();
            design.txtDirecc.Text = dataGridReportes.CurrentRow.Cells["_DIRECC"].Value.ToString();
            design.ComboboxDistric();
            design.cboDistri.Text = dataGridReportes.CurrentRow.Cells["_DISTRIT"].Value.ToString();
            design.CivilStatus();
            design.cboEstdCivil.Text = dataGridReportes.CurrentRow.Cells["_IDESTC"].Value.ToString();
            design.txtNumCel.Text = dataGridReportes.CurrentRow.Cells["_NUMCEL"].Value.ToString();
            design.txtCorreo.Text = dataGridReportes.CurrentRow.Cells["_CORREO"].Value.ToString();
            design.NumeHij.Value = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_NUMHIJ"].Value);
            design.TipUser();
            design.cboTipUser.Text = dataGridReportes.CurrentRow.Cells["_TIPUSER"].Value.ToString();
            design.textBox1.Text = dataGridReportes.CurrentRow.Cells["_USUARIO"].Value.ToString();
            design.textBox2.Text = dataGridReportes.CurrentRow.Cells["_UPASSW"].Value.ToString();
            design.txtSalario.Text = dataGridReportes.CurrentRow.Cells["_SALARI"].Value.ToString();
            design.ID = Convert.ToInt32(dataGridReportes.CurrentRow.Cells["_CODEMP"].Value);
            design.btnNew.Text = "Grabar";
            design.StartPosition = FormStartPosition.CenterScreen;
            design.textBox2.Enabled = false;
            design.ShowDialog();
            ListEmployees("");
        }
    }
}
