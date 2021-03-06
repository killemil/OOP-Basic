﻿namespace _05Wildfarm.Models
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set
            { this.breed = value; }
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }


        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
