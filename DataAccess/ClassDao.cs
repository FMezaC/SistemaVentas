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
    public class ClassDao : ConnectionToSql
    {
        public List<ClassEntity> ListClass(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select CODCLASS, CLASES, CODLINEA, LINEA from CLASES C
                INNER JOIN LINEAS L ON C.CODLINEA = L.CODLINE 
                WHERE CLASES like  '%' + @variable + '%'";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassEntity> MyClassProduct = new List<ClassEntity>();
                while (reader.Read())
                {
                    MyClassProduct.Add(new ClassEntity()
                    {
                        _CODCLASS = reader.GetDouble(0),
                        _CLASS = reader.GetString(1),
                        _CODLINE = reader.GetDouble(2),
                        _LINEA = reader.GetString(3)
                    });
                }
                return MyClassProduct;
            }
        }

        public List<ClassEntity> FIlterClass(int condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select CODCLASS, CLASES from CLASES C
                INNER JOIN LINEAS L ON C.CODLINEA = L.CODLINE
				WHERE CODLINE  = @variable ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassEntity> MyClassProduct = new List<ClassEntity>();
                while (reader.Read())
                {
                    MyClassProduct.Add(new ClassEntity()
                    {
                        _CODCLASS = reader.GetDouble(0),
                        _CLASS = reader.GetString(1)
                    });
                }
                return MyClassProduct;
            }
        }

        public string NuevoCod(MaxID ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "select MAX(CODCLASS) + 1 as NewID from CLASES";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID._ClassID = reader[0].ToString();
                }
                return ID._ClassID;
            }
        }

        public void InsertClass(ClassEntity entity)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO CLASES(CODCLASS, CODLINEA, CLASES) 
				VALUES (@CODCLAS, @CODLINE, @CLASS)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODCLAS", entity._CODCLASS);
                cmd.Parameters.AddWithValue("@CODLINE", entity._CODLINE);
                cmd.Parameters.AddWithValue("@CLASS", entity._CLASS);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateClass(ClassEntity UpEntity)
        {
            using (var conet = GetConnection())
            {
                conet.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conet;
                cmd.CommandText = @"UPDATE CLASES SET CODLINEA = @CODLINE, CLASES = @CLASS WHERE CODCLASS = @CODCLAS";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODCLAS", UpEntity._CODCLASS);
                cmd.Parameters.AddWithValue("@CODLINE", UpEntity._CODLINE);
                cmd.Parameters.AddWithValue("@CLASS", UpEntity._CLASS);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClass(ClassEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE CLASES WHERE CODCLASS = @CODCLAS";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CODCLAS", Delete._CODCLASS);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
