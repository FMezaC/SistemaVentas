using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class MesuareModel
    {
        public List<MesuareEntity> ListMesuare(string condition)
        {
            MesuareDao dao = new MesuareDao();
            return dao.ListMesuare(condition);
        }

        public void InsertMesuare(MesuareEntity Insert)
        {
            MesuareDao dao = new MesuareDao();
            dao.InsertMesuare(Insert);
        }

        public void UpdateMesuare(MesuareEntity Update)
        {
            MesuareDao dao = new MesuareDao();
            dao.UpdateMesuare(Update);
        }

        public void DeleteMesuare(MesuareEntity Delete)
        {
            MesuareDao dao = new MesuareDao();
            dao.DeleteMesuare(Delete);
        }
    }
}
