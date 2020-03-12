using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class CustumerModel
    {
        public List<CustumerEntity> CustumerList(string condition)
        {
            CustumerDao dao = new CustumerDao();
            return dao.ListCustumer(condition);
        }

        public void InsertCustrumer(CustumerEntity Insert)
        {
            CustumerDao dao = new CustumerDao();
            dao.InsertCustumer(Insert);
        }

        public void UpdateCustomer(CustumerEntity Update)
        {
            CustumerDao dao = new CustumerDao();
            dao.UpdateCustumer(Update);
        }
    }
}
