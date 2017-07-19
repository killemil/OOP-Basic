public class PowerHardware : Hardware
{
    private const double DecreaseCapacity = 0.75;
    private const double IncreaseMemory = 0.75;

    public PowerHardware(string name, int maxCapacity, int maxMemory)
        : base(name, "Power", maxCapacity - (int)(maxCapacity * DecreaseCapacity), maxMemory + (int)(maxMemory * IncreaseMemory))
    {

    }
}

