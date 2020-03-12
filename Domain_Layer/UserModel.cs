using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class UserModel
    {
        

        public bool LoginUser(string user, string passw)
        {
            UserDao userDao = new UserDao();
            return userDao.Login(user, passw);
        }

        public void InsertUser(UserEntity Insert)
        {
            UserDao dao = new UserDao();
            dao.InsertUser(Insert);
        }

        public void UpdateUsertType(UserEntity UpdateType)
        {
            UserDao dao = new UserDao();
            dao.UpdateType(UpdateType);
        }

        public void ChangePassword(UserEntity ChangePass)
        {
            UserDao dao = new UserDao();
            dao.UpdatePassword(ChangePass);
        }
    }
}
