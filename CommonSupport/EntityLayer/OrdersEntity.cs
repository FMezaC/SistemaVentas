using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class OrdersEntity
    {
        public int IDCUENT { set; get;}
        public string NUMCUEN { set; get;}
        public string NOMBUSU { set; get;}
        public int NUMDOCU { set; get;}
        public string ENTIDAD { set; get;}
        public string TIPCUEN { set; get;}
        public string TIPTARJ { set; get;}
        public int CODIUCV { set; get;}
        public DateTime FCHAPER { set; get;}
        public DateTime FCHCADU { set; get; }
    }
}
