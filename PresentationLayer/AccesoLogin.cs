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
    public partial class AccesoLogin : Form
    {
        public AccesoLogin()
        {
            InitializeComponent();
        }

        private void btnAccedeer_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                Login();
            }
            catch (Exception)
            {
                lblError.Text = "Error connecting to data base. \nPlease contact to the admin";
                lblError.Visible = true;
            }
        }

        private void Login()
        {
            if (txtUser.Text != "USUARIO" && txtUser.TextLength > 2)
            {
                if (txtPwss.Text != "CONTRASEÑA")
                {
                    UserModel model = new UserModel();
                    var valLogin = model.LoginUser(txtUser.Text, txtPwss.Text);
                    if (valLogin)
                    {
                        MenuPrincipalMDI mainMenu = new MenuPrincipalMDI();
                        this.Hide();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Incorect your user name or password. \n Please try again.");
                        txtPwss.Text = "CONTRASEÑA";
                        txtPwss.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else msgError("Please enter password!");
            }
            else msgError("please enter username!");
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "USUARIO";
            txtPwss.Text = "CONTRASEÑA";
            txtPwss.UseSystemPasswordChar = false;
            lblError.Visible = false;
            this.Show();
        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text=="")
            {
                txtUser.Text = "USUARIO";
            }
        }

        private void txtPwss_Enter(object sender, EventArgs e)
        {
            if (txtPwss.Text== "CONTRASEÑA")
            {
                txtPwss.Text = "";
                txtPwss.UseSystemPasswordChar = true;
            }
        }

        private void txtPwss_Leave(object sender, EventArgs e)
        {
            if (txtPwss.Text=="")
            {
                txtPwss.Text = "CONTRASEÑA";
                txtPwss.UseSystemPasswordChar = false;
            }
        }

        private void labelCirculo1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
