public class Cat : Animal
{
    private int intelligenceCoefficent;

    public Cat(string name, int age, int intelligenceCoefficent)
        : base(name, age)
    {
        this.IntelligenceCoefficent = intelligenceCoefficent;
    }

    public int IntelligenceCoefficent
    {
        get { return this.intelligenceCoefficent; }
        set { this.intelligenceCoefficent = value; }
    }
}
