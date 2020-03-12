using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class UtilityModel
    {
        public List<UtilityEntity> ListUtility(string condition)
        {
            UtilityDao dao = new UtilityDao();
            return dao.ListUtility(condition);
        }
    }
}
