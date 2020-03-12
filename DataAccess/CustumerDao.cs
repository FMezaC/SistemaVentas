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
    public class CustumerDao : ConnectionToSql
    {
        public List<CustumerEntity> ListCustumer(string condition)
        {
            using(var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(CODCLI,'')Codigo, ISNULL(TIPDOC, '')TIPDOC, ISNULL(NUMDOC, '')NUMDOC, ISNULL(NOMCLI, '')nombre,
                ISNULL(APEPAT, '')ApePater, ISNULL(APEMAT, '')ApeMate, ISNULL(FECHNA, '')FechaN,
                ISNULL(GE.GENERO, '')Genero, ISNULL(SC.ESTADO, '')ESTADO, ISNULL(DIRECC, '')Direccion,
                ISNULL(PA.NOMPAI,'')NOMPAI, ISNULL(PR.NOMPRO,'')NOMPRO, ISNULL(DT.NOMDIS, '')Distrito, 
				ISNULL(CEMAIL, '')Correo,ISNULL(NUMCEL, '')Numero, ISNULL(OCUPAS, '')Ocupas
                from CLIENTES CL INNER JOIN GENERO GE ON CL.GENERO = GE.CODGEN INNER JOIN ESTADO_CIVIL SC ON
				CL.ESTCVI = SC.ESTCOD INNER JOIN DISTRITO DT ON CL.DISTRI = DT.NOMDIS INNER JOIN PROVINCIA PR 
				ON PR.IDPR = DT.IDPROV INNER JOIN PAIS PA ON PA.ID = PR.IDPAI where NOMCLI like '%'+ @variable+'%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<CustumerEntity> MyCustumerLst = new List<CustumerEntity>();
                while (reader.Read())
                {
                    MyCustumerLst.Add(new CustumerEntity()
                    {
                        _CODCLI = reader.GetInt32(0),
                        _TIPDOC = reader.GetString(1),
                        _NUMDNI = reader.GetString(2),
                        _NOMCLI = reader.GetString(3),
                        _APEPAT = reader.GetString(4),
                        _APEMAT = reader.GetString(5),
                        _FECHNA = reader.GetDateTime(6),
                        _GENERO = reader.GetString(7),
                        _ESTCVI = reader.GetString(8),
                        _DIRECC = reader.GetString(9),
                        _NOMPAI = reader.GetString(10),
                        _NOMPRO = reader.GetString(11),
                        _DISTRI = reader.GetString(12),
                        _CEMAIL = reader.GetString(13),
                        _NUMCEL = reader.GetString(14),
                        _OCUPAS = reader.GetString(15)
                    });
                }
                return MyCustumerLst;
            }
        }

        public void InsertCustumer(CustumerEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO CLIENTES (TIPDOC, NUMDOC, NOMCLI, APEPAT, APEMAT, FECHNA,
				GENERO, ESTCVI, DIRECC, DISTRI, CEMAIL, NUMCEL, OCUPAS)
				VALUES(@TIPDOC,@NUMDOC,@NOMCLI,@APEPAT,@APEMAT,
                @FECHNA,@GENERO,@ESTCVI,@DIRECC,@DISTRI,@CEMAIL,@NUMCEL,@OCUPAS)";
                cmd.Parameters.AddWithValue("@TIPDOC", Insert._TIPDOC);
                cmd.Parameters.AddWithValue("@NUMDOC", Insert._NUMDNI);
                cmd.Parameters.AddWithValue("@NOMCLI", Insert._NOMCLI);
                cmd.Parameters.AddWithValue("@APEPAT", Insert._APEPAT);
                cmd.Parameters.AddWithValue("@APEMAT", Insert._APEMAT);
                cmd.Parameters.AddWithValue("@FECHNA", Insert._FECHNA);
                cmd.Parameters.AddWithValue("@GENERO", Insert._GENERO);
                cmd.Parameters.AddWithValue("@ESTCVI", Insert._ESTCVI);
                cmd.Parameters.AddWithValue("@DIRECC", Insert._DIRECC);
                cmd.Parameters.AddWithValue("@DISTRI", Insert._DISTRI);
                cmd.Parameters.AddWithValue("@CEMAIL", Insert._CEMAIL);
                cmd.Parameters.AddWithValue("@NUMCEL", Insert._NUMCEL);
                cmd.Parameters.AddWithValue("@OCUPAS", Insert._OCUPAS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustumer(CustumerEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE CLIENTES SET TIPDOC= @TIPDOC, NUMDOC = @NUMDOC,NOMCLI=@NOMCLI,
                APEPAT=@APEPAT,APEMAT=@APEMAT,FECHNA=@FECHNA,GENERO=@GENERO,ESTCVI=@ESTCVI,DIRECC=@DIRECC,
                DISTRI=@DISTRI,CEMAIL=@CEMAIL,NUMCEL=@NUMCEL,OCUPAS=@OCUPAS WHERE CODCLI = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._CODCLI);
                cmd.Parameters.AddWithValue("@TIPDOC", Update._TIPDOC);
                cmd.Parameters.AddWithValue("@NUMDOC", Update._NUMDNI);
                cmd.Parameters.AddWithValue("@NOMCLI", Update._NOMCLI);
                cmd.Parameters.AddWithValue("@APEPAT", Update._APEPAT);
                cmd.Parameters.AddWithValue("@APEMAT", Update._APEMAT);
                cmd.Parameters.AddWithValue("@FECHNA", Update._FECHNA);
                cmd.Parameters.AddWithValue("@GENERO", Update._GENERO);
                cmd.Parameters.AddWithValue("@ESTCVI", Update._ESTCVI);
                cmd.Parameters.AddWithValue("@DIRECC", Update._DIRECC);
                cmd.Parameters.AddWithValue("@DISTRI", Update._DISTRI);
                cmd.Parameters.AddWithValue("@CEMAIL", Update._CEMAIL);
                cmd.Parameters.AddWithValue("@NUMCEL", Update._NUMCEL);
                cmd.Parameters.AddWithValue("@OCUPAS", Update._OCUPAS);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

    }
}
