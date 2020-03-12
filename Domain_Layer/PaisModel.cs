using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class PaisModel
    {
        public List<PaisEntity> ListPais(string condition)
        {
            PaisDao dao = new PaisDao();
            return dao.ListaPais(condition);
        }

        public void RegisterPais(PaisEntity Entity)
        {
            PaisDao dao = new PaisDao();
            dao.RegisterPais(Entity);
        }

        public void UpdatePais(PaisEntity Update)
        {
            PaisDao dao = new PaisDao();
            dao.UpdatePais(Update);
        }

        public void DeletePais(PaisEntity Delete)
        {
            PaisDao dao = new PaisDao();
            dao.DeletePais(Delete);
        }
    }
}
