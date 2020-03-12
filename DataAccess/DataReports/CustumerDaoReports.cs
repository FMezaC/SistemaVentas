using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.DataReports
{
    public class CustumerDaoReports : ConnectionToSql
    {
        public DataTable CustomerListReport(DateTime fromDate, DateTime ToDate)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT cl.NUMDOC, CL.NOMCLI, CL.APEPAT + ' ' + CL.APEMAT as APELLIDOS,
				SUM(DTV.CANPRO)CANTIDAD, SUM((PREUNT * CANPRO) + IGV - DESCUE)INGRESOS 
				FROM CLIENTES CL INNER JOIN VENTA VNT ON CL.NUMDOC = VNT.IDCLIE
				INNER JOIN DETALLE_VENTA DTV ON DTV.IDVENT = VNT.IDVENT
				WHERE VNT.FECHVE BETWEEN @fromDate AND @toDate
				GROUP BY NUMDOC, NOMCLI, APEPAT, APEMAT
				ORDER BY CANTIDAD DESC";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fromDate", DbType.DateTime).Value = fromDate;
                cmd.Parameters.AddWithValue("@toDate", DbType.DateTime).Value = ToDate;
                var reader = cmd.ExecuteReader();
                var table = new DataTable();
                table.Load(reader);
                return table;
            }
        }
    }
}
