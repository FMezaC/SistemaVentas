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
    public class OriginDao : ConnectionToSql
    {
        public List<OriginEntity> ListOrigin(string Condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select CODPROCE, DESCPROCE FROM PROCED_PRODUC 
                where DESCPROCE like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", Condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<OriginEntity> LisOrigin = new List<OriginEntity>();
                while (reader.Read())
                {
                    LisOrigin.Add(new OriginEntity() {
                        _CODPROCE = reader.GetString(0),
                        _DESCPROCE = reader.GetString(1)
                    });
                }
                return LisOrigin;
            }
        }
    }
}
