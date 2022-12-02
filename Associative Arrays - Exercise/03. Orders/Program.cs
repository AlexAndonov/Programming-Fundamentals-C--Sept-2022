namespace _03._Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmndArgs = input.Split(" ");
                string product = cmndArgs[0];
                double price = double.Parse(cmndArgs[1]);
                double qnt = double.Parse(cmndArgs[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double> { price, qnt });
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += qnt;
                }
            }
            foreach (var kvp in products)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
