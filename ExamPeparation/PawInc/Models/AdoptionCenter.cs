
using System;
using System.Collections.Generic;

public class AdoptionCenter : Center
{
    private List<Animal> adoptedAnimals;
    private List<Animal> animalsSentForCleansing;

    public AdoptionCenter(string name)
        : base(name)
    {
        this.AdoptedAnimals = new List<Animal>();
        this.AnimalsSentForCleansing = new List<Animal>();
    }

    public List<Animal> AdoptedAnimals
    {
        get { return this.adoptedAnimals; }
        private set { this.adoptedAnimals = value; }
    }

    private List<Animal> AnimalsSentForCleansing
    {
        get { return this.animalsSentForCleansing; }
        set { this.animalsSentForCleansing = value; }
    }

    public void SentAnimalsForCleansing()
    {
        List<Animal> animalsToRemove = new List<Animal>();

        foreach (var animal in base.Animals)
        {
            if (!animal.IsCleaned)
            {
                this.AnimalsSentForCleansing.Add(animal);
                animalsToRemove.Add(animal);
            }
        }

        foreach (var animal in animalsToRemove)
        {
            this.Animals.Remove(animal);
        }

    }
    public void TakeBackCleansedAnimals()
    {
        List<Animal> animalsToRemove = new List<Animal>();
        foreach (var animal in this.AnimalsSentForCleansing)
        {
            if (animal.IsCleaned)
            {
                this.Animals.Add(animal);
                animalsToRemove.Add(animal);
            }
        }

        foreach (var animal in animalsToRemove)
        {
            this.AnimalsSentForCleansing.Remove(animal);
        }
    }

    public void Adopt()
    {
        List<Animal> animalsToRemove = new List<Animal>();
        foreach (var animal in this.Animals)
        {
            if (animal.IsCleaned)
            {
                this.AdoptedAnimals.Add(animal);
                animalsToRemove.Add(animal);
            }
        }

        foreach (var animal in animalsToRemove)
        {
            this.Animals.Remove(animal);
        }
    }
}
