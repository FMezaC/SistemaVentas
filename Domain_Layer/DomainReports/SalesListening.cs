using System;
namespace Domain_Layer.DomainReports
{
    public class SalesListening
    {
        public string codprod { get; set; }
        public string DescProd { get; set; }
        public DateTime Fech_Vent { get; set; }
        public double Impuet { get; set; }
        public double PreUnit { get; set; }
        public int CantVend { get; set; }
        public double TotVent { get; set; }
    }
}