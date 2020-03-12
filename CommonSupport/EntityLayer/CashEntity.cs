using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class CashEntity
    {
        public int _NUMARQ { set; get;}
        public string _USUARI { set; get;}
        public DateTime _FCHAPE { set; get;}
        public DateTime _FCHCIE { set; get;}
        public string _TIPMON { set; get;}
        public double _MONAPE { set; get;}
        public double _TOTVEN { set; get;}
        public double _TOTFAC { set; get;}
        public double _TOTCIE { set; get;}
        public double _FALTAN { set; get;}
        public double _SOBRAN { set; get;}
        public string _STATCJ { set; get;}
    }
}
