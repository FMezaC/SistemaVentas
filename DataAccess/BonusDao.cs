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
    public class BonusDao : ConnectionToSql
    { 
        public void InsertBonus(BonusEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO BONIFICACION (NUMDOC, ESTADO, TIPBON, DESCUE, FCHINI, FCHFIN, USUARI, TIPBEN)
                VALUES(@NUMDOC, @ESTADO, @TIPBON, @DESCUE, @FCHINI, @FCHFIN, @USUARI, @TIPBEN)";
                cmd.Parameters.AddWithValue("@NUMDOC", Insert._NUMDOC);
                cmd.Parameters.AddWithValue("@ESTADO", Insert._ESTADO);
                cmd.Parameters.AddWithValue("@TIPBON", Insert._TIPBON);
                cmd.Parameters.AddWithValue("@DESCUE", Insert._DESCUE);
                cmd.Parameters.AddWithValue("@FCHINI", Insert._FCHINI);
                cmd.Parameters.AddWithValue("@FCHFIN", Insert._FCHFIN);
                cmd.Parameters.AddWithValue("@USUARI", Insert._USUARI);
                cmd.Parameters.AddWithValue("@TIPBEN", Insert._TIPBEN);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<BonusEntity> ListBonus(string conditions)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(bn.IDBONF,'')IDBONF, ISNULL(cl.NUMDOC,'')NUMDOC, CL.NOMCLI +' '+
                CL.APEPAT +' '+ CL.APEMAT AS BENEFICIARIO, ISNULL(BN.ESTADO,'')ESTADO, ISNULL(BN.TIPBON,'')TIPBON, 
                ISNULL(BN.FCHINI,'')FCHINI, ISNULL(BN.FCHFIN,'')FCHFIN, ISNULL(BN.DESCUE,0)DESCUE
                FROM BONIFICACION BN INNER JOIN CLIENTES CL ON CL.NUMDOC = BN.NUMDOC
                WHERE CL.NOMCLI LIKE '%'+@VARIABLE+'%' 
                OR CL.APEPAT LIKE '%'+@VARIABLE+'%' OR CL.APEMAT LIKE '%'+@VARIABLE+'%'";
                cmd.Parameters.AddWithValue("@VARIABLE", conditions);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<BonusEntity> myList = new List<BonusEntity>();
                while (reader.Read())
                {
                    myList.Add(new BonusEntity() {
                        _IDBONF = reader.GetInt32(0),
                        _NUMDOC = reader.GetString(1),
                        _BENEFI = reader.GetString(2),
                        _ESTADO = reader.GetString(3),
                        _TIPBON = reader.GetString(4),
                        _FCHINI = reader.GetDateTime(5),
                        _FCHFIN = reader.GetDateTime(6),
                        _DESCUE = reader.GetDecimal(7)
                    });
                }
                return myList;
            }
        }

        public void UpdateBonificacion(BonusEntity Update)
        {
            using(var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE BONIFICACION SET ESTADO = @ESTADO, TIPBON = @TIPBON, 
                FCHINI = @FCHINI, FCHFIN = @FCHFIN, DESCUE = @DESCUE, USUARI = @USUARI WHERE IDBONF = @IDBONF";
                cmd.Parameters.AddWithValue("@IDBONF", Update._IDBONF);
                cmd.Parameters.AddWithValue("@ESTADO", Update._ESTADO);
                cmd.Parameters.AddWithValue("@TIPBON", Update._TIPBON);
                cmd.Parameters.AddWithValue("@FCHINI", Update._FCHINI);
                cmd.Parameters.AddWithValue("@FCHFIN", Update._FCHFIN);
                cmd.Parameters.AddWithValue("@DESCUE", Update._DESCUE);
                cmd.Parameters.AddWithValue("@USUARI", Update._USUARI);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
