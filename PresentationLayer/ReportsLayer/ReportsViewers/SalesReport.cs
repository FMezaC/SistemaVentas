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
    public partial class SalesReport : Form
    {
        private Button CurrenteButton;
        private Random random;
        private int temIndex;
        public SalesReport()
        {
            InitializeComponent();
            random = new Random();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;

            GetSalesReport(fromDate, toDate);
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (temIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);
            temIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (CurrenteButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    CurrenteButton = (Button)btnsender;
                    CurrenteButton.BackColor = color;
                    CurrenteButton.ForeColor = Color.White;
                    CurrenteButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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

        private void GetSalesReport(DateTime StarDate, DateTime EndDate)
        {
            OrderDomainReports ReportModel = new OrderDomainReports();
            ReportModel.CreateSalesOrderReport(StarDate, EndDate);

            OrderDomainReportsBindingSource.DataSource = ReportModel;
            SalesListeningBindingSource.DataSource = ReportModel.SalesListening;
            NetSalesByPeriodBindingSource.DataSource = ReportModel.NetSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            GetSalesReport(DateTime.Today, DateTime.Now);
            ActiveButton(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;

            GetSalesReport(fromDate, toDate);
            ActiveButton(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;

            GetSalesReport(fromDate, toDate);
            ActiveButton(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;

            GetSalesReport(fromDate, toDate);
            ActiveButton(sender);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;

            GetSalesReport(fromDate, toDate);
            ActiveButton(sender);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(dateTimePickerSatart.Value.ToShortDateString());
            var toDate = dateTimePickerEnd.Value;

            GetSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23,59,59));
            ActiveButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
