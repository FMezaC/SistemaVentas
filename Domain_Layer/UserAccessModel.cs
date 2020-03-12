using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class UserAccessModel
    {
        public List<UserAccessEntity> UserAccess(string condition)
        {
            UserAccessDao dao = new UserAccessDao();
            return dao.DataAccessUser(condition);
        }
    }
}
