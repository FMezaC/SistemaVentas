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
    public class BranchOfficeDao: ConnectionToSql
    {
        public List<BranchOfficeEntity> ListBranch()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "SELECT IDAUSUC, DESCSU FROM SUCURSAL";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<BranchOfficeEntity> NewList = new List<BranchOfficeEntity>();
                while (reader.Read())
                {
                    NewList.Add(new BranchOfficeEntity()
                    {
                        IDAUSUC = reader.GetInt32(0),
                        DESCSU = reader.GetString(1)
                    });
                }
                return NewList;
            }
        }
    }
}
