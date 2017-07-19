
namespace _19DrawingTool
{
    using System;

    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine("|" + new string('-',this.width) +"|");
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine("|" + new string(' ', this.width) + "|");
            }
            Console.WriteLine("|" + new string('-', this.width) + "|");
        }
    }
}
