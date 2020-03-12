using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataReports;

namespace Domain_Layer.DomainReports
{
    public class CustumerDomainReports
    {
        public DateTime DateReport { get; private set; }
        public DateTime fromDate { get; private set; }
        public DateTime toDate { get; private set; }
        public double SumTotalSales { get; private set; }
        public List<CustumerListening> Listening { get; private set; }
        public List<CustumerTopPurchase> Top5Custumer { get; private set; }
        public void GetCustomerPurchase(DateTime StarDate, DateTime EndDate)
        {
            DateReport = DateTime.Now;
            fromDate = StarDate;
            toDate = EndDate;
            var CustumerDao = new CustumerDaoReports();
            var result = CustumerDao.CustomerListReport(StarDate, EndDate);
            Listening = new List<CustumerListening>();
            foreach (System.Data.DataRow row in result.Rows)
            {
                var CustumerModel = new CustumerListening()
                {
                    IDCUSTOM = Convert.ToString(row[0]),
                    NAMECUST = Convert.ToString(row[1]),
                    LASTNAME = Convert.ToString(row[2]),
                    CANTPURCH = Convert.ToInt32(row[3]),
                    INCOME = Convert.ToDouble(row[4])
                };
                Listening.Add(CustumerModel);
                SumTotalSales += Convert.ToDouble(row[4]);
            }

            Top5Custumer = (from custom in Listening
                            group custom by new { custom.IDCUSTOM, custom.NAMECUST, custom.CANTPURCH }
                            into Top5Sales
                            select new CustumerTopPurchase
                            {
                                IDCUSTOM = Top5Sales.Key.IDCUSTOM,
                                NAMECUST = Top5Sales.Key.NAMECUST,
                                CANTPSH = Top5Sales.Sum(item => item.CANTPURCH)
                            }).Take(5).ToList();
        }
    }
}
