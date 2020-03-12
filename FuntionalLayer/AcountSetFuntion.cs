using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuntionalLayer
{
    public class AcountSetFuntion
    {
        public string ResidueCount(double TotalDebe, double TotalHaber)
        {
            string Residuo = Convert.ToString(TotalDebe - TotalHaber);
            return Residuo;
        }
        
    }
}
