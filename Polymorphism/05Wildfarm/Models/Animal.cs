namespace _05Wildfarm.Models
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
        }

        protected int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }


        protected double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }


        protected string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        protected string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }

        public abstract string MakeSound();
        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }


    }
}
