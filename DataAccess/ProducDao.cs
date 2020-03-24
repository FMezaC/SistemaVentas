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
    public class ProducDao : ConnectionToSql
    {
        public List<ProductEntity> ProductList(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"select ISNULL(CODPROD,'') Codigo,ISNULL (DESCPRO,'') Descripcion,
				ISNULL(PS.DESCPROCE,'') PROCEDENCIA,isnull(codbarr,'')CodBarra,
                ISNULL (UMSTOCK,'') [Unidad Medida],ISNULL (VOLPROD,'') Volumen, ISNULL(ES.ESTADO,'') ESTADO,
                ISNULL (FECHPROD,'') [Fecha Produccion],ISNULL (FECHVEN,'') [Fecha Vencimiento],
                ISNULL(LI.LINEA,'') LINEA,ISNULL(CL.CLASES,'')CLASE, 
				PREUNIT, ISNULL (FACTOR,'') Factor, ISNULL (CANTPRO,'') CantDisp, ISNULL(CANTRES,'')CanReser, 
				FACTOR * CANTPRO AS UNIDADES, IMPUEST from PRODUCTOS PR
				INNER JOIN ESTADO_PRODUCTO ES ON PR.CODEST = ES.CODEST
				INNER JOIN LINEAS LI ON PR.CODLINE = LI.CODLINE 
				INNER JOIN PROCED_PRODUC PS ON PR.PROCEDENCIA = PS.CODPROCE
				INNER JOIN CLASES CL ON PR.CODCLASS = CL.CODCLASS
				where DESCPRO like '%' + @variable + '%' ";
                cmd.Parameters.AddWithValue("@variable", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductEntity> ListProduct = new List<ProductEntity>();
                while (reader.Read())
                {
                    ListProduct.Add(new ProductEntity()
                    {
                        _CODPROD = reader.GetDouble(0),
                        _DESCPRO = reader.GetString(1),
                        _PROCEDENCIA = reader.GetString(2),
                        _CODBARR = reader.GetString(3),
                        _UMSTOCK = reader.GetString(4),
                        _VOLPROD = reader.GetDouble(5),
                        _CODEST = reader.GetString(6),
                        _FECHPROD = reader.GetDateTime(7),
                        _FECHVEN = reader.GetDateTime(8),
                        _CODLINE = reader.GetString(9),
                        _CODCLASS = reader.GetString(10),
                        _PREUNIT = reader.GetDecimal(11),
                        _FACTOR = reader.GetString(12),
                        _CANTPRO = reader.GetInt32(13),
                        _CANTRES = reader.GetDouble(14),
                        _UNIDADES = reader.GetInt32(15),
                        _IMPUEST = reader.GetDecimal(16)
                    });
                }
                return ListProduct;
            }
        }

        public double ProductID()
        {
            using (var conect = GetConnection())
            {
                double NewID = 0;
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = "select MAX(CODPROD) + 1 as ID from PRODUCTOS";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NewID = reader.GetDouble(0);
                }
                return NewID;
            }
        }

        public void InsertProduct(ProductEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PRODUCTOS (CODPROD,DESCPRO,CANTPRO,UMSTOCK,VOLPROD,CODEST,CANTRES,
                FECHVEN, FECHPROD,FACTOR,CODLINE,PROCEDENCIA,CODBARR,CODCLASS,PREUNIT,IMPUEST)
                VALUES(@CODPROD,@DESCPRO,@CANTPRO,@UMSTOCK,@VOLPROD,@CODEST, @CANTRES,
                @FECHVEN,@FECHPROD,@FACTOR,@CODLINE,@PROCEDENCIA,@CODBARR,@CODCLASS,@PREUNIT,@IMPUEST)";
                cmd.Parameters.AddWithValue("@CODPROD", Insert._CODPROD);
                cmd.Parameters.AddWithValue("@DESCPRO", Insert._DESCPRO);
                cmd.Parameters.AddWithValue("@CANTPRO", Insert._CANTPRO);
                cmd.Parameters.AddWithValue("@UMSTOCK", Insert._UMSTOCK);
                cmd.Parameters.AddWithValue("@VOLPROD", Insert._VOLPROD);
                cmd.Parameters.AddWithValue("@CODEST", Insert._CODEST);
                cmd.Parameters.AddWithValue("@CANTRES", Insert._CANTRES);
                cmd.Parameters.AddWithValue("@FECHVEN", Insert._FECHVEN);
                cmd.Parameters.AddWithValue("@FECHPROD", Insert._FECHPROD);
                cmd.Parameters.AddWithValue("@FACTOR", Insert._FACTOR);
                cmd.Parameters.AddWithValue("@CODLINE", Insert._CODLINE);
                cmd.Parameters.AddWithValue("@PROCEDENCIA", Insert._PROCEDENCIA);
                cmd.Parameters.AddWithValue("@CODBARR", Insert._CODBARR);
                cmd.Parameters.AddWithValue("@CODCLASS", Insert._CODCLASS);
                cmd.Parameters.AddWithValue("@PREUNIT", Insert._PREUNIT);
                cmd.Parameters.AddWithValue("@IMPUEST", Insert._IMPUEST);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(ProductEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PRODUCTOS SET DESCPRO = @DESCPRO, CANTPRO = @CANTPRO, UMSTOCK = @UMSTOCK,
                VOLPROD = @VOLPROD, CODEST = @CODEST, CANTRES = @CANTRES, FECHVEN = @FECHVEN, FECHPROD = @FECHPROD,
                FACTOR = @FACTOR, CODLINE = @CODLINE, PROCEDENCIA = @PROCEDENCIA, CODBARR = @CODBARR, 
                CODCLASS = @CODCLASS, PREUNIT = @PREUNIT, IMPUEST = @IMPUEST WHERE CODPROD = @CODPROD";
                cmd.Parameters.AddWithValue("@CODPROD", Update._CODPROD);
                cmd.Parameters.AddWithValue("@DESCPRO", Update._DESCPRO);
                cmd.Parameters.AddWithValue("@CANTPRO", Update._CANTPRO);
                cmd.Parameters.AddWithValue("@UMSTOCK", Update._UMSTOCK);
                cmd.Parameters.AddWithValue("@VOLPROD", Update._VOLPROD);
                cmd.Parameters.AddWithValue("@CODEST", Update._CODEST);
                cmd.Parameters.AddWithValue("@CANTRES", Update._CANTRES);
                cmd.Parameters.AddWithValue("@FECHVEN", Update._FECHVEN);
                cmd.Parameters.AddWithValue("@FECHPROD", Update._FECHPROD);
                cmd.Parameters.AddWithValue("@FACTOR", Update._FACTOR);
                cmd.Parameters.AddWithValue("@CODLINE", Update._CODLINE);
                cmd.Parameters.AddWithValue("@PROCEDENCIA", Update._PROCEDENCIA);
                cmd.Parameters.AddWithValue("@CODBARR", Update._CODBARR);
                cmd.Parameters.AddWithValue("@CODCLASS", Update._CODCLASS);
                cmd.Parameters.AddWithValue("@PREUNIT", Update._PREUNIT);
                cmd.Parameters.AddWithValue("@IMPUEST", Update._IMPUEST);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public List<ProductEntity> FilterProduct(double condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT CODPROD, DESCPRO, E.ESTADO, UMSTOCK, PREUNIT, CODBARR, FACTOR, CANTRES, IMPUEST,
                CANTPRO FROM PRODUCTOS P INNER JOIN ESTADO_PRODUCTO E ON P.CODEST = E.CODEST
                WHERE CODBARR = @ID OR CODPROD = @ID";
                cmd.Parameters.AddWithValue("@ID", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductEntity> ListProduct = new List<ProductEntity>();
                while (reader.Read())
                {
                    ListProduct.Add(new ProductEntity()
                    {
                        _CODPROD = reader.GetDouble(0),
                        _DESCPRO = reader.GetString(1),
                        _CODEST = reader.GetString(2),
                        _UMSTOCK = reader.GetString(3),
                        _PREUNIT = reader.GetDecimal(4),
                        _CODBARR = reader.GetString(5),
                        _FACTOR = reader.GetString(6),
                        _CANTRES = reader.GetDouble(7),
                        _IMPUEST = reader.GetDecimal(8),
                        _CANTPRO = reader.GetInt32(9)
                    });
                }
                return ListProduct;
            }
        }

        public void UpdateStock(ProductEntity Stock)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PRODUCTOS SET CANTPRO = @STOCK WHERE CODBARR = @ID OR CODPROD = @ID";
                cmd.Parameters.AddWithValue("@ID", Stock._CODPROD);
                cmd.Parameters.AddWithValue("@STOCK", Stock._CANTPRO);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
