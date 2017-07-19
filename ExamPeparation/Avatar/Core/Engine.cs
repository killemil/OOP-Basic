using System;
using System.Linq;

public class Engine
{
    private NationsBuilder nationBuilder;

    public Engine()
    {
        this.nationBuilder = new NationsBuilder();
    }

    internal void Run()
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "Quit")
        {
            string[] tokens = inputLine.Split();
            ExecuteCommand(tokens);
        }
        Console.Write(nationBuilder.GetWarsRecord());
    }

    private void ExecuteCommand(string[] tokens)
    {
        string command = tokens[0].ToLower();
        switch (command)
        {
            case "bender":
                nationBuilder.AssignBender(tokens.Skip(1).ToList());
                break;
            case "monument":
                nationBuilder.AssignMonument(tokens.Skip(1).ToList());
                break;
            case "status":
                Console.WriteLine(nationBuilder.GetStatus(tokens[1]));
                break;
            case "war":
                nationBuilder.IssueWar(tokens[1]);
                break;
        }
    }


}

