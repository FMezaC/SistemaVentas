using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BuckUpDao : ConnectionToSql
    {
        public void BuckUp(string Nombre)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                //string ubicacion;
                //if (ubicacion)
                //{

                //}
                cmd.CommandText = @"BACKUP DATABASE [BDHOTELERIA] TO  DISK =N'D:\BuckUp\" + Nombre+
                    "' WITH NOFORMAT, NOINIT,  NAME = N'BDHOTELERIA', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
