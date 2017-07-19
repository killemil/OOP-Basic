using System.Collections.Generic;
using System.Linq;

public abstract class Hardware
{

    private string name;
    private int maxCapacity;
    private int maxMemory;
    private string type;
    private List<Software> software;
    private int currentCapacity;
    private int currentMemory;

    public Hardware(string name, string type, int maxCapacity, int maxMemory)
    {
        this.Name = name;
        this.Type = type;
        this.MaxCapacity = maxCapacity;
        this.MaxMemory = maxMemory;
        this.software = new List<Software>();
        this.currentCapacity = maxCapacity;
        this.currentMemory = maxMemory;
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
    public int MaxMemory
    {
        get { return this.maxMemory; }
        private set { this.maxMemory = value; }
    }

    public int MaxCapacity
    {
        get { return this.maxCapacity; }
        private set { this.maxCapacity = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public List<Software> Software
    {
        get { return this.software; }
        private set { this.software = value; }
    }

    public void AddSoftware(Software software)
    {
        if (software.CapacityConsumption <= this.currentCapacity && software.MemoryConsumption <= this.currentMemory)
        {
            this.currentCapacity -= software.CapacityConsumption;
            this.currentMemory -= software.MemoryConsumption;

            this.software.Add(software);
        }
    }

    public void RemoveSoftware(string softwareName)
    {
        if (this.Software.Any(c => c.Name == softwareName))
        {
            Software softToRemove = this.Software.Where(c => c.Name == softwareName).First();
            this.currentCapacity += softToRemove.CapacityConsumption;
            this.currentMemory += softToRemove.MemoryConsumption;

            this.Software.Remove(softToRemove);
        }
    }

}

