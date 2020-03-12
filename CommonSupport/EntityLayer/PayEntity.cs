using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class PayEntity
    {
        public int _CODPGO {set; get;}
        public int _CODVEN {set; get;}
        public string _TICOMP {set; get;}
        public double _TOTPAG {set; get;}
        public double _MONTOP {set; get;}
        public double _VUELTO {set; get;}
        public double _DEUDAP {set; get;}
        public int _NUMCUO { set; get; }
        public DateTime _FECHPAG { set; get; }
    }
}
