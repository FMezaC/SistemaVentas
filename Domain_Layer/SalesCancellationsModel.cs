using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class SalesCancellationsModel
    {
        public List<SalesCancellationsEntity> ListSales(DateTime fch01, DateTime fch02, string cadena)
        {
            SalesCancellationsDao dao = new SalesCancellationsDao();
            return dao.ListSales(fch01, fch02, cadena);
        }
    }
}
