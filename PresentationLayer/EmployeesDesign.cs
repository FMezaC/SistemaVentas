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
using FuntionalLayer;

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
            statusStrip1.Cursor = Cursors.Hand;
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
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            EmployeesUpdateNew model = new EmployeesUpdateNew();
            model.StartPosition = FormStartPosition.CenterScreen;
            model.ListPais();
            model.Genero();
            model.CivilStatus();
            model.TipDocuemt();
            model.TipUser();
            model.BranchList();
            model.ShowDialog();
            ListEmployees("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            design.BranchList();
            design.comboBox1.Text = dataGridReportes.CurrentRow.Cells["_SUCUR"].Value.ToString();
            design.btnNew.Text = "Grabar";
            design.StartPosition = FormStartPosition.CenterScreen;
            design.textBox2.Enabled = false;
            design.ShowDialog();
            ListEmployees("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DownloandExcelFuntion function = new DownloandExcelFuntion();
            ConvertListToDataTable convert = new ConvertListToDataTable();
            EmployeeModel model = new EmployeeModel();
            DataTable table = convert.ToDataTable(model.ListEmployee(txtBuscar.Text));
            string appPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            function.BuildExcel(table, appPath + @"-Empleados.xlsx");
            //Lamar al backgroundWorker
            FlaatSlanshDesign desing = new FlaatSlanshDesign();
            desing.StartPosition = FormStartPosition.CenterScreen;
            desing.showAlert("Descarga Exitosa...", FlaatSlanshDesign.enmType.Success);
        }
    }
}
