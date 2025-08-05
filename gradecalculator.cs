using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the numerical grade (0-100):");

        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

             
                Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
        }

    
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
