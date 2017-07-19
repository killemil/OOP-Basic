public class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public Tyre[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tyre[] tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }
}
