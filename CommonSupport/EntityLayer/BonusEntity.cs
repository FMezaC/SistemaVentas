using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class BonusEntity
    {
        public int _IDBONF { set; get;}
        public string _NUMDOC { set; get;}
        public string _ESTADO { set; get;}
        public string _TIPBON { set; get;}
        public decimal _DESCUE { set; get;}
        public DateTime _FCHINI { set; get;}
        public DateTime _FCHFIN { set; get;}
        public string _USUARI { set; get;}
        public string _TIPBEN { set; get; }

        public string _BENEFI { set; get; }
    }
}
