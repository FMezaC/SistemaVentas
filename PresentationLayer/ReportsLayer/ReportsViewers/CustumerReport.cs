using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain_Layer.DomainReports;
using FuntionalLayer;

namespace PresentationLayer.ReportsLayer.ReportsViewers
{
    public partial class CustumerReport : Form
    {
        private static Button Currentbutton;
        private static Random random;
        private int tempIndex;
        public CustumerReport()
        {
            InitializeComponent();
            random = new Random();
        }
        
        private void CustumerReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            CustomerList(DateTime.Today, DateTime.Now);
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (Currentbutton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    Currentbutton = (Button)btnSender;
                    Currentbutton.BackColor = color;
                    Currentbutton.ForeColor = Color.White;
                    Currentbutton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control itemBtn in panel1.Controls)
            {
                if (itemBtn.GetType() == typeof(Button))
                {
                    itemBtn.BackColor = Color.Empty;
                    itemBtn.ForeColor = Color.White;
                    itemBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }

            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.BackColor = Color.Empty;
                    item.ForeColor = Color.White;
                    item.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CustomerList(DateTime StarDate, DateTime EndDate)
        {
            CustumerDomainReports model = new CustumerDomainReports();
            model.GetCustomerPurchase(StarDate, EndDate);
            CustumerDomainReportsBindingSource.DataSource = model;
            CustumerListeningBindingSource.DataSource = model.Listening;
            CustumerTopPurchaseBindingSource.DataSource = model.Top5Custumer;
            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            CustomerList(DateTime.Today, DateTime.Now);
            ActiveButton(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Now.AddDays(-7);
            var ToDate = DateTime.Now;
            CustomerList(fromDate, ToDate);
            ActiveButton(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var ToDate = DateTime.Now;
            CustomerList(fromDate, ToDate);
            ActiveButton(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Now.AddDays(-30);
            var ToDate = DateTime.Now;
            CustomerList(fromDate, ToDate);
            ActiveButton(sender);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var ToDate = DateTime.Now;
            CustomerList(fromDate, ToDate);
            ActiveButton(sender);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(dateTimePickerSatart.Value.ToShortDateString());
            var ToDate = dateTimePickerEnd.Value;
            CustomerList(fromDate, ToDate);
            ActiveButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
