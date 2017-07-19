namespace _07OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Song> songsDataBase = new List<Song>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    string[] tokens = Console.ReadLine()
                        .Trim()
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string artistName = tokens[0];
                    string songName = tokens[1];
                    string duration = tokens[2];
                    Song song = new Song(artistName, songName, duration);
                    songsDataBase.Add(song);


                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Songs added: {songsDataBase.Count()}");
            int totalMinutes = songsDataBase.Sum(s => s.Minutes);
            int totalSeconds = songsDataBase.Sum(s => s.Seconds);

            totalSeconds += totalMinutes * 60;

            int finalMinutes = totalSeconds / 60;
            int finalSeconds = totalSeconds % 60;
            int finalHours = finalMinutes / 60;
            finalMinutes %= 60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");
        }
    }
}
