namespace _05Wildfarm.Factories
{
    using _05Wildfarm.Models;

    public class FoodFactory
    {
        public static Food GetFood(string[] tokens)
        {
            var foodType = tokens[0];
            var foodQuantity = int.Parse(tokens[1]);

            switch (foodType.ToLower())
            {
                case "vegetable":
                    return new Vegetable(foodQuantity);
                case "meat":
                    return new Meat(foodQuantity);
                default:
                    return null;
            }
        }
    }
}
