﻿namespace _04Vehicles
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {

            double[] vehicleData = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Vehicle myCar = new Car(vehicleData[0], vehicleData[1], vehicleData[2]);
            vehicleData = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Vehicle myTruck = new Truck(vehicleData[0], vehicleData[1], vehicleData[2]);
            vehicleData = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Vehicle myBus = new Bus(vehicleData[0], vehicleData[1], vehicleData[2]);

            int numOfInputs = int.Parse(Console.ReadLine());

            for (int input = 0; input < numOfInputs; input++)
            {
                try
                {
                    string[] command = Console.ReadLine().Split();

                    if (command[1].Equals("Car"))
                    {
                        if (command[0].Equals("Drive"))
                            myCar.TravelDistance(double.Parse(command[2]));
                        else
                            myCar.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1].Equals("Bus"))
                    {
                        if (command[0].Equals("Drive"))
                            myBus.TravelDistance(double.Parse(command[2]), false);
                        else if (command[0].Equals("DriveEmpty"))
                        {
                            myBus.TravelDistance(double.Parse(command[2]));
                        }
                        else
                            myBus.Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        if (command[0].Equals("Drive"))
                            myTruck.TravelDistance(double.Parse(command[2]));
                        else
                            myTruck.Refuel(double.Parse(command[2]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(myCar);
            Console.WriteLine(myTruck);
            Console.WriteLine(myBus);
        }
    }
}
