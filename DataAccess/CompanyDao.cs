using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using CommonSupport;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CompanyDao : ConnectionToSql
    {
        public void UpdateCompany(CompanyEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE EMPRESA SET NUMRUC = @NUMRUC,NOMEMP=@NOMEMP,RASOCI=@RASOCI,
                ACTIVI=@ACTIVI,PAIS=@PAIS,PROVIN=@PROVIN,DISTRI=@DISTRI,DIRECC=@DIRECC,
                TELEF=@TELEF,MOVIL=@MOVIL,CORREO=@CORREO WHERE ID = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@NUMRUC", Update._NUMRUC);
                cmd.Parameters.AddWithValue("@NOMEMP", Update._NOMEMP);
                cmd.Parameters.AddWithValue("@RASOCI", Update._RASOCI);
                cmd.Parameters.AddWithValue("@ACTIVI", Update._ACTIVI);
                cmd.Parameters.AddWithValue("@PAIS", Update._PAIS);
                cmd.Parameters.AddWithValue("@PROVIN", Update._PROVIN);
                cmd.Parameters.AddWithValue("@DISTRI", Update._DISTRI);
                cmd.Parameters.AddWithValue("@DIRECC", Update._DIRECC);
                cmd.Parameters.AddWithValue("@TELEF", Update._TELEF);
                cmd.Parameters.AddWithValue("@MOVIL", Update._MOVIL);
                cmd.Parameters.AddWithValue("@CORREO", Update._CORREO);
                cmd.ExecuteNonQuery();
            }
        }

        public List<CompanyEntity> ListCompany()
        {
            using (var conect=GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ID,'')ID,ISNULL(NUMRUC,'')NUMRUC,ISNULL(NOMEMP,'')NOMEMP,
                ISNULL(RASOCI,'')RASOCI,ISNULL(ACTIVI,'')ACTIVI,ISNULL(PAIS,'')PAIS,
                ISNULL(PROVIN,'')PROVIN,ISNULL(DISTRI,'')DISTRI,ISNULL(DIRECC,'')DIRECC,
                ISNULL(TELEF,'')TELEF,ISNULL(MOVIL,'')MOVIL,ISNULL(CORREO,'')CORREO FROM EMPRESA ";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyEntity> MyList = new List<CompanyEntity>();
                while (reader.Read())
                {
                    MyList.Add(new CompanyEntity() {
                        _ID = reader.GetInt32(0),
                        _NUMRUC = reader.GetDouble(1),
                        _NOMEMP = reader.GetString(2),
                        _RASOCI = reader.GetString(3),
                        _ACTIVI=reader.GetString(4),
                        _PAIS = reader.GetString(5),
                        _PROVIN = reader.GetString(6),
                        _DISTRI = reader.GetString(7),
                        _DIRECC = reader.GetString(8),
                        _TELEF = reader.GetString(9),
                        _MOVIL = reader.GetString(10),
                        _CORREO = reader.GetString(11)
                    });
                }
                return MyList;
            }
        }
    }
}
