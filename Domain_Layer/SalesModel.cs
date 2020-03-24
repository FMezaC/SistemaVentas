using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class SalesModel
    {
        public int MaxID()
        {
            SalesDao dao = new SalesDao();
            return dao.MaxID();
        }
        public void RegisterSales(SalesEntity Insert)
        {
            SalesDao dao = new SalesDao();
            dao.RegisterSales(Insert);
        }

        public void UpdateSalesState(SalesEntity Update)
        {
            SalesDao dao = new SalesDao();
            dao.UpdateSalesState(Update);
        }
        public List<SalesEntity> AutocompletText()
        {
            SalesDao dao = new SalesDao();
            return dao.AutoComplete();
        }
    }
}
