using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CommandManager
{
    private Dictionary<string, CleansingCenter> cleansingCenters;
    private Dictionary<string, AdoptionCenter> adoptingCenters;


    public CommandManager()
    {
        this.cleansingCenters = new Dictionary<string, CleansingCenter>();
        this.adoptingCenters = new Dictionary<string, AdoptionCenter>();
    }

    public void RegisterCleansingCenter(string name)
    {
        cleansingCenters.Add(name, new CleansingCenter(name));
    }

    public void RegisterAdoptionCenter(string name)
    {
        adoptingCenters.Add(name, new AdoptionCenter(name));
    }

    public void RegisterDog(string[] tokens)
    {
        string name = tokens[0];
        int age = int.Parse(tokens[1]);
        int learnedCommands = int.Parse(tokens[2]);
        string adoptionCenter = tokens[3];
        Dog dog = new Dog(name, age, learnedCommands);

        this.adoptingCenters[adoptionCenter].Animals.Add(dog);
    }

    public void RegisterCat(string[] tokens)
    {
        string name = tokens[0];
        int age = int.Parse(tokens[1]);
        int intelligenceCoefficent = int.Parse(tokens[2]);
        string adoptionCenter = tokens[3];
        Cat cat = new Cat(name, age, intelligenceCoefficent);

        this.adoptingCenters[adoptionCenter].Animals.Add(cat);
    }

    public void SendForCleansing(string[] tokens)
    {
        this.cleansingCenters[tokens[1]].Animals
            .AddRange(this.adoptingCenters[tokens[0]].Animals.Where(a => a.IsCleaned == false));
        this.adoptingCenters[tokens[0]].SentAnimalsForCleansing();

    }

    public void Cleanse(string cleansingCenterName)
    {
        this.cleansingCenters[cleansingCenterName].Cleanse();
        foreach (var adoptCenter in this.adoptingCenters)
        {
            adoptCenter.Value.TakeBackCleansedAnimals();
        }
    }

    public void Adopt(string adoptionCenterName)
    {
        this.adoptingCenters[adoptionCenterName].Adopt();
    }

    internal string PrintResult()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Paw Incorporative Regular Statistics");
        sb.AppendLine($"Adoption Centers: {this.adoptingCenters.Count}");
        sb.AppendLine($"Cleansing Centers: {this.cleansingCenters.Count}");
        sb.AppendLine($"Adopted Animals: {string.Join(", ", PrintAdoptedAnimals(this.adoptingCenters))}");
        sb.AppendLine($"Cleansed Animals: {string.Join(", ", PrintCleansedAnimals(this.cleansingCenters))}");
        sb.AppendLine($"Animals Awaiting Adoption: {this.adoptingCenters.Values.Sum(a => a.Animals.Count)}");
        sb.AppendLine($"Animals Awaiting Cleansing: {this.cleansingCenters.Values.Sum(a => a.Animals.Count())}");

        return sb.ToString().Trim();
    }

    private static List<string> PrintAdoptedAnimals(Dictionary<string, AdoptionCenter> adoptionCenters)
    {
        List<string> adoptedAnimals = new List<string>();
        foreach (var adoptionCenter in adoptionCenters.Values)
        {
            foreach (var animal in adoptionCenter.AdoptedAnimals)
            {
                adoptedAnimals.Add(animal.Name);
            }
        }

        if (adoptedAnimals.Count == 0)
            adoptedAnimals.Add("None");

        return adoptedAnimals.OrderBy(x => x).ToList();
    }

    private static List<string> PrintCleansedAnimals(Dictionary<string, CleansingCenter> cleansingCenters)
    {
        List<string> cleansedAnimals = new List<string>();
        foreach (var cleansingCenter in cleansingCenters.Values)
        {
            foreach (var animal in cleansingCenter.CleansedAnimals)
            {
                cleansedAnimals.Add(animal.Name);
            }
        }

        if (cleansedAnimals.Count == 0)
            cleansedAnimals.Add("None");

        return cleansedAnimals.OrderBy(x => x).ToList();
    }
}
