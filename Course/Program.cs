using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Course.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Dictionary<int, int> orders = new Dictionary<int, int>();
        Dictionary<int, double> items = new Dictionary<int, double>()
        {
            {1, 1.00 }, {2, 1.30}, {3, 1.50}, {4, 1.0}, {5, 0.8}
        };

        bool status = true;
        Console.WriteLine(" (1 - Hot dog U$ 1.00) ");
        Console.WriteLine(" (2 - Hamburguer U$ 1.30) ");
        Console.WriteLine(" (3 - Cheeseburguer U$ 1.50) ");
        Console.WriteLine(" (4 - Cans U$ 1.00) ");
        Console.WriteLine(" (5 - French fries U$ 0.80) ");
        Console.WriteLine(" Do want go out of screen, type 0");
        Console.WriteLine();

        while (status)
        {
            Console.WriteLine("Enter product number first, then the desired quantity:");
            int numberOrder = int.Parse(Console.ReadLine());
            if (numberOrder != 0)
            {
                Console.WriteLine("Type the order's quantity: ");
                int qttOrder = int.Parse(Console.ReadLine());

                if (orders.ContainsKey(numberOrder))
                {
                    orders[numberOrder] += qttOrder;
                }
                else
                {
                    orders[numberOrder] = qttOrder;
                }
            }
            else
            {
                status = false;
            }
        }

        foreach (var order in orders)
        {
            Console.WriteLine($"Item price {order.Key}: " + items[order.Key]);
            
            products.Add(new Product(order.Key, order.Value, items[order.Key]));
        }

        Console.WriteLine();

        double sum = 0;
        foreach (Product product in products)
        {
            sum += product.Total(product.Quantity, product.Price);
        }

        Console.WriteLine("Order total value: " + sum.ToString("F2", CultureInfo.InvariantCulture));
    }
}