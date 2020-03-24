using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class AccountSeatModel
    {
        public void InsertASI(AccountSeatEntity Insert)
        {
            AccountSeatDao dao = new AccountSeatDao();
            dao.InsertASI(Insert);
        }

        public int MaxID()
        {
            AccountSeatDao dao = new AccountSeatDao();
            return dao.MaxID();
        }

        public List<AccountSeatEntity> ListAccoun(DateTime fech1, DateTime fech2)
        {
            AccountSeatDao dao = new AccountSeatDao();
            return dao.ListAccount(fech1, fech2);
        }

        public void UpdateASI(AccountSeatEntity Update)
        {
            AccountSeatDao dao = new AccountSeatDao();
            dao.UpdateASI(Update);
        }
    }
}
