using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BillingDao : ConnectionToSql
    {
        public void InsertBilling(BillingEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DECLARE @IDFACT INT SET @IDFACT = (SELECT ISNULL(MAX(IDFACT) + 1 ,0) AS ID FROM FACTURA)
                INSERT INTO FACTURA (IDFACT, TIPFAC, FCHFAC, FCHVEN, BNFDOC, TIPPAG, TIPMON, ESTADO, SUBTOT, BONIFI, 
                IMPUST, DESCUE, TOTPAG, USUARI, CAJSTA) VALUES(@IDFACT, @TIPFAC, @FCHFAC, @FCHVEN, @BNFDOC, @TIPPAG, @TIPMON,
                @ESTADO, @SUBTOT, @BONIFI, @IMPUST, @DESCUE, @TOTPAG, @USUARI, 'APERTURADO')";
                cmd.Parameters.AddWithValue("@TIPFAC", Insert._TIPFAC);
                cmd.Parameters.AddWithValue("@FCHFAC", Insert._FCHFAC);
                cmd.Parameters.AddWithValue("@FCHVEN", Insert._FCHVEN);
                cmd.Parameters.AddWithValue("@BNFDOC", Insert._BNFDOC);
                cmd.Parameters.AddWithValue("@TIPPAG", Insert._TIPPAG);
                cmd.Parameters.AddWithValue("@TIPMON", Insert._TIPMON);
                cmd.Parameters.AddWithValue("@ESTADO", Insert._ESTADO);
                cmd.Parameters.AddWithValue("@SUBTOT", Insert._SUBTOT);
                cmd.Parameters.AddWithValue("@BONIFI", Insert._BONIFI);
                cmd.Parameters.AddWithValue("@IMPUST", Insert._IMPUST);
                cmd.Parameters.AddWithValue("@DESCUE", Insert._DESCUE);
                cmd.Parameters.AddWithValue("@TOTPAG", Insert._TOTPAG);
                cmd.Parameters.AddWithValue("@USUARI", Insert._USUARI);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertDetailsBilling(BillingDetailEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DECLARE @IDFACT INT SET @IDFACT = (SELECT ISNULL(MAX(IDFACT) + 1 ,0) AS ID FROM FACTURA)
                INSERT INTO DETALLE_FACTURA (IDFACT, CODPRO, DESCRI, UNIMED, CANTID, PREUIT, SUBTOT) 
                VALUES (@IDFACT, @CODPRO, @DESCRI, @UNIMED, @CANTID, @PREUIT, @SUBTOT)";
                cmd.Parameters.AddWithValue("@CODPRO", Insert._CODPRO);
                cmd.Parameters.AddWithValue("@DESCRI", Insert._DESCRI);
                cmd.Parameters.AddWithValue("@UNIMED", Insert._UNIMED);
                cmd.Parameters.AddWithValue("@CANTID", Insert._CANTID);
                cmd.Parameters.AddWithValue("@PREUIT", Insert._PREUIT);
                cmd.Parameters.AddWithValue("@SUBTOT", Insert._SUBTOT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
