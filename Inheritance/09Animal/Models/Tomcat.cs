namespace _09Animal
{
    using System;

    public class Tomcat : Cat
    {
        private const string Gender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, Gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }

    }
}
