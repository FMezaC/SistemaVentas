using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DataReports
{
    public class ProductDaoReport : ConnectionToSql
    {
        public DataTable ListProductSales(DateTime fromDATE, DateTime ToDATE)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT p.CODPROD, p.DESCPRO, SUM(v.IGV)IGV, p.PREUNIT, SUM(dt.CANPRO) CANTIDAD, 
                SUM(((P.PREUNIT * DT.CANPRO) - V.DESCUE) + V.IGV)INGRESOS
                FROM VENTA V
                INNER JOIN DETALLE_VENTA DT ON V.IDVENT = DT.IDVENT
                INNER JOIN PRODUCTOS P ON DT.CODPRO = P.CODBARR
                where v.FECHVE BETWEEN @fromDATE AND @ToDATE
                group by p.CODPROD, p.DESCPRO, p.PREUNIT
                ORDER BY CANTIDAD DESC";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fromDATE", SqlDbType.Date).Value = fromDATE;
                cmd.Parameters.AddWithValue("@ToDATE", SqlDbType.Date).Value = ToDATE;
                var reader = cmd.ExecuteReader();
                var Table = new DataTable();
                Table.Load(reader);
                return Table;
            }
        }
        
    }
}
