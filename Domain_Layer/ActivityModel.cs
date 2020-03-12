using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class ActivityModel
    {
        public List<ActivityEntity> ListActivity(string condition)
        {
            ActivityDao dao = new ActivityDao();
            return dao.ListActivity(condition);
        }

        public void InsertActivity(ActivityEntity Insert)
        {
            ActivityDao dao = new ActivityDao();
            dao.InsertActivity(Insert);
        }

        public void Update(ActivityEntity Update)
        {
            ActivityDao dao = new ActivityDao();
            dao.UpdateActivity(Update);
        }

        public void DeleteActivity(ActivityEntity Delete)
        {
            ActivityDao dao = new ActivityDao();
            dao.DeleteActivity(Delete);
        }

        public List<ActivityEntity> FilterActivity(int condition)
        {
            ActivityDao dao = new ActivityDao();
            return dao.FilterActivity(condition);
        }
    }
}
