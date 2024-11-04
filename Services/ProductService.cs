using Business_Objects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService()
        {
            _repository = new ProductRepository();
        }

        public void DeleteProduct(Product product)
        {
            _repository.DeleteProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void SaveProduct(Product product)
        {
            _repository.SaveProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }
    }
}
