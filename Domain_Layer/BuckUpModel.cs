using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain_Layer
{
    public class BuckUpModel
    {
        public void NewBuckUp(string name)
        {
            BuckUpDao dao = new BuckUpDao();
            dao.BuckUp(name);
        }
    }
}
