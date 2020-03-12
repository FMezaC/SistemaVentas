using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class SalesCancellationsEntity
    {
        public int _IDVENT { set; get; }
        public string _EMPLEA {set; get;}
        public string _CLIENT {set; get;}
        public double _CODPROD { set; get; }
        public string _DESCRI {set; get;}
        public string _ESTADO {set; get;}
        public DateTime _FECHAV {set; get;}
        public int _CANPRO {set; get;}
        public double _PREUNI {set; get;}
        public double _DESCUE {set; get;}
        public double _IMPUES {set; get;}
        public double _SUBTOT {set; get;}
    }
}
