using System;

namespace _10._Rage_expense
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetsTrashed = lostGames / 2;
            int miceTrashed = lostGames / 3;
            int keyboardsTrashed = lostGames / 6;
            int displaysTrashed = lostGames / 12;

            double expenses = (headsetsTrashed * headsetPrice) + (miceTrashed * mousePrice) + (keyboardsTrashed * keyboardPrice) +
                (displaysTrashed * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
