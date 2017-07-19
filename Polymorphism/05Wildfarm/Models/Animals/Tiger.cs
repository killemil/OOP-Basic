namespace _05Wildfarm.Models
{
    using System;

    public class Tiger : Mammal
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {

            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.Eat(food);
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

    }
}
