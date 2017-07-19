namespace _04Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelPerKm, double tankCapacity)
        {
            base.FuelQuantity = fuelQuantity;
            base.FuelPerKm = fuelPerKm;
            this.TankCapacity = tankCapacity;
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
                throw new ArgumentException("Fuel must be a positive number");
            if (fuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException("Cannot Fuel fit in tank");
            }
            this.FuelQuantity += fuel;
        }

        public override void TravelDistance(double distance)
        {
            double requiredFuel = distance * this.FuelPerKm;
            if (requiredFuel <= this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                this.FuelQuantity -= requiredFuel;
            }
            else
                Console.WriteLine($"Bus needs refueling");
        }
        public override void TravelDistance(double distance, bool isEmpty)
        {
            double requiredFuel = distance * (this.FuelPerKm + 1.4);
            if (requiredFuel <= this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                this.FuelQuantity -= requiredFuel;
            }
            else
                Console.WriteLine($"Bus needs refueling");
        }

        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:F2}";
        }
    }
}
