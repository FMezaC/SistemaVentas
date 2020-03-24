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
    public partial class CreditNoteDeign : Form
    {
        public CreditNoteDeign()
        {
            InitializeComponent();
        }

        private void CreditNoteDeign_Load(object sender, EventArgs e)
        {
            Remitente();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ID;
        private void Remitente()
        {
            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            int contador = MyList.Count;
            for (int i = 0; i < contador; i++)
            {
                textBox4.Text = Convert.ToString(MyList[i]._NUMRUC);
                textBox1.Text = MyList[i]._NOMEMP;
                textBox6.Text = MyList[i]._RASOCI;
                textBox7.Text = MyList[i]._DIRECC;
            }
        }
    }
}
