using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class BillingModel
    {
        public void InsertBillig(BillingEntity Insert)
        {
            BillingDao dao = new BillingDao();
            dao.InsertBilling(Insert);
        }

        public void InsertDetailBilling (BillingDetailEntity Insert)
        {
            BillingDao dao = new BillingDao();
            dao.InsertDetailsBilling(Insert);
        }
    }
}
