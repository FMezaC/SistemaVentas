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
    public class DocumentTypeDao : ConnectionToSql
    {
        public List<DocumentTypeEntity> ListDocumentType(string condition)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(ID,'')ID,ISNULL(IDDOC,'')IDDOC, ISNULL(DOCUM,'')DOCUM 
                FROM TIP_DOCUMENTO WHERE IDDOC LIKE '%' + @VARIABLE + '%' OR DOCUM LIKE '%' + @VARIABLE + '%'";
                cmd.Parameters.AddWithValue("@VARIABLE", condition);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<DocumentTypeEntity> MyList = new List<DocumentTypeEntity>();
                while (reader.Read())
                {
                    MyList.Add(new DocumentTypeEntity() {
                        _ID = reader.GetInt32(0),
                        _IDDOC = reader.GetString(1),
                        _DOCUM = reader.GetString(2)
                    });
                }
                return MyList;
            }
        }

        public void InsertDocment(DocumentTypeEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO TIP_DOCUMENTO(IDDOC, DOCUM) VALUES(@CODTIP, @DOCUEMN)";
                cmd.Parameters.AddWithValue("@CODTIP", Insert._IDDOC);
                cmd.Parameters.AddWithValue("@DOCUEMN", Insert._DOCUM);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDocment(DocumentTypeEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE TIP_DOCUMENTO SET IDDOC = @CODTIP, DOCUM = @DOCUEMN WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._ID);
                cmd.Parameters.AddWithValue("@CODTIP", Update._IDDOC);
                cmd.Parameters.AddWithValue("@DOCUEMN", Update._DOCUM);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDocment(DocumentTypeEntity Delete)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"DELETE TIP_DOCUMENTO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Delete._ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
