using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class DistricModel
    {
        public List<DistricEntity> ListDistric(string condition)
        {
            DistricDao dao = new DistricDao();
            return dao.ListDistric(condition);
        }

        public void InsertDistric(DistricEntity Insert)
        {
            DistricDao dao = new DistricDao();
            dao.RegisterDistric(Insert);
        }

        public void UpdateDistric(DistricEntity Update)
        {
            DistricDao dao = new DistricDao();
            dao.UpdateDistric(Update);
        }

        public void DeleteDistric(DistricEntity Delete)
        {
            DistricDao dao = new DistricDao();
            dao.DeleteDistric(Delete);
        }

        public List<DistricEntity> FilterDistric(int condition)
        {
            DistricDao dao = new DistricDao();
            return dao.FilterDistric(condition);
        }
    }
}
