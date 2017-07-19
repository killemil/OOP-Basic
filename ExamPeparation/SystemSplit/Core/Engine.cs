
using System;
using System.Linq;

public class Engine
{
    private ComponentManager manager;

    public Engine()
    {
        this.manager = new ComponentManager();
    }

    public void Run()
    {
        string inputLine;

        while ((inputLine = Console.ReadLine()) != "System Split")
        {
            string[] tokens = inputLine
                .Split(new[] { ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(tokens);
        }
        Console.WriteLine(manager.SystemSplit());
    }

    private void ExecuteCommand(string[] tokens)
    {
        string command = tokens[0];

        switch (command)
        {
            case "RegisterPowerHardware":
                manager.RegisterPowerHardware(tokens.Skip(1).ToArray());
                break;
            case "RegisterHeavyHardware":
                manager.RegisterHeavyHardware(tokens.Skip(1).ToArray());
                break;
            case "RegisterExpressSoftware":
                manager.RegisterExpressSoftware(tokens.Skip(1).ToArray());
                break;
            case "RegisterLightSoftware":
                manager.RegisterLightSoftware(tokens.Skip(1).ToArray());
                break;
            case "ReleaseSoftwareComponent":
                manager.ReleaseSoftwareComponent(tokens.Skip(1).ToArray());
                break;
            case "Analyze":
                Console.WriteLine(manager.Analyze());
                break;
            case "Dump":
                manager.Dumb(tokens[1]);
                break;
            case "Restore":
                manager.Restore(tokens[1]);
                break;
            case "Destroy":
                manager.Destroy(tokens[1]);
                break;
            case "DumpAnalyze":
                Console.WriteLine(manager.DumpAnalyze());
                break;
        }
    }
}
