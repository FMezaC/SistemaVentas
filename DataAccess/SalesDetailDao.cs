using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class SalesDetailDao : ConnectionToSql
    {
        public void IsertSalesDatail(DetailSalesEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO DETALLE_VENTA (IDVENT, CODPRO, DESPRO, PREUNT, CANPRO, SUBTOT)
                VALUES(@IDVENT, @CODPRO, @DESPRO, @PREUNT, @CANPRO, @SUBTOT)";
                cmd.Parameters.AddWithValue("@IDVENT", Insert._IDVENT);
                cmd.Parameters.AddWithValue("@CODPRO", Insert._CODPRO);
                cmd.Parameters.AddWithValue("@DESPRO", Insert._DESPRO);
                cmd.Parameters.AddWithValue("@PREUNT", Insert._PREUNT);
                cmd.Parameters.AddWithValue("@CANPRO", Insert._CANPRO);
                cmd.Parameters.AddWithValue("@SUBTOT", Insert._SUBTOT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<DetailSalesEntity> ListDetail(int ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(CODPRO,'')ID, ISNULL(DESPRO,'')DESCR, ISNULL(PREUNT,'')PREU, 
                ISNULL(CANPRO, '')CANT, ISNULL(SUBTOT, '')STOT FROM DETALLE_VENTA WHERE IDVENT = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<DetailSalesEntity> MyList = new List<DetailSalesEntity>();
                while (reader.Read())
                {
                    MyList.Add(new DetailSalesEntity() {
                        _CODPRO = reader.GetDouble(0),
                        _DESPRO = reader.GetString(1),
                        _PREUNT = reader.GetDouble(2),
                        _CANPRO = reader.GetInt32(3),
                        _SUBTOT = reader.GetDouble(4)
                    });
                }
                return MyList;
            }
        }
    }
}
