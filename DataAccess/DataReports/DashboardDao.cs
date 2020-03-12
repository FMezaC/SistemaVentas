using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using CommonSupport.EntityDashbordLayer;

namespace DataAccess.DataReports
{
    public class DashboardDao : ConnectionToSql
    {
        public void DashboardSalesByWeeks(DashboardEntity Entity)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conection;
                cmd.CommandText = @"SELECT DATENAME( WEEKDAY , CAST( V.FECHVE as date))Dia, SUM(dt.CANPRO)Cantidad
                FROM VENTA V inner join DETALLE_VENTA DT  on V.IDVENT = DT.IDVENT
                where CAST(v.FECHVE as date) BETWEEN 
                dateadd(week, datediff(week, -1, getdate()), -1) AND CAST(SYSDATETIME() as date)
                Group by CAST( V.FECHVE as date)";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.DayName.Add(reader.GetString(0));
                    Entity.SalesAmount.Add(reader.GetInt32(1));
                }
                reader.Close();
            }
        }

        public void DashboardCashByWeeks(DashboardEntity Entity)
        {
            using (var connect = GetConnection())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = @"SELECT DATENAME( WEEKDAY , CAST( V.FECHVE as date))Dia, SUM(v.TOTPAG)Total
                FROM VENTA V inner join DETALLE_VENTA DT  on V.IDVENT = DT.IDVENT
                where CAST(v.FECHVE as date) BETWEEN 
                dateadd(week, datediff(week, -1, getdate()), -1) AND CAST(SYSDATETIME() as date)
                Group by CAST( V.FECHVE as date)";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.WeeksName.Add(reader.GetString(0));
                    Entity.SalesByWeeks.Add(reader.GetDouble(1));
                }
                reader.Close();
            }
        }

        public void CountRegisterDBDao(DashboardEntity Entity)
        {
            using (var connect = GetConnection())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = @"set @CUSTOMER = (select COUNT(CODCLI)CUSTOMER from CLIENTES)
                set @PRODUCTS = (select COUNT(CODPROD)PRODUCTS from PRODUCTOS)
                set @BILLIGN = (select COUNT(IDFACT)BILLIGN from FACTURA)
                set @SEAT = (select COUNT(IDASI)SEAT from ASIENTO_CONTABLE)";
                cmd.CommandType = CommandType.Text;
                SqlParameter CUSTOMER = new SqlParameter("@CUSTOMER", 0); CUSTOMER.Direction = ParameterDirection.Output;
                SqlParameter PRODUCTS = new SqlParameter("@PRODUCTS", 0); PRODUCTS.Direction = ParameterDirection.Output;
                SqlParameter BILLIGN = new SqlParameter("@BILLIGN", 0); BILLIGN.Direction = ParameterDirection.Output;
                SqlParameter SEAT = new SqlParameter("@SEAT", 0); SEAT.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(CUSTOMER);
                cmd.Parameters.Add(PRODUCTS);
                cmd.Parameters.Add(BILLIGN);
                cmd.Parameters.Add(SEAT);
                cmd.ExecuteNonQuery();
                Entity._CUSTOMER = cmd.Parameters["@CUSTOMER"].Value.ToString();
                Entity._PRODUCTS = cmd.Parameters["@PRODUCTS"].Value.ToString();
                Entity._BILLIGN = cmd.Parameters["@BILLIGN"].Value.ToString();
                Entity._SEAT = cmd.Parameters["@SEAT"].Value.ToString();
            }
        }
    }
}
