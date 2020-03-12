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
    public partial class AboutDesign : Form
    {
        public AboutDesign()
        {
            InitializeComponent();
        }

        private void labelCirculo1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutDesign_Load(object sender, EventArgs e)
        {
            ListAutorization();
        }

        private void ListAutorization()
        {
            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            int condtador = MyList.Count;
            for (int i = 0; i < condtador; i++)
            {
                label6.Text = MyList[i]._NOMEMP;
            }
        }
    }
}
