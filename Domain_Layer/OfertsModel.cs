using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class OfertsModel
    {
        public List<OfertsEntity> ListOferts(string condition)
        {
            OfertsDao dao = new OfertsDao();
            return dao.ListOferts(condition);
        }

        public int NewID()
        {
            OfertsDao dao = new OfertsDao();
            return dao.MaxID();
        }

        public void InsertNewOfert(OfertsEntity Insert)
        {
            OfertsDao dao = new OfertsDao();
            dao.NewOfert(Insert);
        }

        public void UpdateOfert(OfertsEntity Update)
        {
            OfertsDao dao = new OfertsDao();
            dao.UpdateOfert(Update);
        }
    }
}
