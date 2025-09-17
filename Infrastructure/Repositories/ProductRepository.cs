using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;


namespace Infrastructure.Repositories
{
    public class ProductRepository: IProductRepository
    {
        public ProductRepository() 
        {

        }

        public IEnumerable<Product> GetProducts()
        {
            return null;
        }
        public Product GetAllProducts()
        {
            return null;
        }
        public void AddProduct(Product product)
        {
        }
        public void UpdateProduct(Product product)
        {
        }
        public void DeleteProduct(int productId)
        {
        }
        public void SaveChanges()
        {
        }
    }
}
