namespace _06._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmndArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = cmndArgs[0];
                string itemName = cmndArgs[1];
                int itemQnt = int.Parse(cmndArgs[2]);
                decimal itemPrice = decimal.Parse(cmndArgs[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQnt);
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }
        }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }
        public string SerialNumber { get; private set; }
        public Item Item { get; private set; }
        public int Quantity { get; private set; }
        public decimal PricePerBox
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }
    public class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
        public string Name { get; private set; }

        public decimal Price { get; private set; }
    }
}
