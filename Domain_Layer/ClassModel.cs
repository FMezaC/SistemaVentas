using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class ClassModel
    {
        public List<ClassEntity> MyClassProduct(string condition)
        {
            ClassDao dao = new ClassDao();
            return dao.ListClass(condition);
        }

        public string NuevoCod(MaxID obj)
        {
            ClassDao dao = new ClassDao();
            return dao.NuevoCod(obj);
        }

        public void InsertClass(ClassEntity Entity)
        {
            ClassDao dao = new ClassDao();
            dao.InsertClass(Entity);
        }

        public void UpdateClass(ClassEntity Update)
        {
            ClassDao dao = new ClassDao();
            dao.UpdateClass(Update);
        }

        public void DeleteClass(ClassEntity Delete)
        {
            ClassDao dao = new ClassDao();
            dao.DeleteClass(Delete);
        }

        public List<ClassEntity> FIlterClass(int condition)
        {
            ClassDao dao = new ClassDao();
            return dao.FIlterClass(condition);
        }
    }
}
