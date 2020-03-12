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
    public partial class UserPrivilegesDesign : Form
    {
        public UserPrivilegesDesign()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserPrivilegesNewUpdate NewUpdate = new UserPrivilegesNewUpdate();
            NewUpdate.StartPosition = FormStartPosition.CenterScreen;
            NewUpdate.PrivilegesVIew();
            NewUpdate.ShowDialog();
            LoadDataUserAcceses("");
            txtBuscar.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPrivilegesDesign_Load(object sender, EventArgs e)
        {
            LoadDataUserAcceses("");
        }

        private void LoadDataUserAcceses(string UserName)
        {
            MenuItemsModel model = new MenuItemsModel();
            dataGridReportes.DataSource = model.ListUserPrivileges(UserName);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadDataUserAcceses(txtBuscar.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserPrivilegesNewUpdate userNewUp = new UserPrivilegesNewUpdate();
            userNewUp.StartPosition = FormStartPosition.CenterScreen;
            userNewUp.btnNew.Text = "Grabar";
            userNewUp.textBox2.Text = dataGridReportes.CurrentRow.Cells["_EMPLEA"].Value.ToString();
            userNewUp.textBox5.Text = dataGridReportes.CurrentRow.Cells["_TIPUSU"].Value.ToString();
            userNewUp.textBox4.Text = dataGridReportes.CurrentRow.Cells["_NUMDOC"].Value.ToString();
            userNewUp.textBox3.Text = "ACTIVO";
            userNewUp.textBox1.Text = dataGridReportes.CurrentRow.Cells["_USUARI"].Value.ToString();
            userNewUp.pictureBox2.Enabled = false;
            userNewUp.CargarGrillaPrivilegios(dataGridReportes.CurrentRow.Cells["_NUMDOC"].Value.ToString());
            userNewUp.ShowDialog();
            LoadDataUserAcceses("");
            txtBuscar.Clear();
        }
    }
}
