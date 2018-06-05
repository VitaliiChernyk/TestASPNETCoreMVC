using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;
using TestPage;

namespace OA.Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductProfile> productProfileRepository;
        public ProductService(IRepository<Product> productRepository, IRepository<ProductProfile> productProfileRepository)
        {
            this.productRepository = productRepository;
            this.productProfileRepository = productProfileRepository;
        }
        public void DeleteProduct(long id)
        {
            ProductProfile productProfile = productProfileRepository.Get(id);
            productProfileRepository.Remove(productProfile);
            Product product = GetProduct(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }

        public Product GetProduct(long id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void InsertProduct(Product product)
        {
            productRepository.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }
    }
}
