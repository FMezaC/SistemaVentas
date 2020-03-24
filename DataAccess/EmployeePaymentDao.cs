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
    public class EmployeePaymentDao: ConnectionToSql
    {
        public void InsertEmployePayment()
        {
            using (var conet = GetConnection())
            {
                conet.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conet;
                cmd.CommandText = "";
                cmd.Parameters.AddWithValue("",0);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public List<EmployeePaymentEntity> ListPayments(DateTime StarDT, DateTime EndDT)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT em.NUMDOC, em.NOMEMP+' '+em.APEPAT+' '+em.APEMAT as EMPLEADO, em.FECHCO,
                pg.FECHPA, em.SALARI, pg.DEUPEN, pg.DESCUE, pg.BONUSP, pg.SALNET FROM EMPLEADOS EM
                INNER JOIN PAGO_EMPLEADO PG ON EM.NUMDOC = PG.NUMDOC
                WHERE CAST(pg.FECHPA as date) BETWEEN CAST(@FECHA1 as date) AND CAST(@FECHA2 as date)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FECHA1", StarDT);
                cmd.Parameters.AddWithValue("@FECHA2", EndDT);
                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployeePaymentEntity> ListPayments = new List<EmployeePaymentEntity>();
                while (reader.Read())
                {
                    ListPayments.Add(new EmployeePaymentEntity()
                    {
                        NUMDOC = reader.GetString(0),
                        EMPLEADO = reader.GetString(1),
                        FECHCO = reader.GetDateTime(2),
                        FECHPA = reader.GetDateTime(3),
                        SALARY = reader.GetDouble(4),
                        DEUPEN = reader.GetDecimal(5),
                        DESCUE = reader.GetDecimal(6),
                        BONUSP = reader.GetDecimal(7),
                        SALNET = reader.GetDecimal(8),
                    });
                }
                return ListPayments;
            }
        }
    }
}
