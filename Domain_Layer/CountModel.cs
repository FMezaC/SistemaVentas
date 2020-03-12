using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class CountModel
    {
        public double MaxIdCount(MaxID ID)
        {
            CountDao dao = new CountDao();
            return dao.MaxIDCount(ID);
        }

        public List<CountEntity> ListCount(string condition)
        {
            CountDao dao = new CountDao();
            return dao.ListCount(condition);
        }
    }
}
