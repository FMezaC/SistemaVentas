using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class PayModel
    {
        public void InsertPay(PayEntity Insert)
        {
            PayDao dao = new PayDao();
            dao.RegisterPay(Insert);
        }
    }
}
