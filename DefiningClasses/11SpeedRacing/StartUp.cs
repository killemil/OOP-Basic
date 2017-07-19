using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split();
            string model = inputLine[0];
            double fuelAmount = double.Parse(inputLine[1]);
            double fuelConsumption = double.Parse(inputLine[2]);

            Car car = new Car()
            {
                Model = model,
                FuelAmount = fuelAmount,
                FuelConsumptionPerKilometer = fuelConsumption
            };
            cars.Add(car);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            string model = tokens[1];
            int amountOfKilometers = int.Parse(tokens[2]);


            if (cars
                .Where(c => c.Model == model)
                .First()
                .HasFuelToDriveDistance(amountOfKilometers)) { }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
        }
    }
}
