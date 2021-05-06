﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.UI
{
    public class OrderView
    {
        public void PrintClient(Order order)
        {
            Console.WriteLine($"Client: {order.GetClient().Name}");
        }

        public void PrintSeller(Order order)
        {
            Console.WriteLine($"Seller: {order.GetSeller()}");
        }

        public void PrintProducts(Order order)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Order:");
            foreach (Product product in order.GetProducts())
            {
                Console.WriteLine($"{product.Name} | {product.Price}");
            }
            Console.WriteLine("-----------------------");
        }
    }
}