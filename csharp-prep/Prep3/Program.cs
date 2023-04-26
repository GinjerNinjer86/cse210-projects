using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int rightNumber = randomGenerator.Next(1, 101);

        int UserGuess = -1;

        // We could also use a do-while loop here...
        while (UserGuess != rightNumber)
        {
            Console.Write("What is your guess? ");
            UserGuess = int.Parse(Console.ReadLine());

            if (rightNumber > UserGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (rightNumber < UserGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}