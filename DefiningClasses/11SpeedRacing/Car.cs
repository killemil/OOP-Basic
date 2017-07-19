public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double distanceTravelled;

    public Car()
    {
        this.distanceTravelled = 0;
    }

    public string Model { get { return this.model; } set { this.model = value; } }
    public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
    public double FuelConsumptionPerKilometer
    {
        get
        {
            return this.fuelConsumptionPerKilometer;
        }
        set { this.fuelConsumptionPerKilometer = value; }
    }
    public double DistanceTravelled
    {
        get
        {
            return this.distanceTravelled;
        }
        set
        {
            this.distanceTravelled = value;
        }
    }

    public bool HasFuelToDriveDistance(int amountOfKillometers)
    {
        double fuelNeeded = amountOfKillometers * this.fuelConsumptionPerKilometer;
        if (fuelNeeded <= this.fuelAmount)
        {
            this.fuelAmount -= fuelNeeded;
            this.distanceTravelled += amountOfKillometers;
            return true;
        }
        else
        {
            return false;
        }
    }
}
