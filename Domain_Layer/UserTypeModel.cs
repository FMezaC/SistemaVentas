using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class UserTypeModel
    {
        public List<UserTypeEntity>ListUsers(string condtion)
        {
            UserTypeDao dao = new UserTypeDao();
            return dao.ListUserType(condtion);
        }

        public void InsertUserType(UserTypeEntity Insert)
        {
            UserTypeDao dao = new UserTypeDao();
            dao.InsertUsertType(Insert);
        }

        public void UpdateUserType(UserTypeEntity Update)
        {
            UserTypeDao dao = new UserTypeDao();
            dao.UpdateUsertType(Update);
        }

        public void DeleteUserType(UserTypeEntity Delete)
        {
            UserTypeDao dao = new UserTypeDao();
            dao.DeleteUsertType(Delete);
        }
    }
}
