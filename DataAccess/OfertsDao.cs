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
    public class OfertsDao : ConnectionToSql
    {
        public List<OfertsEntity> ListOferts(string condition)
        {
            using (var conet = GetConnection())
            {
                conet.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conet;
                cmd.CommandText = @"SELECT ds.ID, PR.CODPROD, DESCPRO, ds.ESTADOD, LI.LINEA, UMSTOCK, CODBARR, 
				DS.TIPODESCT, DS.FECHIICIO, DS.FECHFINAL, DT.CANPRO, DS.DESCUENTO, DT.PREUNT
				FROM DESCUENTOS DS INNER JOIN DETALLE_DESCUENTO DT
				ON DS.ID = DT.IDDESC INNER JOIN PRODUCTOS PR ON PR.CODPROD = DT.CODPRO
				INNER JOIN ESTADO_PRODUCTO ES ON PR.CODEST = ES.CODEST
                INNER JOIN LINEAS LI ON LI.CODLINE = PR.CODLINE
                WHERE DESCPRO like '%'+@VARIABLE+'%' "; //and DS.ESTADOD = 'ACTIVO'AND SYSDATETIME() BETWEEN FECHIICIO AND FECHFINAL";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<OfertsEntity> MyList = new List<OfertsEntity>();
                while (reader.Read())
                {
                    MyList.Add(new OfertsEntity() {
                        _ID = reader.GetInt32(0),
                        _CODPROD = reader.GetDouble(1),
                        _DESCPRO = reader.GetString(2),
                        _ESTADO = reader.GetString(3),
                        _LINEA = reader.GetString(4),
                        _UMSTOCK = reader.GetString(5),
                        _CODBARR = reader.GetString(6),
                        _TIPODESCT = reader.GetString(7),
                        _FECHIICIO = reader.GetDateTime(8),
                        _FECHFINAL = reader.GetDateTime(9),
                        _CANTPRO = reader.GetInt32(10),
                        _DESCUENTO = reader.GetDecimal(11),
                        _PREUNIT = reader.GetDecimal(12)
                    });
                }
                return MyList;
            }
        }

        public string MaxID(MaxID ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "SELECT MAX(id) +1 FROM DESCUENTOS";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID._OfertID = reader.GetInt32(0);
                }
                return Convert.ToString(ID._OfertID);
            }
        }

        public void NewOfert(OfertsEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO DESCUENTOS (ID, DESCUENTO, TIPODESCT, FECHIICIO, FECHFINAL, ESTADOD, USUARIO)
                VALUES(@ID, @DESCUENTO, @TIPODESCT, @FECHIICIO, @FECHFINAL, @ESTADOD, @USUARIO)";
                cmd.Parameters.AddWithValue("@ID", Insert._ID);
                cmd.Parameters.AddWithValue("@DESCUENTO", Insert._DESCUENTO);
                cmd.Parameters.AddWithValue("@TIPODESCT", Insert._TIPODESCT);
                cmd.Parameters.AddWithValue("@FECHIICIO", Insert._FECHIICIO);
                cmd.Parameters.AddWithValue("@FECHFINAL", Insert._FECHFINAL);
                cmd.Parameters.AddWithValue("@ESTADOD", Insert._ESTADO);
                cmd.Parameters.AddWithValue("@USUARIO", Insert._USUARIO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOfert(OfertsEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE DESCUENTOS SET DESCUENTO = @DESCUENTO, TIPODESCT = @TIPODESCT,
                FECHIICIO= @FECHIICIO, FECHFINAL = @FECHFINAL, ESTADOD = @ESTADOD,
                USUARIO = @USUARIO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@DESCUENTO", Update._DESCUENTO);
                cmd.Parameters.AddWithValue("@TIPODESCT", Update._TIPODESCT);
                cmd.Parameters.AddWithValue("@FECHIICIO", Update._FECHIICIO);
                cmd.Parameters.AddWithValue("@FECHFINAL", Update._FECHFINAL);
                cmd.Parameters.AddWithValue("@ESTADOD", Update._ESTADO);
                cmd.Parameters.AddWithValue("@USUARIO", Update._USUARIO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
