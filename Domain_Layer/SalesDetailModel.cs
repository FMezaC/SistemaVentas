using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class SalesDetailModel
    {
        public void InsertSalesDatail(DetailSalesEntity Insert)
        {
            SalesDetailDao dao = new SalesDetailDao();
            dao.IsertSalesDatail(Insert);
        }

        public List<DetailSalesEntity> ListDetail(int ID)
        {
            SalesDetailDao dao = new SalesDetailDao();
            return dao.ListDetail(ID);
        }
    }
}
