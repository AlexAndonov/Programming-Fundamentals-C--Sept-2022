namespace _07._Vehicle_catalogue
{
    using System;
    using System.Linq;
        using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int value = int.Parse(info[3]);

            }
        }
    }

    public class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
