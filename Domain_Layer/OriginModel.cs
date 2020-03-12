using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class OriginModel
    {
        public List<OriginEntity>OriginList(string Condition)
        {
            OriginDao dao = new OriginDao();
            return dao.ListOrigin(Condition);
        }
    }
}
