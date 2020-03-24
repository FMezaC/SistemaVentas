using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class BranchOfficeModel
    {
        public List<BranchOfficeEntity> ListBranch()
        {
            BranchOfficeDao dao = new BranchOfficeDao();
            return dao.ListBranch();
        }
    }
}
