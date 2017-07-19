using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Trim().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        var rectangles = new List<Rectangle>();

        for (int i = 0; i < n; i++)
        {
            var rectangleArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (rectangleArgs.Length == 5)
            {
                var id = rectangleArgs[0];
                var width = double.Parse(rectangleArgs[1]);
                var height = double.Parse(rectangleArgs[2]);
                var topX = double.Parse(rectangleArgs[3]);
                var topY = double.Parse(rectangleArgs[4]);

                Rectangle rectangle = new Rectangle()
                {
                    Id = id,
                    Width = width,
                    Height = height,
                    TopX = topX,
                    TopY = topY
                };

                rectangles.Add(rectangle);
            }
        }

        for (int i = 0; i < m; i++)
        {
            var cmd = Console.ReadLine().Trim().Split();
            var r1 = cmd[0];
            var r2 = cmd[1];

            var rect1 = rectangles.FirstOrDefault(r => r.Id == r1);
            var rect2 = rectangles.FirstOrDefault(r => r.Id == r2);

            if (rect1.IsIntersect(rect2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
