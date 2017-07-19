
using System;
using System.Linq;

public class Engine
{
    private CommandManager manager;
    public Engine()
    {
        this.manager = new CommandManager();
    }

    public void Run()
    {
        string inputLine;

        while ((inputLine = Console.ReadLine()) != "Paw Paw Pawah")
        {
            string[] tokens = inputLine
                .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(tokens);
        }

        Console.WriteLine(manager.PrintResult());

    }

    private void ExecuteCommand(string[] tokens)
    {
        string command = tokens[0];

        switch (command.ToLower())
        {
            case "registercleansingcenter":
                manager.RegisterCleansingCenter(tokens[1]);
                break;
            case "registeradoptioncenter":
                manager.RegisterAdoptionCenter(tokens[1]);
                break;
            case "registerdog":
                manager.RegisterDog(tokens.Skip(1).ToArray());
                break;
            case "registercat":
                manager.RegisterCat(tokens.Skip(1).ToArray());
                break;
            case "sendforcleansing":
                manager.SendForCleansing(tokens.Skip(1).ToArray());
                break;
            case "cleanse":
                manager.Cleanse(tokens[1]);
                break;
            case "adopt":
                manager.Adopt(tokens[1]);
                break;
        }
    }
}
