using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class AccountSeatDetModel
    {
        public void InsertDet(AccountSeatDetEntity Insert)
        {
            AccountSeatDetDao dao = new AccountSeatDetDao();
            dao.InsertDET(Insert);
        }

        public List<AccountSeatDetEntity> LisDetall(int IDASI)
        {
            AccountSeatDetDao dao = new AccountSeatDetDao();
            return dao.ListDtall(IDASI);
        }

        public void UpdateDET(AccountSeatDetEntity Update)
        {
            AccountSeatDetDao dao = new AccountSeatDetDao();
            dao.UpdateDET(Update);
        }
    }
}
