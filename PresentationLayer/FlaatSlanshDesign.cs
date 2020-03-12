using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FlaatSlanshDesign : Form
    {
        public FlaatSlanshDesign()
        {
            InitializeComponent();
        }

        public string title;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Width += 10;
            label1.Text = title.ToUpper();
            if (label3.Width >= 295)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
