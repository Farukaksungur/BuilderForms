using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderForms.Models
{
    public class ProductRepostory
    {
        private static List<Product> _products;

        static ProductRepostory()
        {
            _products = new List<Product>()
            {
                new Product(){Id=1,Name="Product 1",Desc="Description 1",Price=10,IsAppored=true},
                new Product(){Id=2,Name="Product 2",Desc="Description 2",Price=20,IsAppored=false},
                new Product(){Id=3,Name="Product 3",Desc="Description 3",Price=30,IsAppored=true},
                new Product(){Id=4,Name="Product 4",Desc="Description 4",Price=40,IsAppored=false}
            };
        }


        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }

    }
}
