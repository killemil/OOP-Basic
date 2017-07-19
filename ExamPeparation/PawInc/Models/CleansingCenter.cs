using System;
using System.Collections.Generic;

public class CleansingCenter : Center
{
    private List<Animal> cleansedAnimals;

    public CleansingCenter(string name)
        : base(name)
    {
        this.CleansedAnimals = new List<Animal>();
    }
    public List<Animal> CleansedAnimals
    {
        get
        {
            return this.cleansedAnimals;
        }
        set
        {
            this.cleansedAnimals = value;
        }
    }

    public void Cleanse()
    {
        foreach (var animal in this.Animals)
        {
            animal.IsCleaned = true;
            this.CleansedAnimals.Add(animal);
        }

        this.Animals.Clear();
    }


}
