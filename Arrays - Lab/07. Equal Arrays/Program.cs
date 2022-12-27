namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int arr1Sum = 0;
            int arr2Sum = 0;
            bool broke = false;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1Sum += arr1[i];
                arr2Sum += arr2[i];
            
                if (arr1[i] != arr2[i])
                {
                    broke = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (arr1Sum == arr2Sum && broke == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arr1Sum}");
            }
        }
    }
}
