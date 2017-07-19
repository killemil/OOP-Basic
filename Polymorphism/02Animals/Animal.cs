public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.name} and my favourite food is {this.favouriteFood}";
    }
}

