using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        int n = int.Parse(Console.ReadLine());
        Family family = new Family();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            Person person = new Person()
            {
                name = input[0],
                age = int.Parse(input[1])
            };
            family.people.Add(person);
        }

        Console.WriteLine($"{family.GetOldestMember().name} {family.GetOldestMember().age}");
    }
}

