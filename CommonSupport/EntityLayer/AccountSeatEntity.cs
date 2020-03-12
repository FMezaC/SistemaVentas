using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class AccountSeatEntity
    {
        public int _IDASI { set; get; }
        public string _NUMASI { set; get; }
        public DateTime _FECHA { set; get; }
        public string _NOTA { set; get; }
        public double _TOTDEB { set;get;}
        public double _TOTHAB{set;get;}
        public double _RESTAN{set;get;}
        public int _IDCUENT { set; get; }
        public string _CONCEP { set; get; }
        public string _DETALL { set; get; }
        public string _CUENTA { set; get; }
        public double _DEBE { set; get; }
        public double _HABER { set; get; }
    }
}
