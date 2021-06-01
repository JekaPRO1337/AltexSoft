using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.UI
{
    public class StoreView
    {
        public void PrintProduct(Store store, int id)
        {
            Console.WriteLine($"{store.Products[id].Name} | {store.Products[id].ProductType} | {store.Products[id].Price}");
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine($"{product.Name} | {product.ProductType} | {product.Price}");
        }

        public void PrintAssortment(Store store)
        {
            foreach (Product product in store.Products)
            {
                Console.WriteLine($"{product.Name} | {product.ProductType} | {product.Price}");
            }
        }

        public void PrintStoreName(Store store)
        {
            Console.WriteLine($"Store name: \"{store.Name}\"");
        }
    }
}