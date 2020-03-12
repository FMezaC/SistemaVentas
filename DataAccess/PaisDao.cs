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
    public class PaisDao : ConnectionToSql
    {
        public List<PaisEntity> ListaPais(string condition)
        {
            using (var conect= GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(ID,'')ID, ISNULL(CODPAI,'')CODPAI, ISNULL(NOMPAI,'')NOMPAI
                from PAIS where NOMPAI like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<PaisEntity> PaisList = new List<PaisEntity>();
                while (reader.Read())
                {
                    PaisList.Add(new PaisEntity() {
                        ID = reader.GetInt32(0),
                        CODPAI = reader.GetString(1),
                        NOMPAI = reader.GetString(2)
                    });
                }
                return PaisList;
            }
        }

        public void RegisterPais(PaisEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "INSERT INTO PAIS(CODPAI, NOMPAI) VALUES (@CODIGO, @NOMBRE)";
                cmd.Parameters.AddWithValue("@CODIGO", Entity.CODPAI);
                cmd.Parameters.AddWithValue("@NOMBRE", Entity.NOMPAI);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePais(PaisEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "UPDATE PAIS SET CODPAI = @CODIGO, NOMPAI = @NOMBRE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@CODIGO", Entity.CODPAI);
                cmd.Parameters.AddWithValue("@NOMBRE", Entity.NOMPAI);
                cmd.Parameters.AddWithValue("@ID", Entity.ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePais(PaisEntity Entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE PAIS WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Entity.ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
