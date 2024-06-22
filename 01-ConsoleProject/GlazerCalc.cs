using System;

class GlazerCalc
{
	static void Main()
	{
		double width, height, woodLength, glassArea;
		string widthString, heightString;

		widthString = Console.ReadLine();
		width = double.Parse(widthString);

		heightString = Console.ReadLine();
		height = double.Parse(heightString);

		Console.WriteLine("The width is " + width + " and the height is " + height);
	}
}