using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CommonSupport.EntityDashbordLayer
{
    public class DashboardEntity
    {
        ArrayList _DayName = new ArrayList();
        ArrayList _SalesAmount = new ArrayList();

        ArrayList _WeeksName = new ArrayList();
        ArrayList _SalesByWeeks = new ArrayList();

        public string _CUSTOMER {get; set;}
        public string _PRODUCTS {get; set;}
        public string _BILLIGN  {get; set;}
        public string _SEAT { get; set; }

        public ArrayList DayName
        {
            get
            {
                return _DayName;
            }

            set
            {
                _DayName = value;
            }
        }

        public ArrayList SalesAmount
        {
            get
            {
                return _SalesAmount;
            }

            set
            {
                _SalesAmount = value;
            }
        }

        public ArrayList WeeksName
        {
            get
            {
                return _WeeksName;
            }

            set
            {
                _WeeksName = value;
            }
        }

        public ArrayList SalesByWeeks
        {
            get
            {
                return _SalesByWeeks;
            }

            set
            {
                _SalesByWeeks = value;
            }
        }
    }
}
