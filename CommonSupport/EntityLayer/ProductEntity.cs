using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class ProductEntity
    {
        public double _CODPROD { set; get; }
        public string _DESCPRO { set; get;}
        public string _PROCEDENCIA { set; get; }
        public string _CODBARR { set; get; }
        public string _UMSTOCK { set; get; }
        public double _VOLPROD { set; get; }
        public string _CODEST { set; get; }
        public DateTime _FECHVEN { set; get; }
        public DateTime _FECHPROD { set; get; }
        public string _CODLINE { set; get; }
        public string _CODCLASS { set; get; }
        public double _CANTRES { set; get; }
        public decimal _PREUNIT { set; get; }
        public string _FACTOR { set; get; }
        public int _CANTPRO { set; get; }
        public int _UNIDADES { set; get; }
        public decimal _IMPUEST { set; get; }
    }
}
