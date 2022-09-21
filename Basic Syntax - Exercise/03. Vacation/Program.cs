using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    price = 8.45;
                }
                else if (type == "Business")
                {
                    price = 10.90;
                }
                else if (type == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    price = 9.80;
                }
                else if (type == "Business")
                {
                    price = 15.60;
                }
                else if (type == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    price = 10.46;
                }
                else if (type == "Business")
                {
                    price = 16;
                }
                else if (type == "Regular")
                {
                    price = 22.50;
                }
            }

            totalPrice = people * price;

            // For Students – if the group is 30 or more people, you should reduce the total price by 15%
            if (type == "Students" && people >= 30)
            {
                totalPrice = totalPrice - totalPrice * 15 / 100; 
            }
            if (type == "Business" && people >= 100)
            {
                totalPrice = totalPrice - price * 10;
            }
            // For Regular – if the group is between 10 and 20 people (both inclusively), reduce the total price by 5%.
            if (type == "Regular" && people >=10 && people <=20)
            {
                totalPrice = totalPrice - totalPrice * 5 / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
            //END
        }
    }
}
