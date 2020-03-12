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
    public class CivilStatusDao : ConnectionToSql
    {
        public List<CivilStatusEntity> ListCivil(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ID,'')ID, ISNULL(ESTCOD,'')ESTCOD,
                ISNULL(ESTADO, '')ESTADO FROM ESTADO_CIVIL WHERE ESTADO like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<CivilStatusEntity> MyList = new List<CivilStatusEntity>();
                while (reader.Read())
                {
                    MyList.Add(new CivilStatusEntity() {
                        _ID = reader.GetInt32(0),
                        _ESTCOD = reader.GetString(1),
                        _ESTADO = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }

        public void InsertCivil(CivilStatusEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "INSERT INTO ESTADO_CIVIL (ESTCOD, ESTADO) VALUES(@CODIGO, @NOMBRE)";
                cmd.Parameters.AddWithValue("@CODIGO", Insert._ESTCOD);
                cmd.Parameters.AddWithValue("@NOMBRE", Insert._ESTADO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCivil(CivilStatusEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "UPDATE ESTADO_CIVIL SET ESTCOD = @CODIGO, ESTADO = @NOMBRE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CODIGO", Update._ESTCOD);
                cmd.Parameters.AddWithValue("@NOMBRE", Update._ESTADO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCivil(CivilStatusEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE ESTADO_CIVIL WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
