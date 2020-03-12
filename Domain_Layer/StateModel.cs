using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class StateModel
    {
        public List<StateEntity> ProductStatus(string condition)
        {
            StateDao dao = new StateDao();
            return dao.StateList(condition);
        }
    }
}
