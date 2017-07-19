namespace _10FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private double rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double GetTeamRating()
        {
            double rating = 0.0;
            foreach (var player in this.players)
            {
                rating += player.SkillLevel;
            }
            this.rating = rating / this.players.Count;

            return this.rating;
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.players.Any(p => p.Name == playerName))
            {
                Player player = this.players.First(p => p.Name == playerName);
                this.players.Remove(player);
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name}");
            }
        }
    }
}
