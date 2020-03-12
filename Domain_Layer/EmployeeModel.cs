using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CommonSupport.EntityLayer;

namespace Domain_Layer
{
    public class EmployeeModel
    {
        public List<EmployeesEntity> ListEmployee(string condition)
        {
            EmployeesDao dao = new EmployeesDao();
            return dao.ListEmployee(condition);
        }

        public void InsertEmployees(EmployeesEntity Insert)
        {
            EmployeesDao dao = new EmployeesDao();
            dao.InsertEmployees(Insert);
        }

        public void UpdateEmployees(EmployeesEntity Update)
        {
            EmployeesDao dao = new EmployeesDao();
            dao.UpdateEmployees(Update);
        }

        public void DeleteEmployee(EmployeesEntity Delete)
        {
            EmployeesDao dao = new EmployeesDao();
            dao.DeleteEmployees(Delete);
        }
    }
}
