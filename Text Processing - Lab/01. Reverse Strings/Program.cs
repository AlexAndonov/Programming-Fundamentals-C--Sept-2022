using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            while ((text = Console.ReadLine()) != "end")
            {
                string reversed = string.Empty;
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversed += text[i];
                }
                Console.WriteLine($"{text} = {reversed}");
            }
        }
    }
}
