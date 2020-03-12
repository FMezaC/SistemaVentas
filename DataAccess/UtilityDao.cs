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
    public class UtilityDao : ConnectionToSql
    {
        public List<UtilityEntity> ListUtility(string condition)
        {
            using (var conect = GetConnection() )
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(IDCAJA,'')IDCAJA,ISNULL(IDREVL,'')IDREVL,ISNULL(FHINGR,'')FHINGR,
                ISNULL(IDDOC,'')IDDOC,ISNULL(numDoc,'')numDoc,ISNULL(idDescripcion,'')idDescripcion,
                ISNULL(idDocing,'')idDocing,ISNULL(nDescripcion_caja,'')nDescripcion_caja,
                ISNULL(idCentroCoto,'')idCentroCoto,ISNULL(egreso,'')egreso,ISNULL(tot_egresos,'')tot_egresos,
                ISNULL(idTipPago,'')idTipPago,ISNULL(mov_efectivo,'')mov_efectivo,ISNULL(saldo_efectivo,'')saldo_efectivo,
                ISNULL(mov_banco,'')mov_banco,ISNULL(saldo_banco,'')saldo_banco,ISNULL(saldo_total,'')saldo_total,
                ISNULL(observacion,'')observacion,ISNULL(dia,'')dia,ISNULL(estado,'')estado,
                ISNULL(estado_ing,'')estado_ing,ISNULL(estado_transferencia,'')estado_transferencia,
                ISNULL(estado_comision,'')estado_comision,ISNULL(estado_rembolso,'')estado_rembolso
                from UTILERIA where nDescripcion_caja like  '%' + @variable + '%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UtilityEntity> MyList = new List<UtilityEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UtilityEntity() {
                        _IDCAJA = reader.GetInt32(0),
                        _IDREVL = reader.GetInt32(1),
                        _FHINGR = reader.GetDateTime(2),
                        _IDDOC = reader.GetInt32(3),
                        _numDoc = reader.GetInt32(4),
                        _idDescripcion = reader.GetInt32(5),
                        _idDocing = reader.GetInt32(6),
                        _nDescripcion_caja = reader.GetString(7),
                        _idCentroCoto = reader.GetInt32(8),
                        _egreso = reader.GetString(9),
                        _tot_egresos = reader.GetString(10),
                        _idTipPago = reader.GetInt32(11),
                        _mov_efectivo = reader.GetString(12),
                        _saldo_efectivo = reader.GetString(13),
                        _mov_banco = reader.GetString(14),
                        _saldo_banco = reader.GetString(15),
                        _saldo_total = reader.GetString(16),
                        _observacion = reader.GetString(17),
                        _dia = reader.GetString(18),
                        _estado = reader.GetInt32(19),
                        _estado_ing = reader.GetInt32(20),
                        _estado_transferencia = reader.GetInt32(21),
                        _estado_comision = reader.GetInt32(22),
                        _estado_rembolso = reader.GetInt32(23)
                    });
                }
                return MyList;
            }
        }
    }
}
