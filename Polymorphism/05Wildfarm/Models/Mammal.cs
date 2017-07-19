namespace _05Wildfarm.Models
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        protected string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
