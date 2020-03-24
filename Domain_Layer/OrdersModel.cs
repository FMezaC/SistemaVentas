using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class OrdersModel
    {
        public double MaxIdCount()
        {
            OrdersDao dao = new OrdersDao();
            return dao.MaxIDCount();
        }

        //public List<OrdersEntity> ListCount(string condition)
        //{
        //    OrdersDao dao = new OrdersDao();
        //    return dao.ListCount(condition);
        //}
    }
}
