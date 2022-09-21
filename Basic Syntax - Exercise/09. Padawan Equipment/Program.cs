namespace _09._Padawan_Equipment
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

           double neededEquipment = (saberPrice * Math.Ceiling(students + students * 0.1)) + (robePrice * students) +
               (beltPrice * (students - students / 6));
           
           if (money >= neededEquipment)
           {
               Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
           }
           else
           {
               Console.WriteLine($"John will need {neededEquipment - money:f2}lv more.");
           }
        }
    }
}
