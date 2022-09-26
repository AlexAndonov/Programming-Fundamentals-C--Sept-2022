namespace _10._Pokemon
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            int nCopy = n;
            while (n >= m)
            {
                count++;
                n -= m;

                if (n == nCopy * 0.5 && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
