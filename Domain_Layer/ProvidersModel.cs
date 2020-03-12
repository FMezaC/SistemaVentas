using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class ProvidersModel
    {
        public List<ProviderEntity> ListProviders(string Condition)
        {
            ProviderDao dao = new ProviderDao();
            return dao.ListProviders(Condition);
        }

        public double MaxID(MaxID ID)
        {
            ProviderDao dao = new ProviderDao();
            return dao.MaxID(ID);
        }

        public void InsertProvider(ProviderEntity Insert)
        {
            ProviderDao dao = new ProviderDao();
            dao.InsertProvide(Insert);
        }

        public void UpdateProvider(ProviderEntity Update)
        {
            ProviderDao dao = new ProviderDao();
            dao.UpdateProvider(Update);
        }
    }
}
