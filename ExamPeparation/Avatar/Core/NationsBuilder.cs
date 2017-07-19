using System.Collections.Generic;
using System.Text;

public class NationsBuilder
{
    private Nation airNation;
    private Nation earthNation;
    private Nation fireNation;
    private Nation waterNation;

    private List<string> issuedWars;

    public NationsBuilder()
    {
        this.airNation = new Nation();
        this.earthNation = new Nation();
        this.fireNation = new Nation();
        this.waterNation = new Nation();
        this.issuedWars = new List<string>();
    }


    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[0].ToLower();
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondParam = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "fire":
                fireNation.AddBender(new FireBender(name, power, secondParam));
                break;
            case "air":
                airNation.AddBender(new AirBender(name, power, secondParam));
                break;
            case "earth":
                earthNation.AddBender(new EarthBender(name, power, secondParam));
                break;
            case "water":
                waterNation.AddBender(new WaterBender(name, power, secondParam));
                break;
        }

    }
    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);

        switch (type.ToLower())
        {
            case "air":
                airNation.AddMonument(new AirMonument(name, affinity));
                break;
            case "water":
                waterNation.AddMonument(new WaterMonument(name, affinity));
                break;
            case "fire":
                fireNation.AddMonument(new FireMonument(name, affinity));
                break;
            case "earth":
                earthNation.AddMonument(new EarthMonument(name, affinity));
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        switch (nationsType.ToLower())
        {
            case "air":
                return "Air Nation\n" + airNation.GetStatus();
            case "fire":
                return "Fire Nation\n" + fireNation.GetStatus();
            case "water":
                return "Water Nation\n" + waterNation.GetStatus();
            case "earth":
                return "Earth Nation\n" + earthNation.GetStatus();
            default:
                return "";
        }
    }
    public void IssueWar(string nationsType)
    {
        issuedWars.Add(nationsType);
        List<Nation> nations = new List<Nation>();
        nations.Add(airNation);
        nations.Add(fireNation);
        nations.Add(earthNation);
        nations.Add(waterNation);

        double maxPower = 0;
        foreach (var nation in nations)
        {
            double power = nation.GetTotalPower();
            if (power > maxPower)
            {
                maxPower = power;
            }
        }

        if (this.airNation.GetTotalPower() < maxPower)
        {
            this.airNation.Benders.Clear();
            this.airNation.Monuments.Clear();
        }
        if (this.fireNation.GetTotalPower() < maxPower)
        {
            this.fireNation.Benders.Clear();
            this.fireNation.Monuments.Clear();
        }
        if (this.waterNation.GetTotalPower() < maxPower)
        {
            this.waterNation.Benders.Clear();
            this.waterNation.Monuments.Clear();
        }
        if (this.earthNation.GetTotalPower() < maxPower)
        {
            this.earthNation.Benders.Clear();
            this.earthNation.Monuments.Clear();
        }

    }
    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();
        int counter = 1;
        foreach (var war in issuedWars)
        {
            sb.AppendLine($"War {counter} issued by {war}");
            counter++;
        }

        return sb.ToString().Trim();
    }

}

