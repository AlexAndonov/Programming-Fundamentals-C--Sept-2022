namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmndArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmndArgs[0].ToLower();
                string model = cmndArgs[1];
                string color = cmndArgs[2];
                int hp = int.Parse(cmndArgs[3]);

                Vehicle currVehicle = new Vehicle(type, model, color, hp);
                catalogue.Add(currVehicle);
            }
            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "Close the Catalogue")
            {
                string modelType = secondCommand;
                Vehicle printCar = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printCar);
            }
            List<Vehicle> cars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHp = cars.Sum(x => x.Horsepower);
            double totalTrucksHp = trucks.Sum(x => x.Horsepower);

            double avrgCarsHp = 0.00;
            double avrgTrucksHp = 0.00;
            if (cars.Count > 0)
            {
                avrgCarsHp = totalCarsHp / cars.Count;
            }
            if (trucks.Count > 0)
            {
                avrgTrucksHp = totalTrucksHp / trucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {avrgCarsHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgTrucksHp:f2}.");
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}
