using System;

class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Please insert the Width:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Please insert the Height:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        Console.WriteLine("The width is " + width + " and the height is " + height);
    }
}