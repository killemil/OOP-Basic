using System;


public class StartUp
{
    public static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        Team team = new Team("NoName");

        for (int i = 0; i < lines; i++)
        {
            string[] inputTokens = Console.ReadLine().Split();
            Person person = new Person(
                            inputTokens[0],
                            inputTokens[1],
                            int.Parse(inputTokens[2]),
                            double.Parse(inputTokens[3]));
            team.AddPlayer(person);
        }
        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}
