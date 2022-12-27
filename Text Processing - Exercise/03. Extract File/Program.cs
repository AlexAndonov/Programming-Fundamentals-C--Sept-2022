using System;
using System.Xml.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string file = input[input.Length - 1];
            string[] splitFile = file.Split(".");
            string fileName = splitFile[0];
            string extension = splitFile[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
