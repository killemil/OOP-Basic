
namespace _09PizzaCalories
{
    using _09PizzaCalories.Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string inputLine;
                while ((inputLine = Console.ReadLine()) != "END")
                {
                    string[] tokens = inputLine
                        .Trim()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (tokens[0])
                    {
                        case "Dough":
                            Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetCalories():f2}");
                            break;
                        case "Topping":
                            Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                            break;
                        case "Pizza":
                            MakePizza(tokens);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        private static void MakePizza(string[] tokens)
        {
            int numberOfToppings = int.Parse(tokens[2]);
            Pizza pizza = new Pizza(tokens[1], numberOfToppings);
            string[] doughInfo = Console.ReadLine().Trim().Split();
            Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            pizza.Dough = dough;

            for (int i = 0; i < numberOfToppings; i++)
            {
                string[] topInfo = Console.ReadLine().Trim().Split();
                Topping topping = new Topping(topInfo[1], double.Parse(topInfo[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetPizzaCalories():f2} Calories.");
        }
    }
}
