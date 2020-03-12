using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class AreaModel
    {
        public List<AreaEntity> ListArea(string condition)
        {
            AreaDao dao = new AreaDao();
            return dao.AreaList(condition);
        }

        public void InsertArea(AreaEntity Insert)
        {
            AreaDao dao = new AreaDao();
            dao.InsertArea(Insert);
        }

        public void UpdatetArea(AreaEntity Update)
        {
            AreaDao dao = new AreaDao();
            dao.UpdatetArea(Update);
        }
        public void DeleteArea(AreaEntity Delete)
        {
            AreaDao dao = new AreaDao();
            dao.DeletetArea(Delete);
        }
    }
}
