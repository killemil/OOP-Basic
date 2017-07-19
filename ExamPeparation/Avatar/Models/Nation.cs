using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }
    
    public List<Monument> Monuments
    {
        get { return this.monuments; }
        set { this.monuments = value; }
    }


    public List<Bender> Benders
    {
        get { return this.benders; }
        set { this.benders = value; }
    }

    public void AddBender(Bender bender)
    {
        this.Benders.Add(bender);
    }

    public void AddMonument(Monument monumet)
    {
        this.Monuments.Add(monumet);
    }
    
    public double GetTotalPower()
    {
        int monumentsIncreasePercentage = this.monuments.Sum(a => a.GetAffinity());
        double totalBendersPower = this.benders.Sum(b => b.GetPower());
        double totalPowerIncrese = totalBendersPower / 100 * monumentsIncreasePercentage;

        return totalBendersPower + totalPowerIncrese;

    }

    public string GetStatus()
    {
        StringBuilder sb = new StringBuilder();
        if (this.benders.Count == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");
            foreach (var bender in this.benders)
            {
                sb.AppendLine($"###{bender}");
            }
        }

        if (this.monuments.Count == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in this.monuments)
            {
                sb.AppendLine($"###{monument}");
            }
        }
        return sb.ToString().Trim();
    }
}

