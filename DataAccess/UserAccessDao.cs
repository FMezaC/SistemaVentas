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
    public class UserAccessDao : ConnectionToSql
    {
        public List<UserAccessEntity> DataAccessUser(string UserAccess)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(PR.ID,'')ID, ISNULL(PR.CODTIP,'')CODTIP,ISNULL(TP.TIPOUS,'')TIPO,
                ISNULL(PERMISO,'')PERMISO, ISNULL(ACCESO,'')ACCESO FROM TIP_USUARIO TP
                INNER JOIN PERMISOS_USER PR ON TP.ID = PR.CODTIP
                WHERE TP.TIPOUS = @USERTYPE ";
                cmd.Parameters.AddWithValue("@USERTYPE", UserAccess);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserAccessEntity> MyList = new List<UserAccessEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UserAccessEntity() {
                        _ID = reader.GetInt32(0),
                        _CODTIP = reader.GetInt32(1),
                        _TIPO = reader.GetString(2),
                        _PERMISO = reader.GetString(3),
                        _ACCESO = reader.GetBoolean(4)
                    });
                }
                return MyList;
            }
        }
    }
}
