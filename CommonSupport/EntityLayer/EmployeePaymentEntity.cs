using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class EmployeePaymentEntity
    {
        public string NUMDOC { set; get; }
        public string EMPLEADO { set; get; }
        public string USUPAG {set; get;}
        public DateTime FECHPA {set; get;}
        public DateTime FECHCO { set; get; }
        public decimal DEUPEN {set; get;}
        public decimal DESCUE {set; get;}
        public decimal BONUSP {set; get;}
        public decimal SALNET {set; get;}
        public double SALARY { set; get; }
    }
}
