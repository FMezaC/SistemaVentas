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
    public class StateGeneralDao : ConnectionToSql
    {
        public List<StateEntityGeneral> ListEstates()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "SELECT ISNULL(ID,'')ID, ISNULL(ESTADO,'')ESTAD FROM ESTADO";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<StateEntityGeneral> MyList = new List<StateEntityGeneral>();
                while (reader.Read())
                {
                    MyList.Add(new StateEntityGeneral() {
                        _ID = reader.GetInt32(0),
                        _ESTADO = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }
    }
}
