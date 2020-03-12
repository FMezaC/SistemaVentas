using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class MenuItemsEntity
    {
        public int _IDSUBT { set; get; }
        public int _IDMENU { set; get; }
        public int _IDSB_MN { set; get; }
        public int _SUB_IDT { set; get; }
        public string _NOMSBT { set; get; }
        public int _PRIVILEG { set; get; }
        
        // Propiedades de listado
        public string _NUMDOC { set; get; }
        public string _EMPLEA {set; get;}
        public string _TIPUSU {set; get;}
        public string _ESTADO {set; get;}
        public string _USUARI { set; get; }
    }
}
