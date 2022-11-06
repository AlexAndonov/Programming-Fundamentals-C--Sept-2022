namespace _07._Order_by_Age
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmndArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmndArgs[0];
                string id = cmndArgs[1];
                int age = int.Parse(cmndArgs[2]);

                Person person = people.FirstOrDefault(x => x.ID == id);

                if (person != null)
                {
                    person.Name = name;
                    person.Age = age;
                }
                else
                {
                    person = new Person(name, id, age);
                    people.Add(person);
                }
            }
            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
}
