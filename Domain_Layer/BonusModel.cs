using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class BonusModel
    {
        public void InsertBonus(BonusEntity Insert)
        {
            BonusDao dao = new BonusDao();
            dao.InsertBonus(Insert);
        }

        public List<BonusEntity> ListBonusCustomer(string conditions)
        {
            BonusDao dao = new BonusDao();
            return dao.ListBonus(conditions);
        }

        public void UpdateBonus(BonusEntity Update)
        {
            BonusDao dao = new BonusDao();
            dao.UpdateBonificacion(Update);
        }
    }
}
