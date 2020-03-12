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
    public class ProvinceDao : ConnectionToSql
    {
        public List<ProvinceEntity> ListProvinci(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select isnull(PR.IDPR,'')ID, isnull(CODPRO,'')CODPRO,
                isnull(NOMPRO,'')NOMPRO, isnull(PA.NOMPAI,'')NOMPA
                from PROVINCIA PR INNER JOIN PAIS PA ON PR.IDPAI = PA.ID
                where NOMPRO like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProvinceEntity> ListProvince = new List<ProvinceEntity>();
                while (reader.Read())
                {
                    ListProvince.Add(new ProvinceEntity() {
                        _ID = reader.GetInt32(0),
                        _CODPRO = reader.GetString(1),
                        _NOMPRO = reader.GetString(2),
                        _PAIS = reader.GetString(3),
                    });
                }
                return ListProvince;
            }
        }

        public List<ProvinceEntity> FilterProvince(int condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT pr.IDPR, NOMPRO FROM PROVINCIA PR INNER JOIN PAIS PA
                ON PR.IDPAI = PA.ID where pr.IDPAI = @varibale";
                cmd.Parameters.AddWithValue("@varibale", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProvinceEntity> ListProvince = new List<ProvinceEntity>();
                while (reader.Read())
                {
                    ListProvince.Add(new ProvinceEntity() {
                        _ID = reader.GetInt32(0),
                        _NOMPRO = reader.GetString(1)
                    });
                }
                return ListProvince;
            }
        }

        public void RegisterProvince(ProvinceEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PROVINCIA (CODPRO, NOMPRO, IDPAI)
                VALUES(@CODIGO, @NOMBRE, @IDPAIS)";
                cmd.Parameters.AddWithValue("@CODIGO", Entity._CODPRO);
                cmd.Parameters.AddWithValue("@NOMBRE", Entity._NOMPRO);
                cmd.Parameters.AddWithValue("@IDPAIS", Entity._IDPAIS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProvince(ProvinceEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PROVINCIA SET CODPRO = @CODIGO, 
                NOMPRO = @NOMBRE, IDPAI = @IDPAIS WHERE IDPR = @ID";
                cmd.Parameters.AddWithValue("@ID", Entity._ID);
                cmd.Parameters.AddWithValue("@CODIGO", Entity._CODPRO);
                cmd.Parameters.AddWithValue("@NOMBRE", Entity._NOMPRO);
                cmd.Parameters.AddWithValue("@IDPAIS", Entity._IDPAIS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProvince(ProvinceEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE PROVINCIA WHERE IDPR = @ID";
                cmd.Parameters.AddWithValue("@ID", Entity._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
