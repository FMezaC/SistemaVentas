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
    public class PurcharseDetailsDao : ConnectionToSql
    {
        public void InsetPurcharseDetail(PurcharseDetailsEntity Entity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"INSERT INTO DETALLE_PEDIDO (IDPEDI, CODPRO, DESCRI, UNIMED,
                IMPIGV, CANTID, PREUNI, SUBTOT) VALUES(@IDPEDI, @CODPRO,
                @DESCRI, @UNIMED, @IMPIGV, @CANTID, @PREUNI, @SUBTOT)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDPEDI", Entity.IDPEDI);
                cmd.Parameters.AddWithValue("@CODPRO", Entity.CODPRO);
                cmd.Parameters.AddWithValue("@DESCRI", Entity.DESCRI);
                cmd.Parameters.AddWithValue("@UNIMED", Entity.UNIMED);
                cmd.Parameters.AddWithValue("@IMPIGV", Entity.IMPIGV);
                cmd.Parameters.AddWithValue("@CANTID", Entity.CANTID);
                cmd.Parameters.AddWithValue("@PREUNI", Entity.PREUNI);
                cmd.Parameters.AddWithValue("@SUBTOT", Entity.SUBTOT);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
