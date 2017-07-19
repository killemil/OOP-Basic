public abstract class Software
{
    private string type;
    private string name;
    private int capacityConsumption;
    private int memoryConsumptopm;

    public Software(string name, string type, int capacityConsumption, int memoryConsumption)
    {
        this.Name = name;
        this.Type = type;
        this.CapacityConsumption = capacityConsumption;
        this.MemoryConsumption = memoryConsumption;
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public int MemoryConsumption
    {
        get { return this.memoryConsumptopm; }
        set { this.memoryConsumptopm = value; }
    }

    public int CapacityConsumption
    {
        get { return this.capacityConsumption; }
        set { this.capacityConsumption = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}


