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
    public class PurchaseDao : ConnectionToSql
    {
        public void InsertPurchase(PurcharseEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PEDIDOS (NUMPED, IDCUENT, IDPROVE, IDTIPPA, IDTIPMO,
                GLOSA, FCHEMI, FCHVEN, FCHREG, ESTADO, SUBTOT, PEDIGV, DESCUE, TOTPAG)
                VALUES (@NUMPED, @IDCUENT, @IDPROVE, @IDTIPPA, @IDTIPMO, @GLOSA, 
                @FCHEMI, @FCHVEN, SYSDATETIME(), @ESTADO, @SUBTOT, @PEDIGV, @DESCUE, @TOTPAG)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NUMPED", Entity.NUMPED);
                cmd.Parameters.AddWithValue("@IDCUENT", Entity.IDCUENT);
                cmd.Parameters.AddWithValue("@IDPROVE", Entity.IDPROVE);
                cmd.Parameters.AddWithValue("@IDTIPPA", Entity.IDTIPPA);
                cmd.Parameters.AddWithValue("@IDTIPMO", Entity.IDTIPMO);
                cmd.Parameters.AddWithValue("@GLOSA", Entity.GLOSA);
                cmd.Parameters.AddWithValue("@FCHEMI", Entity.FCHEMI);
                cmd.Parameters.AddWithValue("@FCHVEN", Entity.FCHVEN);
                cmd.Parameters.AddWithValue("@ESTADO", Entity.ESTADO);
                cmd.Parameters.AddWithValue("@SUBTOT", Entity.SUBTOT);
                cmd.Parameters.AddWithValue("@PEDIGV", Entity.PEDIGV);
                cmd.Parameters.AddWithValue("@DESCUE", Entity.DESCUE);
                cmd.Parameters.AddWithValue("@TOTPAG", Entity.TOTPAG);
                cmd.ExecuteNonQuery();
            }
        }

        public List<PurcharseEntity> ListPurcharse(DateTime StarDate, DateTime EndDate)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT pd.NUMPED, dtp.CODPRO, dtp.DESCRI, pd.IDPROVE, PRO.EMPRUB, 
                CU.NUMCUEN, CU.NOMBUSU, CAST(PD.FCHEMI as date)EMICION,CAST(PD.FCHVEN AS date)VENCIMIENTO,
                PD.ESTADO, DTP.UNIMED, DTP.CANTID, CAST(DTP.PREUNI as decimal(18,2)), CAST(DTP.IMPIGV as decimal(18, 2)),
                cast((DTP.CANTID*DTP.PREUNI)+DTP.IMPIGV as decimal(18,2)) TOTAL FROM PEDIDOS PD
                INNER JOIN DETALLE_PEDIDO DTP ON PD.NUMPED = DTP.IDPEDI
                INNER JOIN PROVEEDORES PRO ON PD.IDPROVE = PRO.IDEMP
                INNER JOIN CUENTAS CU ON CU.IDCUENT = PD.IDCUENT
                WHERE CAST(PD.FCHVEN AS DATE) BETWEEN @STARDATE AND @ENDDATE";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@STARDATE", StarDate);
                cmd.Parameters.AddWithValue("@ENDDATE", EndDate);
                SqlDataReader reader = cmd.ExecuteReader();
                List<PurcharseEntity> MyList = new List<PurcharseEntity>();
                while (reader.Read())
                {
                    MyList.Add(new PurcharseEntity()
                    {
                        NUMPED = reader.GetInt32(0),
                        CODPROD = reader.GetString(1),
                        DESPROD = reader.GetString(2),
                        IDPROVE = reader.GetInt32(3),
                        EMPRESA = reader.GetString(4),
                        NUMCUET = reader.GetString(5),
                        USCUENT = reader.GetString(6),
                        FCHEMI = reader.GetDateTime(7),
                        FCHVEN = reader.GetDateTime(8),
                        ESTADO = reader.GetString(9),
                        UNIMEDI = reader.GetString(10),
                        CANTPRO = reader.GetInt32(11),
                        PREUNIT = reader.GetDecimal(12),
                        IMPUEST = reader.GetDecimal(13),
                        TOTALES = reader.GetDecimal(14)
                    });
                }
                return MyList;
            }
        }
    }
}
