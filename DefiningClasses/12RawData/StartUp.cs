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
            int engineSpeed = int.Parse(inputLine[1]);
            int enginePower = int.Parse(inputLine[2]);
            int cargoWeight = int.Parse(inputLine[3]);
            string cargoType = inputLine[4];

            Tyre firstTyre = new Tyre()
            {
                tirePressure = double.Parse(inputLine[5]),
                tireAge = int.Parse(inputLine[6])
            };
            Tyre secondTyre = new Tyre()
            {
                tirePressure = double.Parse(inputLine[7]),
                tireAge = int.Parse(inputLine[8])
            };
            Tyre thirdTire = new Tyre()
            {
                tirePressure = double.Parse(inputLine[9]),
                tireAge = int.Parse(inputLine[10])
            };
            Tyre fourthTire = new Tyre()
            {
                tirePressure = double.Parse(inputLine[11]),
                tireAge = int.Parse(inputLine[12])
            };
            Tyre[] tires = new Tyre[4];
            tires[0] = firstTyre;
            tires[1] = secondTyre;
            tires[2] = thirdTire;
            tires[3] = fourthTire;
            Engine engine = new Engine
            {
                power = enginePower,
                speed = engineSpeed
            };
            Cargo cargo = new Cargo()
            {
                type = cargoType,
                weight = cargoWeight
            };
            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        string filter = Console.ReadLine();
        if (filter.Equals("fragile"))
        {
            foreach (var car in cars
                                 .Where(c => c.cargo.type.ToLower() == "fragile"
                                     && c.tires.Any(t => t.tirePressure < 1)))
            {
                Console.WriteLine($"{car.model}");
            }
        }
        else
        {
            foreach (var car in cars
                                 .Where(c => c.cargo.type.ToLower() == "flamable"
                                 && c.engine.power > 250))
            {
                Console.WriteLine($"{car.model}");
            }
        }
    }
}
