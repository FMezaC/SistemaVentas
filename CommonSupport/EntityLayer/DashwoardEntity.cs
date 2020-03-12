using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSupport.EntityLayer
{
    public class DashwoardEntity
    {
        public string _CANTCLI { set; get; }
        public string _OCUPADO { set; get; }
        public string _DISPONI { set; get; }
        public string _RESERVA { set; get; }
        public string _MANTENI { set; get; }
        public string _LIMPIEZ { set; get; }

        // Entidades de lectura
        ArrayList _Numero = new ArrayList();
        ArrayList _Estado = new ArrayList();

        ArrayList _Total = new ArrayList();
        ArrayList _Nombre = new ArrayList();
        public ArrayList Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public ArrayList Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public ArrayList Total
        {
            get
            {
                return _Total;
            }

            set
            {
                _Total = value;
            }
        }

        public ArrayList Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }
        
    }
}
