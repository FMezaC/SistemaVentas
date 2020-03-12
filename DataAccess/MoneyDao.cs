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
    public class MoneyDao : ConnectionToSql
    {
        public List<MoneyEntity> ListMoney(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(IDMONE,'')ID, ISNULL(MONEDA,'')MONEDA FROM MONEDA
                WHERE MONEDA LIKE '%'+@VARIABLE+'%' ";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoneyEntity> MyList = new List<MoneyEntity>();
                while (reader.Read())
                {
                    MyList.Add(new MoneyEntity() {
                        _ID = reader.GetInt32(0),
                        _MONEY = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }
    }
}
