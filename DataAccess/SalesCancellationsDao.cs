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
    public class SalesCancellationsDao : ConnectionToSql
    {
        public List<SalesCancellationsEntity> ListSales(DateTime fch01, DateTime fch02, string cadena)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT v.IDVENT, ISNULL(E.NOMEMP+' '+ E.APEPAT+' '+E.APEMAT,'') AS EMPLEADO,
                ISNULL(C.NOMCLI + ' ' + C.APEPAT + ' ' + C.APEMAT, '') AS CLIENTE,
				d.CODPRO, ISNULL(D.DESPRO, '')DESPRO,
                ISNULL(V.ESTADO, '')ESTADO,V.FECHVE, D.CANPRO, D.PREUNT, V.DESCUE, V.IGV, V.SUBTOT
                FROM VENTA V INNER JOIN EMPLEADOS E ON V.IDCAJE = E.NUMDOC
                INNER JOIN CLIENTES C ON C.NUMDOC = V.IDCLIE INNER JOIN DETALLE_VENTA D
                ON D.IDVENT = V.IDVENT WHERE FECHVE BETWEEN @FCH1 AND @FCH2 AND DESPRO LIKE '%' + @VARIABLE + '%' ";
                cmd.Parameters.AddWithValue("@FCH1", fch01);
                cmd.Parameters.AddWithValue("@FCH2", fch02);
                cmd.Parameters.AddWithValue("@VARIABLE", cadena);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesCancellationsEntity> MyList = new List<SalesCancellationsEntity>();
                while (reader.Read())
                {
                    MyList.Add(new SalesCancellationsEntity()
                    {
                        _IDVENT = reader.GetInt32(0),
                        _EMPLEA = reader.GetString(1),
                        _CLIENT = reader.GetString(2),
                        _CODPROD = reader.GetDouble(3),
                        _DESCRI = reader.GetString(4),
                        _ESTADO = reader.GetString(5),
                        _FECHAV = reader.GetDateTime(6),
                        _CANPRO = reader.GetInt32(7),
                        _PREUNI = reader.GetDouble(8),
                        _DESCUE = reader.GetDouble(9),
                        _IMPUES = reader.GetDouble(10),
                        _SUBTOT = reader.GetDouble(11)
                    });
                }
                return MyList;
            }
        }

        //public void UpdateCancellation(SalesCancellationsEntity Update)
        //{
        //    using (var conect = GetConnection())
        //    {
        //        conect.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conect;
        //        cmd.CommandText = "";
        //        cmd.Parameters.AddWithValue("",Update._CODPROD);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //    }
        //}

    }
}
