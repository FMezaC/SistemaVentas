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
using CommonSupport;
using CommonSupport.EntityLayer;

namespace PresentationLayer
{
    public partial class BuckUps : Form
    {
        public BuckUps()
        {
            InitializeComponent();
        }
        
        private void BuckUps_Load(object sender, EventArgs e)
        {
            textBox1.Text = UserLoginCache.user;
        }

        private void btnAccedeer_Click(object sender, EventArgs e)
        {
            string CompName = "";
            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            int cont = MyList.Count;
            for (int i = 0; i < cont; i++)
            {
                CompName = MyList[i]._NOMEMP;
            }
            string NombreCopia = CompName + "-" + DateTime.Today.Day.ToString() + "-" +
                DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" +
                DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            UserModel model2 = new UserModel();
            var valLogin = model2.LoginUser(textBox1.Text, textBox2.Text);
            if (valLogin)
            {
                BuckUpModel BModel = new BuckUpModel();
                BModel.NewBuckUp(NombreCopia);

                FlaatSlanshDesign design = new FlaatSlanshDesign();
                design.title = "Generando copia de seguridad";
                design.StartPosition = FormStartPosition.CenterScreen;
                design.ShowDialog();
                this.Close();
            }
            else
            {
                label5.Text = "Contraseña Incorecta!";
                label5.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog brows = new FolderBrowserDialog();
        //    if (brows.ShowDialog() == DialogResult.OK)
        //    {
        //        Ubicacion_Bak = brows.SelectedPath;
        //    }
        //    textBox3.Text = Ubicacion_Bak + "\\";
        //}
    }
}
