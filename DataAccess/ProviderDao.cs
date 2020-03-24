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
    public class ProviderDao : ConnectionToSql
    {
        public List<ProviderEntity> ListProviders(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select isnull(IDEMP,'')ID, ISNULL(RUC,'')RUC, isnull(EMPRUB,'')Empresa,
                isnull(EMPDIR,'')DIreccion, isnull(CODPOST,'')CodPostal, ISNULL(pa.NOMPAI,'')Pais, isnull(NOMPRO,'')Provincia, 
				isnull(NOMDIS,'')Ciudad,isnull(TELEFONO,'')Telefono, isnull(EMAIL,'')Correo, isnull(AM.ACTEMP,'')Actividad,
				ISNULL(RU.RUBRO,'')Rubro from PROVEEDORES PR INNER JOIN DISTRITO D ON PR.CIUDAD = D.NOMDIS INNER JOIN PROVINCIA P 
				ON P.IDPR = D.IDPROV INNER JOIN PAIS PA ON PA.ID = P.IDPAI INNER JOIN ACTIVIDAD_EMRESARIAL AM ON AM.ID = PR.IDACTEMP
				INNER JOIN RUBRO_EMPRESA RU ON RU.ID = PR.RUBRO
                WHERE EMPRUB like '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProviderEntity> ListProviders = new List<ProviderEntity>();
                while (reader.Read())
                {
                    ListProviders.Add(new ProviderEntity() {
                        _IDEMP = reader.GetDouble(0),
                        _RUC = reader.GetDouble(1),
                        _EMPRUB = reader.GetString(2),
                        _EMPDIR = reader.GetString(3),
                        _CODPOST = reader.GetDouble(4),
                        _PAIS = reader.GetString(5),
                        _PROVEMP = reader.GetString(6),
                        _CIUDAD = reader.GetString(7),
                        _TELEF = reader.GetString(8),
                        _EMAIL = reader.GetString(9),
                        _ACTEMP = reader.GetString(10),
                        _RUBRO =  reader.GetString(11)
                    });
                }
                return ListProviders;
            }
        }

        public double MaxID()
        {
            using (var conect = GetConnection())
            {
                double ID = 0;
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select MAX(IDEMP)+1 as MaxID from PROVEEDORES";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetDouble(0);
                }
                return ID;
            }
        }

        public void InsertProvide(ProviderEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PROVEEDORES (IDEMP, RUC, EMPRUB, EMPDIR,
				CODPOST, CIUDAD, PROVEMP, TELEFONO, EMAIL, IDACTEMP, RUBRO)
				VALUES(@IDEMP, @RUC, @EMPRUB, @EMPDIR, @CODPOST,
				@CIUDAD, @PROVEMP, @TELEFONO, @EMAIL, @IDACTEMP, @RUBRO)";
                cmd.Parameters.AddWithValue("@IDEMP", Insert._IDEMP);
                cmd.Parameters.AddWithValue("@RUC", Insert._RUC);
                cmd.Parameters.AddWithValue("@EMPRUB", Insert._EMPRUB);
                cmd.Parameters.AddWithValue("@EMPDIR", Insert._EMPDIR);
                cmd.Parameters.AddWithValue("@CODPOST", Insert._CODPOST);
                cmd.Parameters.AddWithValue("@CIUDAD", Insert._CIUDAD);
                cmd.Parameters.AddWithValue("@PROVEMP", Insert._PROVEMP);
                cmd.Parameters.AddWithValue("@TELEFONO", Insert._TELEF);
                cmd.Parameters.AddWithValue("@EMAIL", Insert._EMAIL);
                cmd.Parameters.AddWithValue("@ACTEMP", Insert._IDACTEMP);
                cmd.Parameters.AddWithValue("@RUBRO", Insert._IDRUB);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProvider(ProviderEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PROVEEDORES SET RUC = @RUC, EMPRUB = @EMPRUB, EMPDIR = @EMPDIR,
                CODPOST = @CODPOST, CIUDAD = @CIUDAD, PROVEMP = @PROVEMP, TELEFONO = @TELEFONO, 
                EMAIL = @EMAIL, IDACTEMP = @ACTEMP, RUBRO = @RUBRO WHERE IDEMP = @IDEMP";
                cmd.Parameters.AddWithValue("@IDEMP", Update._IDEMP);
                cmd.Parameters.AddWithValue("@RUC", Update._RUC);
                cmd.Parameters.AddWithValue("@EMPRUB", Update._EMPRUB);
                cmd.Parameters.AddWithValue("@EMPDIR", Update._EMPDIR);
                cmd.Parameters.AddWithValue("@CODPOST", Update._CODPOST);
                cmd.Parameters.AddWithValue("@CIUDAD", Update._CIUDAD);
                cmd.Parameters.AddWithValue("@PROVEMP", Update._PROVEMP);
                cmd.Parameters.AddWithValue("@TELEFONO", Update._TELEF);
                cmd.Parameters.AddWithValue("@EMAIL", Update._EMAIL);
                cmd.Parameters.AddWithValue("@ACTEMP", Update._IDACTEMP);
                cmd.Parameters.AddWithValue("@RUBRO", Update._IDRUB);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
