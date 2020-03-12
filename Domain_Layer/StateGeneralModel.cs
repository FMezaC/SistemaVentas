using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class StateGeneralModel
    {
        public List<StateEntityGeneral> ListState()
        {
            StateGeneralDao dao = new StateGeneralDao();
            return dao.ListEstates();
        }
    }
}
