using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport;
using Domain_Layer;
using CommonSupport.EntityLayer;

namespace PresentationLayer
{
    public partial class ChangePasswordDesign : Form
    {
        public ChangePasswordDesign()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordDesign_Load(object sender, EventArgs e)
        {
            textBox3.Text = UserLoginCache.user;
        }

        private void btnAccedeer_Click(object sender, EventArgs e)
        {
            label5.Text = "Contraseña Incorecta!.";
            UserModel model = new UserModel();
            var valLogin = model.LoginUser(textBox3.Text, textBox1.Text);
            if (valLogin)
            {
                label5.Visible = false;
                UserEntity entity = new UserEntity();
                entity._NUMDNI = UserLoginCache.NumDocum;
                entity._UPASSW = textBox2.Text;
                model.ChangePassword(entity);
                this.Close();
            }
            else
                label5.Visible = true;
        }
    }
}
