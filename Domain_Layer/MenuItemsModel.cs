using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;
using System.Data;
using System.Windows.Forms;

namespace Domain_Layer
{
    public class MenuItemsModel
    {
        public DataView MenuHeader(int idMaster, ToolStripMenuItem ItemHeader, MenuStrip Menu)
        {
            MenuItemsDao dao = new MenuItemsDao();
            return dao.MenuHeader(idMaster, ItemHeader, Menu);
        }
        
        public List<UserPrivilegesEntity> ListPrivilege(string DNI)
        {
            MenuItemsDao dao = new MenuItemsDao();
            return dao.ListPrivileges(DNI);
        }

        public List<UserPrivilegesEntity> Privileges()
        {
            MenuItemsDao dao = new MenuItemsDao();
            return dao.Privileges();
        }

        public List<MenuItemsEntity> ListUserPrivileges(string UserName)
        {
            MenuItemsDao dao = new MenuItemsDao();
            return dao.ListUserPrivileges(UserName);
        }

        public List<UserPrivilegesEntity> FilterUpdate(string NumDoc)
        {
            MenuItemsDao dao = new MenuItemsDao();
            return dao.FilterUpdate(NumDoc);
        }

        public void InsertPrivileges(UserPrivilegesEntity Insert)
        {
            MenuItemsDao dao = new MenuItemsDao();
            dao.InsertPrivileges(Insert);
        }

        public void UpdatePrivileges(UserPrivilegesEntity Update)
        {
            MenuItemsDao dao = new MenuItemsDao();
            dao.UpdatePrivileges(Update);
        }
    }
}
