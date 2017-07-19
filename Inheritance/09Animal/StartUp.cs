namespace _09Animal
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                try
                {
                    string type = Console.ReadLine().ToLower().Trim();
                    if (type == "beast!") break;
                    string[] animalTokens = Console.ReadLine().Split();
                    string name = animalTokens[0];
                    int age = int.Parse(animalTokens[1]);
                    string gender = animalTokens[2];


                    if (type == "cat")
                    {
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (type == "dog")
                    {
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (type == "frog")
                    {
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (type == "kitten")
                    {
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                    }
                    else if (type == "tomcat")
                    {
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
