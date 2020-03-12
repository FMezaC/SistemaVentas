using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSupport.EntityLayer;
using DataAccess;

namespace Domain_Layer
{
    public class ProductModel
    {
        public List<ProductEntity> ListProducts(string condition)
        {
            ProducDao dao = new ProducDao();
            return dao.ProductList(condition);
        }

        public double PreoductID(MaxID NewID)
        {
            ProducDao dao = new ProducDao();
            return dao.ProductID(NewID);
        }

        public void InsertProduct(ProductEntity Insert)
        {
            ProducDao dao = new ProducDao();
            dao.InsertProduct(Insert);
        }

        public void UpdateProduct(ProductEntity Update)
        {
            ProducDao dao = new ProducDao();
            dao.UpdateProduct(Update);
        }

        public List<ProductEntity> FilterProdct(double condition)
        {
            ProducDao dao = new ProducDao();
            return dao.FilterProduct(condition);
        }

        public void UpdateStock(ProductEntity Stock)
        {
            ProducDao dao = new ProducDao();
            dao.UpdateStock(Stock);
        }
    }
}
