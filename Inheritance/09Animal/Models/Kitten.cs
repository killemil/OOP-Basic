namespace _09Animal
{
    using System;

    public class Kitten : Cat
    {
        private const string Gender = "Female";
        public Kitten(string name, int age)
            : base(name, age, Gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }

    }
}
