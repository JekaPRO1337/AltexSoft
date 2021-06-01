using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.BLL
{
    public class StoresBLL
    {
        public Product GetProduct(Store store, int id)
        {
            return store.Products[id];
        }

        public void AddProduct(Store store, Product product)
        {
            store.Products.Add(product);
        }

        public void AddProduct(Store store, int id, string name, decimal price, ProductType? productType)
        {
            store.Products.Add(new Product(id, name, price, productType));
        }

        public string GetProductName(ProductType? productType)
        {
            return productType switch
            {
                ProductType.None => "None",
                ProductType.Mouse => "Mouse",
                ProductType.Monitor => "Monitor",
                ProductType.TV => "TV",
                ProductType.Phone => "Phone",
                ProductType.Processor => "Processor",
                ProductType.Headphones => "Headphones",
                ProductType.Notebook => "Notebook",
                _ => throw new ArgumentNullException()
            };
        }

    }
}
