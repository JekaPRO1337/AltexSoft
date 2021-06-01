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

            var Rozetka = new Store("Brain");
            storeBLL.AddProduct(Rozetka, new Product(0, "Razer DeathAdderEssential ", 49.23m, ProductType.Mouse));
            storeBLL.AddProduct(Rozetka, new Product(1, "Asus strix b250h gaming", 102, ProductType.Monitor));
            storeBLL.AddProduct(Rozetka, new Product(2, "Samsung Curved", 430, ProductType.TV));
            storeBLL.AddProduct(Rozetka, new Product(3, "Iphone 12", 1100, ProductType.Phone));
            storeBLL.AddProduct(Rozetka, new Product(4, "Intel core I9", 733.50m, ProductType.Processor));
            storeBLL.AddProduct(Rozetka, new Product(5, "Razer Kraken BRO", 79.99m, ProductType.Headphones));
            storeBLL.AddProduct(Rozetka, 6, "Xiaomi notebook", 300, ProductType.Notebook);
            storeUI.PrintAssortment(Rozetka);

            var Eugene = new Client(1, "Eugene Rudenberg");

            var order_Eugene = new Order(Rozetka, Eugene);
            ordersBLL.AddProduct(order_Eugene, Rozetka.Products[2]);
            ordersBLL.AddProduct(order_Eugene, Rozetka.Products[3]);
            orderUI.PrintProducts(order_Eugene);

            Console.WriteLine(order_Eugene.OrderPrice);

            Console.ReadLine();
        }

        public record ProductRecord(int Id);
    }
}