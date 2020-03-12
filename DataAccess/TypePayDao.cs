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
    public class TypePayDao : ConnectionToSql
    {
        public List<TypePayEntity> ListPay(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(ID,'')ID, ISNULL(DESCRIPCION,'')DESCRIPCION from TIPOCOMPROB
                WHERE DESCRIPCION LIKE '%'+ @variable +'%'";
                cmd.Parameters.AddWithValue("@variable",condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<TypePayEntity> MyList = new List<TypePayEntity>();
                while (reader.Read())
                {
                    MyList.Add(new TypePayEntity() {
                        _ID = reader.GetInt32(0),
                        _DESCRIP = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }
    }
}
