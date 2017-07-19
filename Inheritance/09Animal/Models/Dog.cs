﻿namespace _09Animal
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("BauBau");
        }

    }
}
