using System;

namespace _05._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];
                password += currentChar;
            }

            int totalTries = 1;
            string currentPass;

            while ((currentPass = Console.ReadLine()) != password)
            {
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrect password.Try again.");
                }

                totalTries++;
            }

             Console.WriteLine($"User {username} logged in.");
   
            //END
        }
    }
}
