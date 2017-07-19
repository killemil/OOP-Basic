namespace _05Wildfarm.Factories
{
    using _05Wildfarm.Models;

    public class AnimalFactory
    {
        public static Animal GetAnimal(string[] tokens)
        {
            var animalType = tokens[0];
            var animalName = tokens[1];
            var animalWeight = double.Parse(tokens[2]);
            var animalRegion = tokens[3];

            switch (animalType.ToLower())
            {
                case "mouse":
                    return new Mouse(animalName, animalType, animalWeight, animalRegion);
                case "zebra":
                    return new Zebra(animalName, animalType, animalWeight, animalRegion);
                case "cat":
                    return new Cat(animalName, animalType, animalWeight, animalRegion, tokens[4]);
                case "tiger":
                    return new Tiger(animalName, animalType, animalWeight, animalRegion);
                default:
                    return null;
            }
        }
    }
}
