using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class AreaDao : ConnectionToSql
    {
        public List<AreaEntity> AreaList(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(ID,'')ID, ISNULL(IDRB,'')IDRB, ISNULL(RUBRO,'')RUBRO 
                from RUBRO_EMPRESA where RUBRO like '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<AreaEntity> ListArea = new List<AreaEntity>();
                while (reader.Read())
                {
                    ListArea.Add( new AreaEntity()
                    {
                        _ID = reader.GetInt32(0),
                        _IDRB = reader.GetString(1),
                        _RUBRO = reader.GetString(2)
                    });
                }
                return ListArea;
            }
        }

        public void InsertArea(AreaEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO RUBRO_EMPRESA (IDRB, RUBRO) VALUES(@CODIGO, @NOMBRE)";
                cmd.Parameters.AddWithValue("@CODIGO", Insert._IDRB);
                cmd.Parameters.AddWithValue("@NOMBRE", Insert._RUBRO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatetArea(AreaEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE RUBRO_EMPRESA SET IDRB= @CODIGO,
                RUBRO = @NOMBRE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CODIGO", Update._IDRB);
                cmd.Parameters.AddWithValue("@NOMBRE", Update._RUBRO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletetArea(AreaEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE RUBRO_EMPRESA WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
