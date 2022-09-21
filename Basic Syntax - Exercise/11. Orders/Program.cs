using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double pricePerCapsule = 0;
            int days = 0;
            int capsulesCnt = 0;
            double total = 0;
            double orderPrice = 0.0;

            for (int i = 1; i <= n; i++)
            {
                // ((daysInMonth * capsulesCount) * pricePerCapsule

                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCnt = int.Parse(Console.ReadLine());

                orderPrice = (days * capsulesCnt) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                total += orderPrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
