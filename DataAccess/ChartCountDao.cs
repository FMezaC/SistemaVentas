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
    public class ChartCountDao : ConnectionToSql
    {
        public List<ChartCountEntity> ListCounts(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(ID,'')ID, ISNULL(CTA, '')CTA, ISNULL(CUENTAS,'')CUENTAS
                from PLAN_CUENTAS WHERE CUENTAS LIKE '%'+ @CUENTAS +'%' ";
                cmd.Parameters.AddWithValue("@CUENTAS", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ChartCountEntity> MyList = new List<ChartCountEntity>();
                while (reader.Read())
                {
                    MyList.Add(new ChartCountEntity() {
                        _ID = reader.GetInt32(0),
                        _CTA = reader.GetInt32(1),
                        _DESCRIP = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }

        public void InsertCount(ChartCountEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PLAN_CUENTAS(CTA, CUENTAS) VALUES(@CTA, @CUENTAS)";
                cmd.Parameters.AddWithValue("@CTA", Insert._CTA);
                cmd.Parameters.AddWithValue("@CUENTAS", Insert._DESCRIP);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCount(ChartCountEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PLAN_CUENTAS SET CTA =  @CTA, CUENTAS = @CUENTAS WHERE ID = @ID ";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CTA", Update._CTA);
                cmd.Parameters.AddWithValue("@CUENTAS", Update._DESCRIP);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCount(ChartCountEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE PLAN_CUENTAS WHERE ID = @ID ";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<ChartCountEntity> Filter(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ID, CONVERT(VARCHAR, CTA)+' - '+CUENTAS AS CUENTAS 
                FROM PLAN_CUENTAS WHERE CTA LIKE '%'+@VARIABLE+'%' ";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ChartCountEntity> MyList = new List<ChartCountEntity>();
                while (reader.Read())
                {
                    MyList.Add(new ChartCountEntity()
                    {
                        _ID = reader.GetInt32(0),
                        _DESCRIP = reader.GetString(1)
                    });
                }
                return MyList;
            }
        }
    }
}
