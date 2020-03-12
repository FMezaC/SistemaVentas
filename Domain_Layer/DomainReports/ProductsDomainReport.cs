using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataReports;

namespace Domain_Layer.DomainReports
{
    public class ProductsDomainReport
    {
        public DateTime ReportDate { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        ///public List<ProductByStock> ProductByStock { get; private set; }
        public List<ProducListening> ProductList { get; private set; }
        public List<ProductBySales> ProductBySales { get; private set; }
        public double TotalNetSales { get; private set; }
        public void CreateProductList(DateTime StarDate, DateTime EndDate)
        {
            ReportDate = DateTime.Now;
            FromDate = StarDate;
            ToDate = EndDate;

            var ProductDao = new ProductDaoReport();
            var Result = ProductDao.ListProductSales(StarDate, EndDate);
            ProductList = new List<ProducListening>();
            foreach (System.Data.DataRow rows in Result.Rows)
            {
                var ProductModel = new ProducListening()
                {
                    CODPROD = Convert.ToString(rows[0]),
                    DESCPRO = Convert.ToString(rows[1]),
                    IGV = Convert.ToDouble(rows[2]),
                    PREUNIT = Convert.ToDouble(rows[3]),
                    CANTPRO = Convert.ToInt32(rows[4]),
                    INGRESOS = Convert.ToDouble(rows[5])
                };
                ProductList.Add(ProductModel);
                TotalNetSales += Convert.ToDouble(rows[5]);
            }

            //ProductByStock = (from Stock in ProductList
            //                    where Stock.CANTPRO < 5
            //                    group Stock by Stock.CANTPRO
            //                    into NotStock
            //                    select new ProductByStock
            //                    {
            //                        CANTPROD = Convert.ToString("Disponible "+ NotStock.Key),
            //                        TOTAL = NotStock.Sum(item => item.CANTPRO)
            //                    }).ToList();


            ProductBySales = (from Sales in ProductList
                              orderby Sales.CANTPRO descending
                              group Sales by new { Sales.CODPROD, Sales.DESCPRO, Sales.CANTPRO }
                              into MinSales
                              select new ProductBySales
                              {
                                  CODPROD = MinSales.Key.CODPROD,
                                  DESCRPROD = MinSales.Key.DESCPRO,
                                  CANTPROD = MinSales.Sum(item => item.CANTPRO)
                              }).Take(5).ToList();
        }
    }
}
