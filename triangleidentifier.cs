using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of side 1:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the length of side 2:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Enter the length of side 3:");
        string input3 = Console.ReadLine();

        double side1, side2, side3;

        bool valid1 = double.TryParse(input1, out side1);
        bool valid2 = double.TryParse(input2, out side2);
        bool valid3 = double.TryParse(input3, out side3);

        if (!valid1 || !valid2 || !valid3 ||
            side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive numeric lengths.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return;
        }

        if (side1 + side2 <= side3 ||
            side2 + side3 <= side1 ||
            side1 + side3 <= side2)
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return;
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
