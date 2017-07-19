using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            string name = tokens[0];
            string command = tokens[1];

            if (!people.ContainsKey(name))
            {
                people[name] = new Person();
            }
            people[name].Name = name;
            switch (command)
            {
                case "company":
                    Company company = new Company();
                    company.Name = tokens[2];
                    company.Department = tokens[3];
                    company.Salary = decimal.Parse(tokens[4]);
                    people[name].Company = company;
                    break;
                case "pokemon":
                    Pokemon pokemon = new Pokemon();
                    pokemon.Name = tokens[2];
                    pokemon.Type = tokens[3];
                    people[name].Pokemons.Add(pokemon);
                    break;
                case "parents":
                    Parent parent = new Parent();
                    parent.Name = tokens[2];
                    parent.BirthDate = tokens[3];
                    people[name].Parents.Add(parent);
                    break;
                case "children":
                    Child child = new Child();
                    child.Name = tokens[2];
                    child.BirthDay = tokens[3];
                    people[name].Children.Add(child);
                    break;
                case "car":
                    Car car = new Car();
                    car.Model = tokens[2];
                    car.Speed = int.Parse(tokens[3]);
                    people[name].Car = car;
                    break;
            }
        }
        input = Console.ReadLine();

        foreach (var item in people.Where(p => p.Key == input))
        {
            Console.WriteLine($"{item.Value.Name}");
            Console.WriteLine($"Company:");
            if (item.Value.Company.Name != "n/a")
            {
                Console.WriteLine($"{item.Value.Company.Name} {item.Value.Company.Department} {item.Value.Company.Salary:f2}");
            }

            Console.WriteLine($"Car:");
            if (item.Value.Car.Model != "n/a")
            {
                Console.WriteLine($"{item.Value.Car.Model} {item.Value.Car.Speed}");
            }

            Console.WriteLine($"Pokemon:");
            foreach (var pokemon in item.Value.Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
            }

            Console.WriteLine("Parents:");
            foreach (var parent in item.Value.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.BirthDate}");
            }

            Console.WriteLine("Children:");
            foreach (var child in item.Value.Children)
            {
                Console.WriteLine($"{child.Name} {child.BirthDay}");
            }
        }
    }
}
