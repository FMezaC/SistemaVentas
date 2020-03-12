using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class ProvinceModel
    {
        public List<ProvinceEntity> ListProvince(string condition)
        {
            ProvinceDao dao = new ProvinceDao();
            return dao.ListProvinci(condition);
        }

        public List<ProvinceEntity> FilterProvince(int search)
        {
            ProvinceDao dao = new ProvinceDao();
            return dao.FilterProvince(search);
        }

        public void RegistrerProvince(ProvinceEntity entity)
        {
            ProvinceDao dao = new ProvinceDao();
            dao.RegisterProvince(entity);
        }

        public void UpdateProvince(ProvinceEntity Update)
        {
            ProvinceDao dao = new ProvinceDao();
            dao.UpdateProvince(Update);
        }

        public void DeleteProvince(ProvinceEntity Delete)
        {
            ProvinceDao dao = new ProvinceDao();
            dao.DeleteProvince(Delete);
        }
    }
}
