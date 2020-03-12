using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class OfertsEntity
    {
        public double _CODPROD { set; get;}
        public string _DESCPRO { set; get; }
        public string _ESTADO { set; get; }
        public string _LINEA { set; get; }
        public string _UMSTOCK { set; get; }
        public string _CODBARR { set; get; }
        public string _TIPODESCT { set; get; }
        public DateTime _FECHIICIO { set; get; }
        public DateTime _FECHFINAL { set; get; }
        public int _CANTPRO { set; get; }
        public decimal _DESCUENTO { set; get; }
        public decimal _PREUNIT { set; get; }

        public int _ID {set; get;}
        public string _USUARIO { set; get; }
    }
}
