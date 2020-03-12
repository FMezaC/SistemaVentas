using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class BillingTypeModel
    {
        public List<BillingTypeEntity> ListBillingType(string ID)
        {
            BillingTypeDao dao = new BillingTypeDao();
            return dao.ListBillingType(ID);
        }
    }
}
