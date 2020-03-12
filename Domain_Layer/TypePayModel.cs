using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class TypePayModel
    {
        public List<TypePayEntity> ListPay(string condition)
        {
            TypePayDao dao = new TypePayDao();
            return dao.ListPay(condition);
        }
    }
}
