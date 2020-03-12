using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class CivilStatusModel
    {
        public List<CivilStatusEntity> ListCivil(string condtion)
        {
            CivilStatusDao dao = new CivilStatusDao();
            return dao.ListCivil(condtion);
        }
        public void InsertCivil(CivilStatusEntity Insert)
        {
            CivilStatusDao dao = new CivilStatusDao();
            dao.InsertCivil(Insert);
        }
        public void UpdateCivil(CivilStatusEntity Update)
        {
            CivilStatusDao dao = new CivilStatusDao();
            dao.UpdateCivil(Update);
        }
        public void DeleteCivil(CivilStatusEntity Delete)
        {
            CivilStatusDao dao = new CivilStatusDao();
            dao.DeleteCivil(Delete);
        }
    }
}
