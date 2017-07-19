namespace _18CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Cat> cats = new List<Cat>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] tokens = inputLine.Split();
                string breed = tokens[0];

                if (breed == "Siamese")
                {
                    Siamese siamse = new Siamese()
                    {
                        Name = tokens[1],
                        EarSzie = int.Parse(tokens[2])
                    };
                    cats.Add(siamse);
                }
                else if (breed == "Cymric")
                {
                    Cymric cymric = new Cymric()
                    {
                        Name = tokens[1],
                        FurLength = double.Parse(tokens[2])
                    };
                    cats.Add(cymric);
                }
                else if (breed == "StreetExtraordinaire")
                {
                    StreetExtraordinaire cat = new StreetExtraordinaire()
                    {
                        Name = tokens[1],
                        MeowDecibels = int.Parse(tokens[2])
                    };
                    cats.Add(cat);
                }
            }

            inputLine = Console.ReadLine();

            Cat result = cats.Where(c => c.Name == inputLine).First();
            Console.WriteLine(result);
        }
    }
}
