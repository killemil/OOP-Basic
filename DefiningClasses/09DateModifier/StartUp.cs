using System;


public class StartUp
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier dateDifference = new DateModifier();
        dateDifference.DifferenceIndays(firstDate, secondDate);
        Console.WriteLine(dateDifference.difference);
    }
}
