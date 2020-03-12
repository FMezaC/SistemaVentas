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
    public class UserTypeDao : ConnectionToSql
    {
        public List<UserTypeEntity> ListUserType(string condition)
        {
            using(var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(ID,'')ID, isnull(CODTIP,'')CODTIP, ISNULL(TIPOUS,'')TIPOUS 
                from TIP_USUARIO WHERE TIPOUS like '%' + @VARIABLE + '%' ";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserTypeEntity> MyList = new List<UserTypeEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UserTypeEntity() {
                        _ID = reader.GetInt32(0),
                        _CODTIP = reader.GetString(1),
                        _TIPOUS = reader.GetString(2),
                    });
                }
                return MyList;
            }
        }

        public void InsertUsertType(UserTypeEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO TIP_USUARIO (CODTIP, TIPOUS) VALUES(@CODTIP, @USUARIO)";
                cmd.Parameters.AddWithValue("@CODTIP", Insert._CODTIP);
                cmd.Parameters.AddWithValue("@USUARIO", Insert._TIPOUS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUsertType(UserTypeEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "UPDATE TIP_USUARIO SET CODTIP = @CODTIP, TIPOUS = @USUARIO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CODTIP", Update._CODTIP);
                cmd.Parameters.AddWithValue("@USUARIO", Update._TIPOUS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUsertType(UserTypeEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE TIP_USUARIO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
