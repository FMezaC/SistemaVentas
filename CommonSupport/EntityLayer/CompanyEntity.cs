using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class CompanyEntity
    {
        public int _ID { set; get; }
        public double _NUMRUC {set; get;}
        public string _NOMEMP {set; get;}
        public string _RASOCI {set; get;}
        public string _ACTIVI { set; get; }
        public string _PAIS { set; get; }
        public string _PROVIN { set; get; }
        public string _DISTRI { set; get; }
        public string _DIRECC { set; get; }
        public string _TELEF { set; get; }
        public string _MOVIL { set; get; }
        public string _CORREO { set; get; }
        public byte _PERFIL { set; get; }
    }
}
