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
    public partial class ProductsReport : Form
    {
        private Button CurrentButton;
        private Random random;
        private int temIndex;
        public ProductsReport()
        {
            InitializeComponent();
            random = new Random();
        }

        private void ProductsReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            GetProductReport(fromDate, toDate);
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

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (CurrentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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

        private void GetProductReport(DateTime StarDate, DateTime EndDate)
        {
            ProductsDomainReport ReportDomain = new ProductsDomainReport();
            ReportDomain.CreateProductList(StarDate, EndDate);
            ProductsDomainReportBindingSource.DataSource = ReportDomain;
            ProducListeningBindingSource.DataSource = ReportDomain.ProductList;
            ProductBySalesBindingSource.DataSource = ReportDomain.ProductBySales;
            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            GetProductReport(DateTime.Today, DateTime.Now);
            ActiveButton(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            var StarDate = DateTime.Today.AddDays(-7);
            var EndDate = DateTime.Now;
            GetProductReport(StarDate, EndDate);
            ActiveButton(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            var StarDate =new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var EndDate = DateTime.Now;
            GetProductReport(StarDate, EndDate);
            ActiveButton(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            var StarDate = DateTime.Today.AddDays(-30);
            var EndDate = DateTime.Now;
            GetProductReport(StarDate, EndDate);
            ActiveButton(sender);
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            var StarDate = new DateTime(DateTime.Now.Year, 1, 1);
            var EndDate = DateTime.Now;
            GetProductReport(StarDate, EndDate);
            ActiveButton(sender);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var StarDate = Convert.ToDateTime(dateTimePickerSatart.Value.ToShortDateString());
            var EndDate = dateTimePickerEnd.Value;
            GetProductReport(StarDate, EndDate);
            ActiveButton(sender);
        }
        
    }
}
