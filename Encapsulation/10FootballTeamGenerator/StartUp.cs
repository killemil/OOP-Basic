namespace _10FootballTeamGenerator
{
    using _10FootballTeamGenerator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();
            try
            {
                string inputLine;
                while ((inputLine = Console.ReadLine()) != "END")
                {
                    string[] tokens = inputLine
                        .Trim()
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    string command = tokens[0];

                    switch (command.ToLower())
                    {
                        case "add":
                            string teamName = tokens[1];
                            string playerName = tokens[2];
                            int endurance = int.Parse(tokens[3]);
                            int spring = int.Parse(tokens[4]);
                            int dribble = int.Parse(tokens[5]);
                            int passing = int.Parse(tokens[6]);
                            int shooting = int.Parse(tokens[7]);
                            if (!teams.Any(t => t.Name == teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                continue;
                            }
                            Player player = new Player(playerName, endurance, spring, dribble, passing, shooting);
                            teams.Where(t => t.Name == teamName).First().AddPlayer(player);

                            break;
                        case "team":
                            string name = tokens[1];
                            Team team = new Team(name);
                            teams.Add(team);
                            break;
                        case "remove":
                            string teamToRemoveFrom = tokens[1];
                            string playerToRemve = tokens[2];
                            teams.Where(t => t.Name == teamToRemoveFrom).First().RemovePlayer(playerToRemve);
                            break;
                        case "rating":
                            string teamToRating = tokens[1];

                            if (teams.Any(t => t.Name == teamToRating))
                            {
                                Console.WriteLine(teams.FirstOrDefault(t => t.Name == teamToRating).GetTeamRating());
                            }
                            else
                            {
                                Console.WriteLine($"Team {teamToRating} does not exist.");
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
