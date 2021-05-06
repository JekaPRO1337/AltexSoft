using System;
using HomeWork2.UI;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeUI = new StoreView();
            var orderUI = new OrderView();
            var product1 = new Product(0, "Razer DeathAdderEssential ", 49.23m, ProductType.Mouse);
            var product2 = new Product(1, "Asus strix b250h gaming", 102, ProductType.Monitor);
            var product3 = new Product(2, "Samsung Curved", 430, ProductType.TV);
            var product4 = new Product(3, "Iphone 12", 1100, ProductType.Phone);
            var product5 = new Product(4, "Intel core I9", 733.50m, ProductType.Processor);
            var product6 = new Product(5, "Razer Kraken BRO", 79.99m, ProductType.Headphones);


            var store1 = new Store("Brain");
            store1.AddProduct(product1);
            store1.AddProduct(product2);
            store1.AddProduct(product3);
            store1.AddProduct(product4);
            store1.AddProduct(product5);
            store1.AddProduct(product6);
            store1.AddProduct(6, "Xiaomi notebook", 300, ProductType.Notebook);
            storeUI.PrintAssortment(store1);

            var client1 = new Client(1, "Eugene Rudenberg");

            var order1 = new Order(store1, client1);
            order1.AddProduct(store1.GetProduct(2));
            order1.AddProduct(store1.GetProduct(3));
            orderUI.PrintProducts(order1);

            Console.WriteLine(order1.OrderPrice);

            Console.ReadLine();
        }


        public record ProductRecord(int Id);
    }
}