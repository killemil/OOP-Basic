
namespace _19DrawingTool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input.Equals("Square"))
            {
                Square square = new Square(int.Parse(Console.ReadLine()));
                square.Draw();
            }
            else if (input.Equals("Rectangle"))
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                Rectangle rec = new Rectangle(width, height);
                rec.Draw();
            }
        }
    }
}
