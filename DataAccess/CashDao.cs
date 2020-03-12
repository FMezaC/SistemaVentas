using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CommonSupport.EntityLayer;
using CommonSupport;

namespace DataAccess
{
    public class CashDao : ConnectionToSql
    {
        public void CashOpening(CashEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO CAJA_CHICA (NUMARQ, USUARI, FCHAPE, TIPMON, MONAPE, STATCJ) 
                VALUES(@NUMARQ, @USUARI, @FCHAPE, @TIPMON, @MONAPE, 'APERTURADO')";
                cmd.Parameters.AddWithValue("@NUMARQ", Entity._NUMARQ);
                cmd.Parameters.AddWithValue("@USUARI", Entity._USUARI);
                cmd.Parameters.AddWithValue("@FCHAPE", Entity._FCHAPE);
                cmd.Parameters.AddWithValue("@TIPMON", Entity._TIPMON);
                cmd.Parameters.AddWithValue("@MONAPE", Entity._MONAPE);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public bool ValidateCashDao()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT * FROM CAJA_CHICA
                WHERE STATCJ = 'APERTURADO' AND USUARI = @USERS";
                cmd.Parameters.AddWithValue("@USERS", UserLoginCache.user);
                cmd.CommandType = CommandType.Text;
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                    return true;
                else
                    return false;
            }
        }

        public void CashDataShow(CashOutputEntity CashOuput)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"begin
                SET @FACTURA = (SELECT ISNULL(SUM(FT.TOTPAG),0) TOTFACT FROM FACTURA FT
                WHERE CAJSTA = 'APERTURADO' AND USUARI = @USUARIO)

                SET @VENTAS = (SELECT ISNULL(SUM(TOTPAG),0) TOTVENT FROM VENTA V
                WHERE CAJSTA = 'APERTURADO' AND V.IDCAJE = @IDUSER AND ESTADO = 'PAGADO')

                SET @ARQUEO = (SELECT ISNULL(NUMARQ, 0)NUMARQ FROM CAJA_CHICA
                WHERE STATCJ = 'APERTURADO'AND USUARI = @USUARIO)

                SET @FECHAP = (SELECT FCHAPE FROM CAJA_CHICA
                WHERE STATCJ = 'APERTURADO'AND USUARI = @USUARIO)

                SET @MONTO = (SELECT MONAPE FROM CAJA_CHICA
                WHERE STATCJ = 'APERTURADO' AND USUARI = @USUARIO)
                end";
                SqlParameter FACTURA = new SqlParameter("@FACTURA", SqlDbType.Decimal); FACTURA.Direction = ParameterDirection.Output;
                SqlParameter Ventas = new SqlParameter("@VENTAS", SqlDbType.Decimal); Ventas.Direction = ParameterDirection.Output;
                SqlParameter Arqueo = new SqlParameter("@ARQUEO", 0); Arqueo.Direction = ParameterDirection.Output;
                SqlParameter FechaAp = new SqlParameter("@FECHAP", SqlDbType.DateTime); FechaAp.Direction = ParameterDirection.Output;
                SqlParameter MonInic = new SqlParameter("@MONTO", SqlDbType.Decimal); MonInic.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(FACTURA);
                cmd.Parameters.Add(Ventas);
                cmd.Parameters.Add(Arqueo);
                cmd.Parameters.Add(FechaAp);
                cmd.Parameters.Add(MonInic);
                cmd.Parameters.AddWithValue("@USUARIO", UserLoginCache.user);
                cmd.Parameters.AddWithValue("@IDUSER", UserLoginCache.NumDocum);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                CashOuput._FACTURA = Convert.ToDouble(cmd.Parameters["@FACTURA"].Value);
                CashOuput._VENTAS =  Math.Round(Convert.ToDouble(cmd.Parameters["@VENTAS"].Value));
                CashOuput._ARQUEO = Convert.ToInt32(cmd.Parameters["@ARQUEO"].Value);
                CashOuput._FCHAPE = Convert.ToDateTime(cmd.Parameters["@FECHAP"].Value);
                CashOuput._MONTO = Math.Round(Convert.ToDouble(cmd.Parameters["@MONTO"].Value));
            }
        }

        public void UpdateCash(CashEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE CAJA_CHICA SET FCHCIE = @FCHCIE, TOTVEN = @TOTVEN, 
                TOTFAC = @TOTFAC, TOTCIE = @TOTCIE,FALTAN = @FALTAN, SOBRAN = @SOBRAN, STATCJ = 'CERRADO'
                WHERE STATCJ = 'APERTURADO' AND USUARI = @USERS";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FCHCIE", Update._FCHCIE);
                cmd.Parameters.AddWithValue("@TOTVEN", Update._TOTVEN);
                cmd.Parameters.AddWithValue("@TOTFAC", Update._TOTFAC);
                cmd.Parameters.AddWithValue("@TOTCIE", Update._TOTCIE);
                cmd.Parameters.AddWithValue("@FALTAN", Update._FALTAN);
                cmd.Parameters.AddWithValue("@SOBRAN", Update._SOBRAN);
                cmd.Parameters.AddWithValue("@USERS", UserLoginCache.user);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSales()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE VENTA SET CAJSTA = 'CERRADO'
                WHERE CAJSTA = 'APERTURADO' AND IDCAJE = @IDUSERS";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IDUSERS", UserLoginCache.NumDocum);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBilling()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE FACTURA SET CAJSTA = 'CERRADO'
                WHERE CAJSTA = 'APERTURADO' AND USUARI = @USERS";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@USERS", UserLoginCache.user);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
