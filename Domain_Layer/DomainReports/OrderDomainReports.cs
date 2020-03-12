using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataReports;

namespace Domain_Layer.DomainReports
{
    public class OrderDomainReports
    {
        public DateTime ReportDate { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<SalesListening> SalesListening { get; private set; }
        public List<NetSalesByPeriod> NetSalesByPeriod { get; private set; }
        public double TotalNetSales { get; private set; }

        // NetBods
        public void CreateSalesOrderReport(DateTime fromDATE, DateTime ToDATE)
        {
            // Implement dates
            ReportDate = DateTime.Now;
            StartDate = fromDATE;
            EndDate = ToDATE;
            // Create Sales Listening
            var orderDao = new OrderDaoReport();
            var result = orderDao.GetSalesOrder(fromDATE, ToDATE);
            SalesListening = new List<SalesListening>();
            foreach (System.Data.DataRow ResultRows in result.Rows)
            {
                var SalesModel = new SalesListening()
                {
                    codprod = Convert.ToString(ResultRows[0]),
                    DescProd = Convert.ToString(ResultRows[1]),
                    Fech_Vent = Convert.ToDateTime(ResultRows[2]),
                    Impuet = Convert.ToDouble(ResultRows[3]),
                    PreUnit = Convert.ToDouble(ResultRows[4]),
                    CantVend = Convert.ToInt32(ResultRows[5]),
                    TotVent = Convert.ToDouble(ResultRows[6])
                };
                SalesListening.Add(SalesModel);

                // Calulate Total Net Sales
                TotalNetSales += Convert.ToDouble(ResultRows[6]);
            }

            // create net sales by period
            // create temp list net sales by date
            var ListSalesByDate = (from sales in SalesListening
                                   group sales by sales.Fech_Vent
                                   into ListSales
                                   select new
                                   {
                                       date = ListSales.Key,
                                       amount = ListSales.Sum(item => item.TotVent)
                                   }).AsEnumerable();
            // get numbers of days
            int TotalDays = Convert.ToInt32((ToDATE - fromDATE).Days);

            // group period by day
            if (TotalDays <= 7)
            {
                NetSalesByPeriod = (from sales in ListSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Period = listSales.Key,
                                        NetSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            // group period by weeks
            else if (TotalDays <= 30)
            {
                NetSalesByPeriod = (from sales in ListSalesByDate
                                    group sales by System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Period = "Semana: " + listSales.Key.ToString(),
                                        NetSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            // group period by month
            else if (TotalDays <= 365)
            {
                NetSalesByPeriod = (from sales in ListSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Period = listSales.Key,
                                        NetSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            // Group period by yeard
            else
            {
                NetSalesByPeriod = (from sales in ListSalesByDate
                                    group sales by sales.date.ToString("yyyy")
                                into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Period = listSales.Key,
                                        NetSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
        }
        
    }
}
