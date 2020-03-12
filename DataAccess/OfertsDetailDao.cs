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
    public class OfertsDetailDao : ConnectionToSql
    {
        public void InsertOfertDetail(OfertsDetailEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO DETALLE_DESCUENTO (IDDESC,CODPRO,CANPRO,PREUNT) 
                VALUES(@IDDESC,@CODPRO,@CANPRO,@PREUNT)";
                cmd.Parameters.AddWithValue("@IDDESC", Insert._IDDESC);
                cmd.Parameters.AddWithValue("@CODPRO", Insert._CODPRO);
                cmd.Parameters.AddWithValue("@CANPRO", Insert._CANPRO);
                cmd.Parameters.AddWithValue("@PREUNT", Insert._PREUNT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<OfertsDetailEntity> ListDetailOfert(int ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT CODPRO, PR.DESCPRO, CANPRO, PREUNT, DT.ID FROM DETALLE_DESCUENTO DT
                INNER JOIN PRODUCTOS PR ON DT.CODPRO = PR.CODPROD WHERE DT.IDDESC = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<OfertsDetailEntity> MyList = new List<OfertsDetailEntity>();
                while (reader.Read())
                {
                    MyList.Add(new OfertsDetailEntity() {
                        _CODPRO  = reader.GetString(0),
                        _DESCRIP = reader.GetString(1),
                        _CANPRO = reader.GetInt32(2),
                        _PREUNT = reader.GetDecimal(3),
                        _IDDESC = reader.GetInt32(4)
                    });
                }
                return MyList;
            }
        }

        public void DeleteDetailOfert(int ID)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "DELETE DETALLE_DESCUENTO  WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID",ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
