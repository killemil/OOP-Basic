public class LightSoftware : Software
{
    public const double IncreaseDecreaseConsumption = 0.50;

    public LightSoftware(string name, int capacityConsumption, int memoryConsumption)
        : base(name, "Light", capacityConsumption + (int)(capacityConsumption / 2), memoryConsumption - (int)(memoryConsumption / 2))
    {

    }
}
