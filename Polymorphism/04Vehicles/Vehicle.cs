namespace _04Vehicles
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelPerKm;
        private double tankCapacity;

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }


        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel must be a positive number");

                this.fuelQuantity = value;
            }
        }

        public double FuelPerKm
        {
            get
            {
                return fuelPerKm;
            }

            protected set
            {
                if (value < 0)
                    throw new ArgumentException();

                this.fuelPerKm = value;
            }
        }

        public abstract void Refuel(double fuel);
        public abstract void TravelDistance(double distance);

        public virtual void TravelDistance(double distance, bool isEmpty)
        {

        }
    }
}
