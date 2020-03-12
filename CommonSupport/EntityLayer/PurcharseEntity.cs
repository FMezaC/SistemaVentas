using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class PurcharseEntity
    {
        public int NUMPED  {get; set; }
        public int IDCUENT {get; set; }
        public int IDPROVE {get; set; }
        public int IDTIPPA {get; set; }
        public int IDTIPMO {get; set; }
        public string GLOSA   {get; set; }
        public string ESTADO { get; set; }
        public DateTime FCHEMI  {get; set; }
        public DateTime FCHVEN  {get; set; }
        public double SUBTOT  {get; set; }
        public double PEDIGV  {get; set; }
        public double DESCUE  {get; set; }
        public double TOTPAG { get; set; }

        // lista de productos
        public string CODPROD { get; set; }
        public string DESPROD { get; set; }
        public string EMPRESA { get; set; }
        public string NUMCUET { get; set; }
        public string USCUENT { get; set; }
        public string UNIMEDI { get; set; }
        public int CANTPRO { get; set; }
        public decimal PREUNIT { get; set; }
        public decimal IMPUEST { get; set; }
        public decimal TOTALES { get; set; }
    }
}
