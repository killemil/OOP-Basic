using System.Collections.Generic;


public class Person
{
    //only 1 company and car, but can have multiple parents, chidlren and pokemon.
    private string name;
    private Company company;
    private Car car;
    private List<Parent> parents;
    private List<Child> children;
    private List<Pokemon> pokemons;

    public Person()
    {
        this.company = new Company()
        {
            Name = "n/a"
        };
        this.car = new Car()
        {
            Model = "n/a"
        };
        this.parents = new List<Parent>();
        this.children = new List<Child>();
        this.pokemons = new List<Pokemon>();
    }


    public string Name { get { return this.name; } set { this.name = value; } }

    public Company Company { get { return this.company; } set { this.company = value; } }

    public Car Car { get { return this.car; } set { this.car = value; } }

    public List<Parent> Parents { get { return this.parents; } set { this.parents = value; } }

    public List<Child> Children { get { return this.children; } set { this.children = value; } }

    public List<Pokemon> Pokemons { get { return this.pokemons; } set { this.pokemons = value; } }


    //public override string ToString()
    //{
    //    return $"{this.name}\nCompany:\n{this.company.Name} {this.company.Department} {this.company.Salary:f2}\nCar:\n{this.car.Model} {this.car.Speed}\nPokemon:\n{string.Join("\n", this.pokemons)}\nParents:\n{string.Join("\n", this.parents)}\nChildren:\n{string.Join("\n", this.children)}";
    //}

}
