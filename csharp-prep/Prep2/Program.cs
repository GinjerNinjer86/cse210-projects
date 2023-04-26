using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string ValueFromUser = Console.ReadLine();
        int percentage = int.Parse(ValueFromUser);
        
        string Letter = "";

        if (percentage >= 90)
        {
            Letter = "A";
        }
        else if (percentage >= 80)
        {
            Letter = "B";
        }
        else if (percentage >= 70)
        {
            Letter = "C";
        }
        else if (percentage >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"Your Letter Grade is: {Letter}");
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
