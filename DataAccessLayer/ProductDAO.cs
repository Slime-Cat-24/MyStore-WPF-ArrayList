using Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class ProductDAO
    {
        private static List<Product> listProducts;

        static ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
        }

        public static List<Product> GetProducts()
            => listProducts;

        public static void SaveProduct(Product product)
            => listProducts.Add(product);

        public static void UpdaterProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitInStock = product.UnitInStock;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(Product product)
            => listProducts.RemoveAll(p => p.ProductId == product.ProductId);

        public static Product GetProductById(int id)
            => listProducts.FirstOrDefault(p => p.ProductId == id);
    }

}
