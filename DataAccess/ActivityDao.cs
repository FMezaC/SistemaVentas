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
    public class ActivityDao : ConnectionToSql
    {
        public List<ActivityEntity> ListActivity(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(AM.ID,'')ID,ISNULL(ACTEMP,'')ACTEMP, ISNULL(RU.RUBRO,'')RUBRO
                FROM ACTIVIDAD_EMRESARIAL AM INNER JOIN RUBRO_EMPRESA RU
                ON AM.IDRUB = RU.ID WHERE ACTEMP LIKE '%' + @VARIABLE +'%' ";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ActivityEntity> MyList = new List<ActivityEntity>();
                while (reader.Read())
                {
                    MyList.Add(new ActivityEntity() {
                        _ID = reader.GetInt32(0),
                        _ACTEMP = reader.GetString(1),
                        _RUBRO = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }

        public void InsertActivity(ActivityEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO ACTIVIDAD_EMRESARIAL(ACTEMP, IDRUB) VALUES(@ACTEMP, @IDRUB)";
                cmd.Parameters.AddWithValue("@ACTEMP", Insert._ACTEMP);
                cmd.Parameters.AddWithValue("@IDRUB", Insert._IDRUB);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateActivity(ActivityEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE ACTIVIDAD_EMRESARIAL SET ACTEMP = @ACTEMP,
                IDRUB = @IDRUB WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@ACTEMP", Update._ACTEMP);
                cmd.Parameters.AddWithValue("@IDRUB", Update._IDRUB);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteActivity(ActivityEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE ACTIVIDAD_EMRESARIAL WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<ActivityEntity> FilterActivity(int condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ID, ACTEMP from ACTIVIDAD_EMRESARIAL WHERE IDRUB = @ID ";
                cmd.Parameters.AddWithValue("@ID", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ActivityEntity> MyList = new List<ActivityEntity>();
                while (reader.Read())
                {
                    MyList.Add(new ActivityEntity()
                    {
                        _ID = reader.GetInt32(0),
                        _ACTEMP = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }
    }
}
