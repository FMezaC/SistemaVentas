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
    public class BillingTypeDao : ConnectionToSql
    {
        public List<BillingTypeEntity> ListBillingType(string ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ID,'')ID,ISNULL(CODFACT,'')COD,ISNULL(FACTURA,'')FACT 
                FROM TIPO_FACTURA WHERE CODFACT LIKE '%' + @VARIABLE + '%'";
                cmd.Parameters.AddWithValue("@VARIABLE", ID);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<BillingTypeEntity> MyList = new List<BillingTypeEntity>();
                while (reader.Read())
                {
                    MyList.Add(new BillingTypeEntity() {
                        _ID = reader.GetInt32(0),
                        _CODFACT = reader.GetString(1),
                        _FACTURA = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }
    }
}
