public abstract class Animal
{
    private string name;
    private int age;
    private bool isCleaned;

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.isCleaned = false;
    }

    public bool IsCleaned
    {
        get { return this.isCleaned; }
        set { this.isCleaned = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}
