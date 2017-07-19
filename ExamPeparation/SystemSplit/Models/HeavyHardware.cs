public class HeavyHardware : Hardware
{
    private const double DecreaseMemory = 0.25;

    public HeavyHardware(string name, int maxCapacity, int maxMemory)
        : base(name, "Heavy", maxCapacity * 2, maxMemory - (int)(maxMemory * DecreaseMemory))
    {
    }
}
