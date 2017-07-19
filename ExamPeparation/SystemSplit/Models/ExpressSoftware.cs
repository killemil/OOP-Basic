public class ExpressSoftware : Software
{
    public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption)
        : base(name, "Express", capacityConsumption, memoryConsumption * 2)
    {
    }
}
