using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class MoneyModel
    {
        public List<MoneyEntity> ListMoney(string conditio)
        {
            MoneyDao dao = new MoneyDao();
            return dao.ListMoney(conditio);
        }
    }
}
