using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class PaisEntity
    {
        int _ID;
        string _CODPAI;
        string _NOMPAI;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string CODPAI
        {
            get
            {
                return _CODPAI;
            }

            set
            {
                _CODPAI = value;
            }
        }

        public string NOMPAI
        {
            get
            {
                return _NOMPAI;
            }

            set
            {
                _NOMPAI = value;
            }
        }
    }
}
