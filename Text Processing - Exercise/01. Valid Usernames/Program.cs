namespace _01._Valid_Usernames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    foreach (var currCh in username)
                    {
                        if (!(char.IsLetterOrDigit(currCh) || currCh == '-' || currCh == '_'))
                        {
                            isValid= false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
