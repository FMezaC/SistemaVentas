using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class LineModel
    {
        public List<LineEntity> MyList(string condition)
        {
            LineDao dao = new LineDao();
            return dao.LineList(condition);
        }

        public double NewID ()
        {
            LineDao dao = new LineDao();
            return dao.NewID();
        }

        public void InsertLine(LineEntity Insert)
        {
            LineDao dao = new LineDao();
            dao.InsertLine(Insert);
        }

        public void UpdateLine(LineEntity Update)
        {
            LineDao dao = new LineDao();
            dao.UpdateLine(Update);
        }

        public void DeleteLine(LineEntity Delete)
        {
            LineDao dao = new LineDao();
            dao.DeleteLine(Delete);
        }
    }
}
