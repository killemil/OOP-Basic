using System.Collections.Generic;


public class Trainer
{
    //a name, number of badges and a collection of pokemon
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer()
    {
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public string Name { get { return this.name; } set { this.name = value; } }

    public int Badges { get { return this.badges; } set { this.badges = value; } }

    public List<Pokemon> Pokemons { get { return this.pokemons; } set { this.pokemons = value; } }
}
