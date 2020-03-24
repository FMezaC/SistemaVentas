using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class EmployeesDao : ConnectionToSql
    {
        public List<EmployeesEntity> ListEmployee(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(CODEMP,'')CODEMP,ISNULL(T.IDDOC,'') DOCUMENTO,
                ISNULL(NUMDOC,'') NUMDOC,ISNULL(NOMEMP,'')NOMEMP,
                ISNULL(APEPAT,'')APEPAT,ISNULL(APEMAT,'')APEMAT,
                ISNULL(FECHNA,'')FECHNA,ISNULL(FECHCO,'')FECHCO,
                ISNULL(G.GENERO,'')GENERO,ISNULL(DIRECC,'')DIRECC,
				ISNULL(PA.NOMPAI,'')NOMPAI,ISNULL(PR.NOMPRO,'')NOMPRO,
                ISNULL(D.NOMDIS,'')DISTRITO,ISNULL(C.ESTADO,'')ESTADO,
                ISNULL(NUMCEL,'')NUMCEL,ISNULL(CORREO,'')CORREO,
                ISNULL(NUMHIJ,'')NUMHIJ,ISNULL(SALARI,'')SALARI, 
				ISNULL(UT.TIPOUS,'')TIPOUS, ISNULL(USUARI,'')USUARI,ISNULL(US.UPASSW,'')UPASSW,
				ISNULL(SU.DESCSU,'')SUCURSAL
                FROM EMPLEADOS E INNER JOIN GENERO G ON E.IDGEN = G.CODGEN
                INNER JOIN DISTRITO D ON E.IDDIST = D.IDDIS INNER JOIN ESTADO_CIVIL C 
                ON E.IDESTCVI = C.ESTCOD INNER JOIN TIP_DOCUMENTO T ON E.IDTIPDOC = T.IDDOC
				INNER JOIN PROVINCIA PR ON D.IDPROV = PR.IDPR INNER JOIN PAIS PA ON PA.ID = PR.IDPAI
				INNER JOIN USUARIOS US ON E.NUMDOC = US.NUMDNI INNER JOIN TIP_USUARIO UT ON US.IDTIPO = UT.ID
				INNER JOIN SUCURSAL SU ON E.IDAUSUC = SU.IDAUSUC
				WHERE NOMEMP LIKE '%'+@VARIBLE+'%' OR APEPAT LIKE '%'+@VARIBLE+'%' OR APEMAT LIKE '%'+@VARIBLE+'%' ";
                cmd.Parameters.AddWithValue("@VARIBLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployeesEntity> MyList = new List<EmployeesEntity>();
                while (reader.Read())
                {
                    MyList.Add(new EmployeesEntity()
                    {
                        _CODEMP = reader.GetInt32(0),
                        _IDTIPD = reader.GetString(1),
                        _NUMDOC = reader.GetString(2),
                        _NOMEMP = reader.GetString(3),
                        _APEPAT = reader.GetString(4),
                        _APEMAT = reader.GetString(5),
                        _FECHNA = reader.GetDateTime(6),
                        _FECHCO = reader.GetDateTime(7),
                        _IDGENE = reader.GetString(8),
                        _DIRECC = reader.GetString(9),
                        _PAIS = reader.GetString(10),
                        _PROVIN = reader.GetString(11),
                        _DISTRIT = reader.GetString(12),
                        _IDESTC = reader.GetString(13),
                        _NUMCEL = reader.GetString(14),
                        _CORREO = reader.GetString(15),
                        _NUMHIJ = reader.GetInt32(16),
                        _SALARI = reader.GetDouble(17),
                        _TIPUSER = reader.GetString(18),
                        _USUARIO = reader.GetString(19),
                        _UPASSW = reader.GetString(20),
                        _SUCUR = reader.GetString(21)
                    });
                }
                return MyList;
            }
        }

        public void InsertEmployees(EmployeesEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO EMPLEADOS (IDTIPDOC, NUMDOC, NOMEMP, APEPAT, APEMAT, FECHNA, FECHCO,
				IDGEN, DIRECC, IDDIST, IDESTCVI, NUMCEL, CORREO, NUMHIJ, SALARI, EMPIMG, IDAUSUC)
				VALUES(@IDTIPDOC,@NUMDOC,@NOMEMP,@APEPAT,@APEMAT,@FECHNA,
				@FECHCO,@IDGEN,@DIRECC,@IDDIST,@IDESTCVI,@NUMCEL,@CORREO,@NUMHIJ,@SALARI,NULL, @IDAUSUC)";
                cmd.Parameters.AddWithValue("@IDTIPDOC", Insert._IDTIPD);
                cmd.Parameters.AddWithValue("@NUMDOC", Insert._NUMDOC);
                cmd.Parameters.AddWithValue("@NOMEMP", Insert._NOMEMP);
                cmd.Parameters.AddWithValue("@APEPAT", Insert._APEPAT);
                cmd.Parameters.AddWithValue("@APEMAT", Insert._APEMAT);
                cmd.Parameters.AddWithValue("@FECHNA", Insert._FECHNA);
                cmd.Parameters.AddWithValue("@FECHCO", Insert._FECHCO);
                cmd.Parameters.AddWithValue("@IDGEN", Insert._IDGENE);
                cmd.Parameters.AddWithValue("@DIRECC", Insert._DIRECC);
                cmd.Parameters.AddWithValue("@IDDIST", Insert._IDDIST);
                cmd.Parameters.AddWithValue("@IDESTCVI", Insert._IDESTC);
                cmd.Parameters.AddWithValue("@NUMCEL", Insert._NUMCEL);
                cmd.Parameters.AddWithValue("@CORREO", Insert._CORREO);
                cmd.Parameters.AddWithValue("@NUMHIJ", Insert._NUMHIJ);
                cmd.Parameters.AddWithValue("@SALARI", Insert._SALARI);
                cmd.Parameters.AddWithValue("@IDAUSUC", Insert._IDAUSUC);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmployees(EmployeesEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE EMPLEADOS
                SET IDTIPDOC = @IDTIPDOC,NUMDOC= @NUMDOC, NOMEMP = @NOMEMP, APEPAT = @APEPAT, APEMAT = @APEMAT,
                FECHNA = @FECHNA, FECHCO = @FECHCO, IDGEN = @IDGEN, DIRECC = @DIRECC, IDDIST = @IDDIST, IDESTCVI = @IDESTCVI,
                NUMCEL = @NUMCEL, CORREO = @CORREO, NUMHIJ = @NUMHIJ, SALARI = @SALARI, IDAUSUC=@IDAUSUC
				WHERE CODEMP = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._CODEMP);
                cmd.Parameters.AddWithValue("@IDTIPDOC", Update._IDTIPD);
                cmd.Parameters.AddWithValue("@NUMDOC", Update._NUMDOC);
                cmd.Parameters.AddWithValue("@NOMEMP", Update._NOMEMP);
                cmd.Parameters.AddWithValue("@APEPAT", Update._APEPAT);
                cmd.Parameters.AddWithValue("@APEMAT", Update._APEMAT);
                cmd.Parameters.AddWithValue("@FECHNA", Update._FECHNA);
                cmd.Parameters.AddWithValue("@FECHCO", Update._FECHCO);
                cmd.Parameters.AddWithValue("@IDGEN", Update._IDGENE);
                cmd.Parameters.AddWithValue("@DIRECC", Update._DIRECC);
                cmd.Parameters.AddWithValue("@IDDIST", Update._IDDIST);
                cmd.Parameters.AddWithValue("@IDESTCVI", Update._IDESTC);
                cmd.Parameters.AddWithValue("@NUMCEL", Update._NUMCEL);
                cmd.Parameters.AddWithValue("@CORREO", Update._CORREO);
                cmd.Parameters.AddWithValue("@NUMHIJ", Update._NUMHIJ);
                cmd.Parameters.AddWithValue("@SALARI", Update._SALARI);
                cmd.Parameters.AddWithValue("@IDAUSUC", Update._IDAUSUC);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployees(EmployeesEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE EMPLEADOS WHERE CODEMP = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._CODEMP);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
