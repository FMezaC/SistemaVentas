using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DataReports
{
    public class OrderDaoReport : ConnectionToSql
    {
      public DataTable GetSalesOrder(DateTime fromDATE, DateTime ToDATE)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT DTV.CODPRO, DTV.DESPRO,CAST(VNT.FECHVE AS DATE)FECH_VENT,
                VNT.IGV, DTV.PREUNT, SUM(DTV.CANPRO)CANTIDAD,
                DTV.PREUNT * SUM(DTV.CANPRO) + VNT.IGV AS TOTTAL FROM VENTA VNT
                INNER JOIN DETALLE_VENTA DTV ON VNT.IDVENT = DTV.IDVENT
                WHERE CAST(VNT.FECHVE AS DATE) BETWEEN  @fromDATE AND @ToDATE
                GROUP BY DTV.CODPRO, DTV.DESPRO, CAST(VNT.FECHVE AS DATE), DTV.PREUNT, VNT.IGV
                ORDER BY CODPRO ASC";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fromDATE", SqlDbType.Date).Value = fromDATE;
                cmd.Parameters.AddWithValue("@ToDATE", SqlDbType.Date).Value = ToDATE;
                var reader = cmd.ExecuteReader();
                var table = new DataTable();
                table.Load(reader);
                return table;
            }
        }
    }
}
