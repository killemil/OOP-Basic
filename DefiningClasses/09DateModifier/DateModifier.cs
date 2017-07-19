using System;


public class DateModifier
{
    public int difference;

    public int DifferenceIndays(string firstDate, string secondData)
    {
        DateTime firstDateParsed =
            DateTime.ParseExact(firstDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime secondDateParsed =
            DateTime.ParseExact(secondData, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        if (firstDateParsed > secondDateParsed)
        {
            this.difference = (int)(firstDateParsed - secondDateParsed).Days;
        }
        else
        {
            this.difference = (int)(secondDateParsed - firstDateParsed).Days;
        }

        return this.difference;
    }
}
