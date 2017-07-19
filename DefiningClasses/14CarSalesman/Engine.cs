public class Engine
{
    private string model;
    private int power;
    private string displacement;
    private string efficiency;

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }

    public string Model { get { return this.model; } set { this.model = value; } }

    public int Power { get { return this.power; } set { this.power = value; } }

    public string Displacements { get { return this.displacement; } set { this.displacement = value; } }

    public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }
}

