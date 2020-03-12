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
    public class DistricDao : ConnectionToSql
    {
        public List<DistricEntity> ListDistric(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(D.IDDIS,'')ID, ISNULL(CODDIS,'')CODDIS,
                ISNULL(NOMDIS, '')NOMDIS, ISNULL(NOMPRO, '')NOMPRO, ISNULL(NOMPAI, '')NOMPAI
                from DISTRITO D  INNER JOIN PROVINCIA PR
                ON D.IDPROV = PR.IDPR INNER JOIN PAIS PA ON PA.ID = PR.IDPAI
                WHERE NOMDIS like  '%' + @variable + '%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<DistricEntity> ListDistri = new List<DistricEntity>();
                while (reader.Read())
                {
                    ListDistri.Add(new DistricEntity() {
                        _ID = reader.GetInt32(0),
                        _CODDIS = reader.GetString(1),
                        _NOMDIS = reader.GetString(2),
                        _PROVIN = reader.GetString(3),
                        _PAIS = reader.GetString(4)
                    });
                }
                return ListDistri;
            }
        }

        public void RegisterDistric(DistricEntity entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO DISTRITO(CODDIS, NOMDIS, IDPROV) 
                VALUES(@CODIGO, @NOMBRE, @IDPR)";
                cmd.Parameters.AddWithValue("@CODIGO", entity._CODDIS);
                cmd.Parameters.AddWithValue("@NOMBRE", entity._NOMDIS);
                cmd.Parameters.AddWithValue("@IDPR", entity._CODPR);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDistric(DistricEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE DISTRITO SET CODDIS = @CODIGO, NOMDIS = @NOMBRE, 
                IDPROV = @IDPR WHERE IDDIS = @ID ";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CODIGO", Update._CODDIS);
                cmd.Parameters.AddWithValue("@NOMBRE", Update._NOMDIS);
                cmd.Parameters.AddWithValue("@IDPR", Update._CODPR);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDistric(DistricEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE FROM DISTRITO WHERE IDDIS = @ID ";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<DistricEntity> FilterDistric(int condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT IDDIS, NOMDIS FROM DISTRITO D
                INNER JOIN PROVINCIA P ON P.IDPR = D.IDPROV WHERE IDPROV = @IDPROV ";
                cmd.Parameters.AddWithValue("@IDPROV", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<DistricEntity> ListProvince = new List<DistricEntity>();
                while (reader.Read())
                {
                    ListProvince.Add(new DistricEntity()
                    {
                        _ID = reader.GetInt32(0),
                        _NOMDIS = reader.GetString(1)
                    });
                }
                return ListProvince;
            }
        }
    }
}
