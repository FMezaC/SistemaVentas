using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class SalesEntity
    {
        public int _IDVENT {set; get;}
        public int _IDCLIE {set; get;}
        public string _IDCAJE {set; get;}
        public DateTime _FECHVE {set; get;}
        public double _SUBTOT { set; get; }
        public double _IGV { set; get; }
        public double _DESCUE {set; get;}
        public double _TOTPAG { set; get; }
        public double _CODPROD { set; get; }
        public string _DESCPROD { set; get; }
    }
}
