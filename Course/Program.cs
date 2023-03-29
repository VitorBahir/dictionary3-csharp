using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Dictionary<int, int> Items = new Dictionary<int, int>();

        Console.WriteLine("Digite o numero do produto e a quantidade desejada: (número, quantidade) ");
        Console.WriteLine(" (1 - Hot dog R$ 1,00) ");
        Console.WriteLine(" (2 - Hamburguer R$ 1,30) ");
        Console.WriteLine(" (3 - Cheeseburguer R$ 1,50) ");
        Console.WriteLine(" (4 - Refrigerante em lata R$ 1,00) ");
        Console.WriteLine(" (5 - Batatas fritas R$ 0,80) ");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            string[] pedido = Console.ReadLine().Split(" ");
            int numberOrder = int.Parse(pedido[0]);
            int qttOrder = int.Parse(pedido[1]);
            Items.Add(numberOrder, qttOrder);
        }

        foreach (var item in Items)
        {
            if (item.Key == 1)
            {
                products.Add(new Product(item.Key, item.Value, 1.0));
                if (!(item.Value == 0))
                {
                    Console.WriteLine("Quantidade de hotdog: " + item.Value);
                }

            }
            else if (item.Key == 2)
            {
                products.Add(new Product(item.Key, item.Value, 1.3));
                if (!(item.Value == 0))
                {
                    Console.WriteLine("Quantidade de hamburguer: " + item.Value);
                }


            }
            else if (item.Key == 3)
            {
                products.Add(new Product(item.Key, item.Value, 1.5));
                if (!(item.Value == 0))
                {
                    Console.WriteLine("Quantidade de cheeseburguer: " + item.Value);

                }
            }
            else if (item.Key == 4)
            {
                products.Add(new Product(item.Key, item.Value, 1.0));
                if (!(item.Value == 0))
                {
                    Console.WriteLine("Quantidade de refri: " + item.Value);
                }

            }
            else if (item.Key == 5)
            {
                products.Add(new Product(item.Key, item.Value, 0.8));
                if (!(item.Value == 0))
                {
                    Console.WriteLine("Quantidade de batatas fritas: " + item.Value);
                }
            }
        }
        Console.WriteLine();

        double soma = 0;
        foreach (Product product in products)
        {
            soma += product.Total(product.Quantity, product.Price);
        }

        Console.WriteLine("Valor total do pedido: " + soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}