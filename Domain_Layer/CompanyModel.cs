using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class CompanyModel
    {
        public List<CompanyEntity> ListCompany()
        {
            CompanyDao dao = new CompanyDao();
            return dao.ListCompany();
        }

        public void UpdateCompany(CompanyEntity Update)
        {
            CompanyDao dao = new CompanyDao();
            dao.UpdateCompany(Update);
        }
    }
}
