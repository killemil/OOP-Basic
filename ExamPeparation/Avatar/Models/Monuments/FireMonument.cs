public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity
    {
        get { return this.fireAffinity; }
        set { this.fireAffinity = value; }
    }

    public override int GetAffinity()
    {
        return this.fireAffinity;
    }
    public override string ToString()
    {
        return $"Fire Monument: {base.Name}, Fire Affinity: {this.fireAffinity}";
    }
}

