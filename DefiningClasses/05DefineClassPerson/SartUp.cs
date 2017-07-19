using System;
using System.Reflection;

public class SartUp
{
    public static void Main()
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
    }
}
public class Person
{
    public string name;
    public int age;

    //public string Name { get { return this.name; } set { this.name = value; } }

    //public int Age { get { return this.age; } set { this.age = value; } }
}


