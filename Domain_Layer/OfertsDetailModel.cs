using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class OfertsDetailModel
    {
        public void NewDatilOfert(OfertsDetailEntity Insert)
        {
            OfertsDetailDao dao = new OfertsDetailDao();
            dao.InsertOfertDetail(Insert);
        }

        public List<OfertsDetailEntity> ListOfert(int ID)
        {
            OfertsDetailDao dao = new OfertsDetailDao();
            return dao.ListDetailOfert(ID);
        }

        public void DeleteDetailOfert(int ID)
        {
            OfertsDetailDao dao = new OfertsDetailDao();
            dao.DeleteDetailOfert(ID);
        }
    }
}
