namespace _04Vehicles
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelPerKm, double tankCapacity)
        {
            base.FuelQuantity = fuelQuantity;
            base.FuelPerKm = fuelPerKm + 0.9;
            this.TankCapacity = tankCapacity;
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
                throw new ArgumentException("Fuel must be a positive number");
            if (fuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            this.FuelQuantity += fuel;
        }

        public override void TravelDistance(double distance)
        {
            double requiredFuel = distance * this.FuelPerKm;
            if (requiredFuel <= this.FuelQuantity)
            {
                Console.WriteLine($"Car travelled {distance} km");
                this.FuelQuantity -= requiredFuel;
            }
            else
                Console.WriteLine($"Car needs refueling");
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:F2}";
        }
    }
}
