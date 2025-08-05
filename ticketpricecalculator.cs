using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");

        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                int ticketPrice;

                if (age >= 65 || age <= 12)
                {
                    ticketPrice = 7;
                }
                else
                {
                    ticketPrice = 10;
                }

                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric age.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
