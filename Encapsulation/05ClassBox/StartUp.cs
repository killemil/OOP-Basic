
namespace _05ClassBox
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double len = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(len, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}\nLateral Surface Area - {box.GetLateralSurfaceArea():f2}\nVolume - {box.GetVolume():f2}");

        }
    }
}
