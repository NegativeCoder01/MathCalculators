using System;

public class Program
{
    public static void Main()
    {
        console.Write("Enter the width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        console.Write("Enter the height: ");
        double height = Conver.ToDouble(Console.ReadLine());

        if (width == height)
        {
            string shapeName = "cube";
        }
        else
        {
            string shapeName = "rectangle";
        }

        double area = width*height;

        Console.WriteLine($"The area of your {shapeName} is: {area}");
    }
}