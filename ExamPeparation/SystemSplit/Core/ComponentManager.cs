
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

public class ComponentManager
{
    private List<Hardware> hardware;
    private Dumb dumb;

    public ComponentManager()
    {
        this.hardware = new List<Hardware>();
        this.dumb = new Dumb();
    }

    public void RegisterPowerHardware(string[] tokens)
    {
        string[] hdwInfo = tokens[0].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string name = hdwInfo[0];
        int capacity = int.Parse(hdwInfo[1]);
        int memory = int.Parse(hdwInfo[2]);

        Hardware hdwr = new PowerHardware(name, capacity, memory);
        hardware.Add(hdwr);
    }

    public void RegisterHeavyHardware(string[] tokens)
    {
        string[] hdwInfo = tokens[0].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string name = hdwInfo[0];
        int capacity = int.Parse(hdwInfo[1]);
        int memory = int.Parse(hdwInfo[2]);

        Hardware hdwr = new HeavyHardware(name, capacity, memory);
        hardware.Add(hdwr);
    }

    public void RegisterExpressSoftware(string[] tokens)
    {
        string[] hdwInfo = tokens[0]
            .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string hardComponent = hdwInfo[0];
        string name = hdwInfo[1];
        int capacity = int.Parse(hdwInfo[2]);
        int memory = int.Parse(hdwInfo[3]);

        Software expSoft = new ExpressSoftware(name, capacity, memory);

        if (hardware.Any(h => h.Name == hardComponent))
        {
            hardware.Where(h => h.Name == hardComponent).First().AddSoftware(expSoft);
        }
    }

    public void RegisterLightSoftware(string[] tokens)
    {
        string[] hdwInfo = tokens[0]
        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string hardComponent = hdwInfo[0];
        string name = hdwInfo[1];
        int capacity = int.Parse(hdwInfo[2]);
        int memory = int.Parse(hdwInfo[3]);

        Software expSoft = new LightSoftware(name, capacity, memory);

        if (hardware.Any(h => h.Name == hardComponent))
        {
            hardware.Where(h => h.Name == hardComponent).First().AddSoftware(expSoft);
        }
    }

    public void ReleaseSoftwareComponent(string[] tokens)
    {
        string[] hdwInfo = tokens[0]
       .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string hardwareName = hdwInfo[0];
        string softwareName = hdwInfo[1];

        if (this.hardware.Any(h => h.Name == hardwareName))
        {
            this.hardware.Where(h => h.Name == hardwareName).First().RemoveSoftware(softwareName);
        }
    }

    public void Dumb(string hardwareComponentName)
    {
        if (this.hardware.Any(c => c.Name == hardwareComponentName))
        {
            Hardware hdware = this.hardware.Where(c => c.Name == hardwareComponentName).First();
            this.hardware.Remove(hdware);

            this.dumb.AddToDump(hdware);
        }
    }

    public void Restore(string hardwareName)
    {
        if (dumb.IsHardwareExist(hardwareName))
        {
            this.hardware.Add(dumb.GetHardware(hardwareName));
        }
    }

    public void Destroy(string hardwareName)
    {
        if (this.dumb.IsHardwareExist(hardwareName))
        {
            this.dumb.RemoveHardware(hardwareName);
        }
    }

    public string DumpAnalyze()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Dump Analysis");
        sb.AppendLine($"Power Hardware Components: {this.dumb.Trash.Count(c => c.Type == "Power")}");
        sb.AppendLine($"Heavy Hardware Components: {this.dumb.Trash.Count(c => c.Type == "Heavy")}");
        sb.AppendLine($"Express Software Components: {this.dumb.Trash.Sum(c => c.Software.Where(s => s.Type == "Express").Count())}");
        sb.AppendLine($"Light Software Components: {this.dumb.Trash.Sum(c => c.Software.Where(s => s.Type == "Light").Count())}");
        sb.AppendLine($"Total Dumped Memory: {this.dumb.Trash.Sum(c => c.Software.Sum(s => s.MemoryConsumption))}");
        sb.AppendLine($"Total Dumped Capacity: {this.dumb.Trash.Sum(c => c.Software.Sum(s => s.CapacityConsumption))}");

        return sb.ToString().Trim();
    }
    public string Analyze()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("System Analysis");
        sb.AppendLine($"Hardware Components: {this.hardware.Count}");
        sb.AppendLine($"Software Components: {this.hardware.Sum(h => h.Software.Count)}");
        sb.AppendLine($"Total Operational Memory: {this.hardware.Sum(h => h.Software.Sum(s => s.MemoryConsumption))} / {this.hardware.Sum(h => h.MaxMemory)}");
        sb.AppendLine($"Total Capacity Taken: {this.hardware.Sum(h => h.Software.Sum(s => s.CapacityConsumption))} / {this.hardware.Sum(h => h.MaxCapacity)}");

        return sb.ToString().Trim();
    }

    public string SystemSplit()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var hard in hardware.OrderByDescending(c => c.Type))
        {
            sb.AppendLine($"Hardware Component - {hard.Name}");
            sb.AppendLine($"Express Software Components - {hard.Software.Where(c => c.Type == "Express").Count()}");
            sb.AppendLine($"Light Software Components - {hard.Software.Where(c => c.Type == "Light").Count()}");
            sb.AppendLine($"Memory Usage: {hard.Software.Sum(s => s.MemoryConsumption)} / {hard.MaxMemory}");
            sb.AppendLine($"Capacity Usage: {hard.Software.Sum(s => s.CapacityConsumption)} / {hard.MaxCapacity}");
            sb.AppendLine($"Type: {hard.Type}");
            sb.AppendLine($"Software Components: {string.Join(", ", GetSoftComponents(hard.Software))}");
        }

        return sb.ToString().Trim();
    }

    private List<string> GetSoftComponents(List<Software> software)
    {
        List<string> result = new List<string>();

        foreach (var soft in software)
        {
            result.Add(soft.Name);
        }

        if (result.Count == 0)
        {
            result.Add("None");
        }

        return result;
    }


}


