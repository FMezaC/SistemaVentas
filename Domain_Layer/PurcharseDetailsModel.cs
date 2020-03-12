using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class PurcharseDetailsModel
    {
        public void InsertPurchaseDetailsModel(PurcharseDetailsEntity Entity)
        {
            PurcharseDetailsDao dao = new PurcharseDetailsDao();
            dao.InsetPurcharseDetail(Entity);
        }
    }
}
