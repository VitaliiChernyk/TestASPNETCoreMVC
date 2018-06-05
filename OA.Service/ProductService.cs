using System;
using System.Collections.Generic;
using System.Text;
using TestPage.Models;
using TestPage;

namespace OA.Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        public void DeleteProduct(long id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
