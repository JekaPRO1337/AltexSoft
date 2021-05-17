using System;
using HomeWork2.UI;
using HomeWork2.BLL;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeUI = new StoreView();
            var orderUI = new OrderView();
            var storeBLL = new StoresBLL();
            var ordersBLL = new OrdersBLL();

            var store1 = new Store("Brain");
            storeBLL.AddProduct(store1, new Product(0, "Razer DeathAdderEssential ", 49.23m, ProductType.Mouse));
            storeBLL.AddProduct(store1, new Product(1, "Asus strix b250h gaming", 102, ProductType.Monitor));
            storeBLL.AddProduct(store1, new Product(2, "Samsung Curved", 430, ProductType.TV));
            storeBLL.AddProduct(store1, new Product(3, "Iphone 12", 1100, ProductType.Phone));
            storeBLL.AddProduct(store1, new Product(4, "Intel core I9", 733.50m, ProductType.Processor));
            storeBLL.AddProduct(store1, new Product(5, "Razer Kraken BRO", 79.99m, ProductType.Headphones));
            storeBLL.AddProduct(store1, 6, "Xiaomi notebook", 300, ProductType.Notebook);
            storeUI.PrintAssortment(store1);

            var client1 = new Client(1, "Eugene Rudenberg");

            var order1 = new Order(store1, client1);
            ordersBLL.AddProduct(order1, store1.Assortment[2]);
            ordersBLL.AddProduct(order1, store1.Assortment[3]);
            orderUI.PrintProducts(order1);

            Console.WriteLine(order1.OrderPrice);

            Console.ReadLine();
        }


        public record ProductRecord(int Id);
    }
}