using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataReports;
using CommonSupport.EntityDashbordLayer;

namespace Domain_Layer.DomainReports
{
    public class DashboardDomain
    {
        public void DashboardModel(DashboardEntity Entity)
        {
            DashboardDao dao = new DashboardDao();
            dao.DashboardSalesByWeeks(Entity);
            dao.DashboardCashByWeeks(Entity);
        }

        public void CountRegisterBDModel(DashboardEntity Entity)
        {
            DashboardDao dao = new DashboardDao();
            dao.CountRegisterDBDao(Entity);
        }
    }
}
