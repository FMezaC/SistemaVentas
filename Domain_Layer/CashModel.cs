using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class CashModel
    {
        public void CashOpeninModel(CashEntity Entity)
        {
            CashDao dao = new CashDao();
            dao.CashOpening(Entity);
        }

        public void CashDataModel(CashOutputEntity OutPut)
        {
            CashDao dao = new CashDao();
            dao.CashDataShow(OutPut);
        }

        public bool ValidateCashModel()
        {
            CashDao dao = new CashDao();
            return dao.ValidateCashDao();
        }

        public void UpdateCashModel(CashEntity Update)
        {
            CashDao dao = new CashDao();
            dao.UpdateCash(Update);
        }

        public void UpdateSalesModel()
        {
            CashDao dao = new CashDao();
            dao.UpdateSales();
        }

        public void UpdateBillingModel()
        {
            CashDao dao = new CashDao();
            dao.UpdateBilling();
        }
    }
}
