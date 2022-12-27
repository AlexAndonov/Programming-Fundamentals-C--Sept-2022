namespace _01._Day_of_Week
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];
            {
                daysOfWeek[0] = "Monday";
                daysOfWeek[1] = "Tuesday";
                daysOfWeek[2] = "Wednesday";
                daysOfWeek[3] = "Thursday";
                daysOfWeek[4] = "Friday";
                daysOfWeek[5] = "Saturday";
                daysOfWeek[6] = "Sunday";
            };
            int day = int.Parse(Console.ReadLine());
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
        }
    }
}
