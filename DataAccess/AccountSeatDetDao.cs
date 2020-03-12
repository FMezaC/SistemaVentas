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
    public class AccountSeatDetDao : ConnectionToSql
    {
        public void InsertDET(AccountSeatDetEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO DETALLE_ASIENTO (CONCEP, DETALL, DEBE, HAER, IDASI) 
			    VALUES(@CONCEP,@DETALL,@DEBE,@HAER,@IDASI)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CONCEP", Insert._CONCEP);
                cmd.Parameters.AddWithValue("@DETALL", Insert._DETALL);
                cmd.Parameters.AddWithValue("@DEBE", Insert._DEBE);
                cmd.Parameters.AddWithValue("@HAER", Insert._HAER);
                cmd.Parameters.AddWithValue("@IDASI", Insert._IDASI);
                cmd.ExecuteNonQuery();
            }
        }
        
        public List<AccountSeatDetEntity> ListDtall(int IDASI)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT DET.IDDET, ISNULL(CONCEP,'')CONCEP,ISNULL(DETALL,'')DETALL,
                ISNULL(DEBE,'')DEBE, ISNULL(HAER,'')HABER
                FROM ASIENTO_CONTABLE ASI INNER JOIN DETALLE_ASIENTO DET ON ASI.IDASI = DET.IDASI
                INNER JOIN PLAN_CUENTAS PC ON PC.ID = ASI.IDCUENT
                WHERE asi.IDASI = @IDASI and DET.DETALL<>'' ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDASI", IDASI);
                SqlDataReader reader = cmd.ExecuteReader();
                List<AccountSeatDetEntity> MyList = new List<AccountSeatDetEntity>();
                while (reader.Read())
                {
                    MyList.Add(new AccountSeatDetEntity() {
                        _IDDET = reader.GetInt32(0),
                        _CONCEP = reader.GetString(1),
                        _DETALL = reader.GetString(2),
                        _DEBE = reader.GetDouble(3),
                        _HAER = reader.GetDouble(4)
                    });
                }
                return MyList;
            }
        }

        public void UpdateDET(AccountSeatDetEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE DETALLE_ASIENTO SET CONCEP = @CONCEP, DETALL = @DETALL,
                DEBE = @DEBE, HAER = @HAER WHERE IDDET = @IDDET";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDDET", Update._IDDET);
                cmd.Parameters.AddWithValue("@CONCEP", Update._CONCEP);
                cmd.Parameters.AddWithValue("@DETALL", Update._DETALL);
                cmd.Parameters.AddWithValue("@DEBE", Update._DEBE);
                cmd.Parameters.AddWithValue("@HAER", Update._HAER);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
