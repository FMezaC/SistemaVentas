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
using CommonSupport;
using Domain_Layer;

namespace PresentationLayer
{
    public partial class UserPrivilegesNewUpdate : Form
    {
        public UserPrivilegesNewUpdate()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PrivilegesVIew()
        {
            MenuItemsModel Privileges = new MenuItemsModel();
            dataGridView1.DataSource = Privileges.Privileges();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.search = "Empleados";
            design.ListDataSearch();
            design.ShowDialog();
            textBox3.Text = "ACTIVO";
            textBox4.Text = design.DNI;
            textBox2.Text = design.DATOS;
            textBox1.Text = design.CODPROD;
            textBox5.Text = design.PRODUC;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (btnNew.Text != "Grabar")
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["_USERDNI"].Value) == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        dataGridView1.Rows[i].Cells["PERMISO"].Value = Convert.ToInt32(checked(true));
                    }
                }
                else
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["_USERDNI"].Value) == 0 )
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!ValidateUser())
            {
                if (btnNew.Text != "Grabar")
                {
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        UserPrivilegesEntity Entity = new UserPrivilegesEntity();
                        Entity._IDSUBT = Convert.ToInt32(rows.Cells["_IDSUBT"].Value);
                        Entity._USERDNI = textBox4.Text;
                        Entity._PERMISO = Convert.ToInt32(rows.Cells["PERMISO"].Value);
                        Entity._NOMSBT = UserLoginCache.user;
                        MenuItemsModel Insert = new MenuItemsModel();
                        Insert.InsertPrivileges(Entity);
                    }
                }
                else
                {
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        UserPrivilegesEntity Entity2 = new UserPrivilegesEntity();
                        Entity2._IDSUBT = Convert.ToInt32(rows.Cells["_ID"].Value);
                        Entity2._PERMISO = Convert.ToInt32(rows.Cells["PERMISO"].Value);
                        Entity2._NOMSBT = UserLoginCache.user;
                        MenuItemsModel Update = new MenuItemsModel();
                        Update.UpdatePrivileges(Entity2);
                    }
                }
                FlaatSlanshDesign design = new FlaatSlanshDesign();
                design.StartPosition = FormStartPosition.CenterScreen;
                design.title = "Guardando Privilegios...";
                design.ShowDialog();
                this.Close();
            }
        }

        private bool ValidateUser()
        {
            MenuItemsModel model = new MenuItemsModel();
            List<MenuItemsEntity> MyList = new List<MenuItemsEntity>();
            MyList = model.ListUserPrivileges("");
            if (textBox2.Text != string.Empty && btnNew.Text != "Grabar")
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    if (MyList[i]._NUMDOC == textBox4.Text)
                    {
                        label7.Text = "Usuario ya Tiene Privilegios Asignados!";
                        label7.Visible = true;
                        return true;
                    }
                    else
                        label7.Visible = false;
                }
            }
            else if(textBox2.Text == string.Empty)
            {
                label7.Text = "Seleccione Usuario Para Asignar Privilegio!";
                label7.Visible = true;
                return true;
            }
            return false;
        }

        public void CargarGrillaPrivilegios(string NumDoc)
        {
            MenuItemsModel model = new MenuItemsModel();
            dataGridView1.DataSource = model.FilterUpdate(NumDoc);
        }

    }
}
