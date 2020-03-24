using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class SalesDao : ConnectionToSql
    {
        public int MaxID()
        {
            using (var conect = GetConnection())
            {
                int ID = 0;
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "SELECT MAX(IDVENT) +1 ID FROM VENTA";
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    ID = leer.GetInt32(0);
                }
                return ID;
            }
        }

        public void RegisterSales(SalesEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO VENTA (IDVENT, IDCLIE, IDCAJE, FECHVE,
				SUBTOT, IGV, DESCUE, TOTPAG, ESTADO, CAJSTA)
				VALUES(@IDVENT,@IDCLIE,@IDCAJE,
                @FECHVE,@SUBTOT,@IGV,@DESCUE,@TOTPAG, 'EN PROCESO', 'APERTURADO')";
                cmd.Parameters.AddWithValue("@IDVENT", Insert._IDVENT);
                cmd.Parameters.AddWithValue("@IDCLIE", Insert._IDCLIE);
                cmd.Parameters.AddWithValue("@IDCAJE", Insert._IDCAJE);
                cmd.Parameters.AddWithValue("@FECHVE", Insert._FECHVE);
                cmd.Parameters.AddWithValue("@SUBTOT", Insert._SUBTOT);
                cmd.Parameters.AddWithValue("@IGV", Insert._IGV);
                cmd.Parameters.AddWithValue("@DESCUE", Insert._DESCUE);
                cmd.Parameters.AddWithValue("@TOTPAG", Insert._TOTPAG);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSalesState(SalesEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE VENTA SET ESTADO = 'PAGADO' WHERE IDVENT = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._IDVENT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<SalesEntity> AutoComplete()
        {
            using (var connect = GetConnection())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = "select codprod, (descpro+'X'+umstock)Producto from productos";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesEntity> NewList = new List<SalesEntity>();
                while (reader.Read())
                {
                    NewList.Add(new SalesEntity()
                    {
                        _CODPROD = reader.GetDouble(0),
                        _DESCPROD = reader.GetString(1),
                    });
                }
                return NewList;
            }
        }
    }
}
