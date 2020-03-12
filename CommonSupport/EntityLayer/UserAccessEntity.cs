using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class UserAccessEntity
    {
        public int _ID { set; get; }
        public int _CODTIP {set; get;}
        public string _TIPO {set; get;}
        public string _PERMISO {set; get;}
        public bool _ACCESO {set; get;}
    }
}
