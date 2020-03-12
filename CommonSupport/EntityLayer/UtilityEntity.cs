using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class UtilityEntity
    {
        public int _IDCAJA { set; get; }
        public int _IDREVL {set; get;}
        public DateTime _FHINGR { set; get; }
        public int _IDDOC { set; get; }
        public int _numDoc { set; get; }
        public int _idDescripcion { set; get; }
        public int _idDocing { set; get; }
        public string _nDescripcion_caja { set; get; }
        public int _idCentroCoto { set; get; }
        public string _egreso { set; get; }
        public string _tot_egresos { set; get; }
        public int _idTipPago { set; get; }
        public string _mov_efectivo { set; get; }
        public string _saldo_efectivo { set; get; }
        public string _mov_banco { set; get; }
        public string _saldo_banco { set; get; }
        public string _saldo_total { set; get; }
        public string _observacion { set; get; }
        public string _dia { set; get; }
        public int _estado { set; get; }
        public int _estado_ing { set; get; }
        public int _estado_transferencia { set; get; }
        public int _estado_comision { set; get; }
        public int _estado_rembolso { set; get; }
    }
}
