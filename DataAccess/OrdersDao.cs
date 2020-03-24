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
    public class OrdersDao : ConnectionToSql
    {
        public double MaxIDCount()
        {
            using (var conecct = GetConnection())
            {
                double ID = 0;
                conecct.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conecct;
                cmd.CommandText = @"SELECT (CODPEDI + 1)NUMPED FROM PEDIDOS";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetDouble(0);
                }
                return ID;
            }
        }

        //public List<OrdersEntity> ListOrders(string condicion)
        //{
        //    using (var conection = GetConnection())
        //    {
        //        conection.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conection;
        //        cmd.CommandText = @"select IDCUENT, NUMCUEN, NOMBUSU, NUMDOCU, ENTIDAD, TIPCUEN,
        //        TIPTARJ, CODIUCV, FCHAPER, FCHCADU from CUENTAS WHERE NOMBUSU LIKE '%' + @BUSC + '%'";
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@BUSC", condicion);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        List<OrdersEntity> ListCounts = new List<OrdersEntity>();
        //        while (reader.Read())
        //        {
        //            ListCounts.Add(new OrdersEntity {
        //                IDCUENT = reader.GetInt32(0),
        //                NUMCUEN = reader.GetString(1),
        //                NOMBUSU = reader.GetString(2),
        //                NUMDOCU = reader.GetInt32(3),
        //                ENTIDAD = reader.GetString(4),
        //                TIPCUEN = reader.GetString(5),
        //                TIPTARJ = reader.GetString(6),
        //                CODIUCV = reader.GetInt32(7),
        //                FCHAPER = reader.GetDateTime(8),
        //                FCHCADU = reader.GetDateTime(9)
        //            });
        //        }
        //        return ListCounts;
        //    }
        //}
    }
}
