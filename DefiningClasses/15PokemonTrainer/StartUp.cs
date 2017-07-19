using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Trainer> trainers = new List<Trainer>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "Tournament")
        {
            string[] tokens = inputLine.Split();
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string element = tokens[2];
            int health = int.Parse(tokens[3]);

            Pokemon pokemon = new Pokemon(pokemonName, element, health);
            if (trainers.Any(t => t.Name == trainerName))
            {
                trainers.Where(t => t.Name == trainerName).First().Pokemons.Add(pokemon);
            }
            else
            {
                Trainer trainer = new Trainer();
                trainer.Name = trainerName;
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);
            }
        }

        while ((inputLine = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == inputLine))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Where(p => p.Health > 0).Count()}");
        }
    }
}
