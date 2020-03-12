using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class GenderDao : ConnectionToSql
    {
        public List<GenderEntity> GenderList(string condition)
        {
            using (var conect =GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ID,'')ID, ISNULL(CODGEN,'')CODGEN,
                ISNULL(GENERO, '')GENERO FROM GENERO WHERE GENERO like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<GenderEntity> MyList = new List<GenderEntity>();
                while (reader.Read())
                {
                    MyList.Add(new GenderEntity() {
                        _ID = reader.GetInt32(0),
                        _CODGEN = reader.GetString(1),
                        _GENERO = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }

        public void InsertGender(GenderEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "INSERT INTO GENERO(CODGEN, GENERO) VALUES(@CODIGO, @NOMBRE)";
                cmd.Parameters.AddWithValue("@CODIGO", Insert._CODGEN);
                cmd.Parameters.AddWithValue("@NOMBRE", Insert._GENERO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateGender(GenderEntity update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE GENERO SET CODGEN = @CODIGO, GENERO = @NOMBRE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", update._ID);
                cmd.Parameters.AddWithValue("@CODIGO", update._CODGEN);
                cmd.Parameters.AddWithValue("@NOMBRE", update._GENERO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteGender(GenderEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE GENERO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
