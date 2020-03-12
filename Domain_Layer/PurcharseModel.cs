using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class PurcharseModel
    {
        public void InsertPurcharseModel(PurcharseEntity Entity)
        {
            PurchaseDao dao = new PurchaseDao();
            dao.InsertPurchase(Entity);
        }

        public List<PurcharseEntity>ListPurcharse(DateTime StarDate, DateTime EndDate)
        {
            PurchaseDao dao = new PurchaseDao();
            return dao.ListPurcharse(StarDate, EndDate);
        }
    }
}
