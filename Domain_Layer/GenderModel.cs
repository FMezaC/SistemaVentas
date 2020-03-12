using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class GenderModel
    {
        public List<GenderEntity> ListGender(string condition)
        {
            GenderDao dao = new GenderDao();
            return dao.GenderList(condition);
        }

        public void InsertGender(GenderEntity Insert)
        {
            GenderDao dao = new GenderDao();
            dao.InsertGender(Insert);
        }

        public void UpdateGender(GenderEntity Update)
        {
            GenderDao dao = new GenderDao();
            dao.UpdateGender(Update);
        }

        public void DeleteGender(GenderEntity Delete)
        {
            GenderDao dao = new GenderDao();
            dao.DeleteGender(Delete);
        }
    }
}
