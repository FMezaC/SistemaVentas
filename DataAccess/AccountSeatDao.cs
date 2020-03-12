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
    public class AccountSeatDao : ConnectionToSql
    {
        public void InsertASI(AccountSeatEntity Insert)
        {
            using (var conect= GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO ASIENTO_CONTABLE 
                (IDASI, NUMASI, FECHA, NOTA, TOTDEB, TOTHAB, RESTAN, IDCUENT)
                VALUES (@IDASI, @NUMASI,@FECHA,@NOTA,@TOTDEB,@TOTHAB,@RESTAN, @IDCUENT)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDASI", Insert._IDASI);
                cmd.Parameters.AddWithValue("@NUMASI", Insert._NUMASI);
                cmd.Parameters.AddWithValue("@FECHA", Insert._FECHA);
                cmd.Parameters.AddWithValue("@NOTA", Insert._NOTA);
                cmd.Parameters.AddWithValue("@TOTDEB", Insert._TOTDEB);
                cmd.Parameters.AddWithValue("@TOTHAB", Insert._TOTHAB);
                cmd.Parameters.AddWithValue("@RESTAN", Insert._RESTAN);
                cmd.Parameters.AddWithValue("@IDCUENT", Insert._IDCUENT);
                cmd.ExecuteNonQuery();
            }
        }

        public string MaxID (MaxID ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select MAX(IDASI) + 1 as ID from ASIENTO_CONTABLE";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID._MaxIDINT = reader.GetInt32(0);
                }
                return Convert.ToString(ID._MaxIDINT);
            }
        }

        public List<AccountSeatEntity> ListAccount(DateTime fech1, DateTime fech2)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ASI.IDASI,'')IDASI, ISNULL(NUMASI,'')NUMASI,ISNULL(FECHA,'')FECHA,
                ISNULL(NOTA,'')NOTA,ISNULL(CTA,'')CTA,ISNULL(CONCEP,'')CONCEP,ISNULL(DETALL,'')DETALL,
                ISNULL(CUENTAS,'')CUENTA,ISNULL(DEBE,'')DEBE, ISNULL(HAER,'')HABER,
                ISNULL(TOTDEB,'')TOTDEB,ISNULL(TOTHAB,'')TOTHAB, ISNULL(RESTAN,'')RESTANTE
                FROM ASIENTO_CONTABLE ASI INNER JOIN DETALLE_ASIENTO DET ON ASI.IDASI = DET.IDASI
                INNER JOIN PLAN_CUENTAS PC ON PC.ID = ASI.IDCUENT
                where DET.DETALL <> '' and ASI.FECHA BETWEEN @FECH1 AND @FECH2 ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FECH1", fech1);
                cmd.Parameters.AddWithValue("@FECH2", fech2);
                SqlDataReader reader = cmd.ExecuteReader();
                List<AccountSeatEntity> MyList = new List<AccountSeatEntity>();
                while (reader.Read())
                {
                    MyList.Add(new AccountSeatEntity() {
                        _IDASI = reader.GetInt32(0),
                        _NUMASI = reader.GetString(1),
                        _FECHA = reader.GetDateTime(2),
                        _NOTA = reader.GetString(3),
                        _IDCUENT = reader.GetInt32(4),
                        _CONCEP = reader.GetString(5),
                        _DETALL = reader.GetString(6),
                        _CUENTA = reader.GetString(7),
                        _DEBE = reader.GetDouble(8),
                        _HABER = reader.GetDouble(9),
                        _TOTDEB = reader.GetDouble(10),
                        _TOTHAB = reader.GetDouble(11),
                        _RESTAN = reader.GetDouble(12),
                    });
                }
                return MyList;
            }
        }

        public void UpdateASI(AccountSeatEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE ASIENTO_CONTABLE SET NUMASI = @NUMASI, FECHA = @FECHA,
                NOTA = @NOTA, TOTDEB = @TOTDEB, TOTHAB = @TOTHAB, RESTAN = @RESTAN,
                IDCUENT = @IDCUENT WHERE IDASI = @IDASI";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDASI", Update._IDASI);
                cmd.Parameters.AddWithValue("@NUMASI", Update._NUMASI);
                cmd.Parameters.AddWithValue("@FECHA", Update._FECHA);
                cmd.Parameters.AddWithValue("@NOTA", Update._NOTA);
                cmd.Parameters.AddWithValue("@TOTDEB", Update._TOTDEB);
                cmd.Parameters.AddWithValue("@TOTHAB", Update._TOTHAB);
                cmd.Parameters.AddWithValue("@RESTAN", Update._RESTAN);
                cmd.Parameters.AddWithValue("@IDCUENT", Update._IDCUENT);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
