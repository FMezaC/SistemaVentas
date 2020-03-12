using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class ChartCountModel
    {
        public List<ChartCountEntity> ListCount(string condition)
        {
            ChartCountDao dao = new ChartCountDao();
            return dao.ListCounts(condition);
        }

        public void InsertCount(ChartCountEntity Insert)
        {
            ChartCountDao dao = new ChartCountDao();
            dao.InsertCount(Insert);
        }

        public void UpdateCount(ChartCountEntity Update)
        {
            ChartCountDao dao = new ChartCountDao();
            dao.UpdateCount(Update);
        }

        public void DeleteCount(ChartCountEntity Delete)
        {
            ChartCountDao dao = new ChartCountDao();
            dao.DeleteCount(Delete);
        }

        public List<ChartCountEntity> Filter(string condition)
        {
            ChartCountDao dao = new ChartCountDao();
            return dao.Filter(condition);
        }
    }
}
