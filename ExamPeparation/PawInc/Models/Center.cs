
using System.Collections.Generic;

public abstract class Center
{
    private string name;
    private List<Animal> animals;

    public Center(string name)
    {
        this.Name = name;
        this.animals = new List<Animal>();
    }

    public List<Animal> Animals
    {
        get { return this.animals; }
        set { this.animals = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
}

