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
    public class MesuareDao : ConnectionToSql
    {
        public List<MesuareEntity> ListMesuare(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(IDUMS,'')ID, ISNULL(UMSTOCK,'')Medida 
                FROM MEDIDA WHERE UMSTOCK LIKE '%' + @VARIABLE + '%'";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<MesuareEntity> MyList = new List<MesuareEntity>();
                while (reader.Read())
                {
                    MyList.Add(new MesuareEntity() {
                        _IDUMS = reader.GetString(0),
                        _UMSTOCK = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }

        public void InsertMesuare(MesuareEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO MEDIDA(IDUMS, UMSTOCK) VALUES(@ID, @MEDIDA)";
                cmd.Parameters.AddWithValue("@ID", Insert._IDUMS);
                cmd.Parameters.AddWithValue("@MEDIDA", Insert._UMSTOCK);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMesuare(MesuareEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE MEDIDA SET IDUMS = @ID, UMSTOCK= @MEDIDA WHERE IDUMS = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._IDUMS);
                cmd.Parameters.AddWithValue("@MEDIDA", Update._UMSTOCK);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMesuare(MesuareEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE MEDIDA WHERE IDUMS = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._IDUMS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
