using ProjectMicroservice.Models;
using System.Collections.Generic;


namespace ProjectMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(); 

        Product GetProductByID(int id);

        void InsertProduct(Product product);

        void DeleteProduct(int product);

        void UpdateProduct(Product product);

        void Save();
    }
}
