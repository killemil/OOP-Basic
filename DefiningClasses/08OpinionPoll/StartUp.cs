using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            Person person = new Person()
            {
                name = input[0],
                age = int.Parse(input[1])
            };
            people.Add(person);
        }

        foreach (var person in people.Where(p => p.age > 30).OrderBy(p => p.name))
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }
    }
}
