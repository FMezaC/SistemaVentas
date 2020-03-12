using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class PayDao : ConnectionToSql
    {
        public void RegisterPay(PayEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PAGOS (CODVEN, TICOMP, TOTPAG, MONTOP, VUELTO, 
				DEUDAP, NUMCUO, FECHPAG) VALUES(@CODVEN, @TICOMP, 
				@TOTPAG, @MONTOP, @VUELTO, @DEUDAP, @NUMCUO, SYSDATETIME())";
                cmd.Parameters.AddWithValue("@CODVEN", Insert._CODVEN);
                cmd.Parameters.AddWithValue("@TICOMP", Insert._TICOMP);
                cmd.Parameters.AddWithValue("@TOTPAG", Insert._TOTPAG);
                cmd.Parameters.AddWithValue("@MONTOP", Insert._MONTOP);
                cmd.Parameters.AddWithValue("@VUELTO", Insert._VUELTO);
                cmd.Parameters.AddWithValue("@DEUDAP", Insert._DEUDAP);
                cmd.Parameters.AddWithValue("@NUMCUO", Insert._NUMCUO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
