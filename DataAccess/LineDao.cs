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
    public class LineDao : ConnectionToSql
    {
        public List<LineEntity> LineList(string condition)
        {
            using(var connect = GetConnection())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = @"select CODLINE, LINEA from LINEAS
                where LINEA like  '%' + @variable + '%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<LineEntity> myList = new List<LineEntity>();
                while (reader.Read())
                {
                    myList.Add(new LineEntity() {
                        _CODLINE = reader.GetDouble(0),
                        _LINEA = reader.GetString(1)
                    });
                }
                return myList;
            }
        }
        
        public double NewID()
        {
            using (var conect = GetConnection())
            {
                double ID = 0;
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "select MAX(CODLINE) +1  NewID from LINEAS";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetDouble(0);
                }
                return ID;
            }
        }

        public void InsertLine(LineEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "INSERT INTO LINEAS(CODLINE, LINEA) VALUES(@CODI, @LINE)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODI", Insert._CODLINE);
                cmd.Parameters.AddWithValue("@LINE", Insert._LINEA);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateLine(LineEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "UPDATE LINEAS SET LINEA = @LINE WHERE CODLINE = @CODI";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODI", Update._CODLINE);
                cmd.Parameters.AddWithValue("@LINE", Update._LINEA);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLine(LineEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE LINEAS WHERE CODLINE = @CODLI";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODLI", Delete._CODLINE);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
