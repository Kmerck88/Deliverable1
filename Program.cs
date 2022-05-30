using System;

namespace Deliverable1
{
	class Program
	{
		static void Main(string[] args)
				
        {
		
       string Y = "y";
do
{
    Console.Write("How many people are we making PB&J sandwiches for? ");
    int numbofPeople;
    if (int.TryParse(Console.ReadLine(), out numbofPeople))
    {
        int hungryPeople = numbofPeople * 2;
        Console.WriteLine("You need:");
        Console.WriteLine($"{hungryPeople} slices of bread");
        Console.WriteLine($"{hungryPeople} tablespoons of peanut butter");
        Console.WriteLine($"{hungryPeople * 2} teaspoons of jelly");

        Console.WriteLine("which is...");
        Console.WriteLine("You need:");
        int loavesBread = (int)(double)Math.Ceiling((double)hungryPeople / 28);
        Console.WriteLine($"{loavesBread} loaves of bread");
        int jarsPB = (int)(double)Math.Ceiling((double)hungryPeople / 32);
        Console.WriteLine($"{jarsPB} jars of peanut butter");
        int jarsJ = (int)(double)Math.Ceiling((double)hungryPeople * 2 / 48);
        Console.WriteLine($"{jarsJ} jars of jelly");
    }
    else
    {
        Console.WriteLine("Sorry, that was not an integer.");
    }
    Console.Write("Would you like to restart? Enter yes or y to continue, or any other key to exit: ");
    yn = Console.ReadLine();
}
while (Y == "y" || Y == "yes");
Console.WriteLine("Goodbye!");
        }
    }
}
