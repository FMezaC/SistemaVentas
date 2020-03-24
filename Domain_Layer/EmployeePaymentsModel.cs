using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class EmployeePaymentsModel
    {
        public List<EmployeePaymentEntity> ListPayments(DateTime StarDT, DateTime EndDT)
        {
            EmployeePaymentDao dao = new EmployeePaymentDao();
            return dao.ListPayments(StarDT, EndDT);
        }
    }
}
