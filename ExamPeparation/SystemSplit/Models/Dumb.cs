
using System.Collections.Generic;
using System.Linq;

public class Dumb
{
    private List<Hardware> trash;

    public Dumb()
    {
        this.trash = new List<Hardware>();
    }

    public List<Hardware> Trash
    {
        get { return this.trash; }
        private set { this.trash = value; }
    }

    public void AddToDump(Hardware hardware)
    {
        this.Trash.Add(hardware);
    }

    public bool IsHardwareExist(string name)
    {
        return this.Trash.Any(c => c.Name == name);
    }

    public Hardware GetHardware(string name)
    {
        Hardware hardware = this.trash.Where(c => c.Name == name).First();
        this.Trash.Remove(hardware);

        return hardware;
    }

    public void RemoveHardware(string name)
    {
        Hardware hardware = this.trash.Where(c => c.Name == name).First();
        this.Trash.Remove(hardware);
    }
}
