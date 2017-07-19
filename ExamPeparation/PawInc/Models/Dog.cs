public class Dog : Animal
{
    private int amountOfCommands;

    public Dog(string name, int age, int amountOfCommands)
        : base(name, age)
    {
        this.AmmountOfCommands = amountOfCommands;
    }

    public int AmmountOfCommands
    {
        get { return this.amountOfCommands; }
        set { this.amountOfCommands = value; }
    }
}
