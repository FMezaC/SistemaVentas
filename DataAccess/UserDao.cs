using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CommonSupport;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string passw)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conect;
                    command.CommandText = @"select us.USUARI, UT.TIPOUS, emp.NOMEMP,  emp.APEPAT+' '+emp.APEMAT as Apellidos, emp.NUMDOC
                    from usuarios Us inner join EMPLEADOS emp on us.NUMDNI = emp.NUMDOC
					INNER JOIN TIP_USUARIO UT ON Us.IDTIPO = UT.ID
                    where USUARI = @user and UPASSW = @passw and Us.ESTADO = 'Activo'";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@passw", passw);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.user = reader.GetString(0);
                            UserLoginCache.tipo = reader.GetString(1);
                            UserLoginCache.nombre = reader.GetString(2);
                            UserLoginCache.apellidos = reader.GetString(3);
                            UserLoginCache.NumDocum = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void InsertUser(UserEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO USUARIOS (USUARI, UPASSW, IDTIPO, NUMDNI, ESTADO)
                VALUES(@USUARI, @UPASSW, @IDTIPO, @NUMDNI, 'ACTIVO')";
                cmd.Parameters.AddWithValue("@USUARI", Insert._USUARI);
                cmd.Parameters.AddWithValue("@UPASSW", Insert._UPASSW);
                cmd.Parameters.AddWithValue("@IDTIPO", Insert._IDTIPO);
                cmd.Parameters.AddWithValue("@NUMDNI", Insert._NUMDNI);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateType(UserEntity UpdateType)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE USUARIOS SET IDTIPO = @IDTIPO WHERE NUMDNI = @NUMDNI";
                cmd.Parameters.AddWithValue("@IDTIPO", UpdateType._IDTIPO);
                cmd.Parameters.AddWithValue("@NUMDNI", UpdateType._NUMDNI);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePassword(UserEntity ChangePass)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE USUARIOS SET UPASSW = @UPASSW WHERE NUMDNI = @NUMDNI";
                cmd.Parameters.AddWithValue("@NUMDNI", ChangePass._NUMDNI);
                cmd.Parameters.AddWithValue("@UPASSW", ChangePass._UPASSW);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
