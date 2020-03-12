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
    public class StateDao : ConnectionToSql
    {
        public List<StateEntity> StateList(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select CODEST, ESTADO from ESTADO_PRODUCTO 
                where ESTADO like '%' + @variable + '%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader read = cmd.ExecuteReader();
                List<StateEntity> Status = new List<StateEntity>();
                while (read.Read())
                {
                    Status.Add(new StateEntity()
                    {
                        _CODEST = read.GetString(0),
                        _ESTADO = read.GetString(1)
                    });
                }
                return Status;
            }
        }
    }
}
