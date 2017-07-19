using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = inputLine[0];
            int power = int.Parse(inputLine[1]);

            Engine engine = new Engine(model, power);
            if (inputLine.Length == 3)
            {
                string displacementOrEfficiency = inputLine[2];
                bool isInteger = int.TryParse(displacementOrEfficiency, out int displacement);
                if (isInteger)
                {
                    engine.Displacements = displacementOrEfficiency;
                }
                else
                {
                    engine.Efficiency = displacementOrEfficiency;
                }
            }
            if (inputLine.Length == 4)
            {
                engine.Displacements = inputLine[2];
                engine.Efficiency = inputLine[3];
            }
            engines.Add(engine);
        }

        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = inputLine[0];
            string engineName = inputLine[1];
            Engine engine = engines.Where(e => e.Model == engineName).First();
            Car car = new Car(model, engine);
            if (inputLine.Length == 3)
            {
                string weightOrColor = inputLine[2];
                bool isInteger = int.TryParse(weightOrColor, out int weight);
                if (isInteger)
                {
                    car.Weight = weightOrColor;
                }
                else
                {
                    car.Color = weightOrColor;
                }
            }
            if (inputLine.Length == 4)
            {
                car.Weight = inputLine[2];
                car.Color = inputLine[3];
            }
            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            Console.WriteLine($"    Displacement: {car.Engine.Displacements}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            Console.WriteLine($"    Weight: {car.Weight}");
            Console.WriteLine($"    Color: {car.Color}");
        }
    }
}
