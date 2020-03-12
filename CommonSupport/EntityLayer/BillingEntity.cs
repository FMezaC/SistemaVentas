using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class BillingEntity
    {
        public int _IDFACT { set; get; }
        public string _TIPFAC { set; get;}
        public DateTime _FCHFAC { set; get;}
        public DateTime _FCHVEN { set; get;}
        public string _BNFDOC { set; get;}
        public string _TIPPAG { set; get;}
        public string _TIPMON { set; get;}
        public string _ESTADO { set; get;}
        public double _SUBTOT { set; get;}
        public double _BONIFI { set; get;}
        public double _IMPUST { set; get;}
        public double _DESCUE { set; get;}
        public double _TOTPAG { set; get;}
        public string _USUARI { set; get;}
    }
}
