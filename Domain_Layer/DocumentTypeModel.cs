using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class DocumentTypeModel
    {
        public List<DocumentTypeEntity> ListDocuemt(string Condition)
        {
            DocumentTypeDao dao = new DocumentTypeDao();
            return dao.ListDocumentType(Condition);
        }

        public void InsertDocument (DocumentTypeEntity Insert)
        {
            DocumentTypeDao dao = new DocumentTypeDao();
            dao.InsertDocment(Insert);
        }

        public void UpdateDocument(DocumentTypeEntity Update)
        {
            DocumentTypeDao dao = new DocumentTypeDao();
            dao.UpdateDocment(Update);
        }

        public void DeleteDocument(DocumentTypeEntity Delete)
        {
            DocumentTypeDao dao = new DocumentTypeDao();
            dao.DeleteDocment(Delete);
        }
    }
}
