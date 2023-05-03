using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create menu and user input variables
        Journal journal = new Journal();
        int menuuserinput = 0;

        List<string> menu = new List<string>
        {
            "Please enter one of the following options:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "Menu Option #: "
        };

        while (menuuserinput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuuserinput = int.Parse(Console.ReadLine());

            switch (menuuserinput)
            {
                case 1:
                    // Write a new entry
                    Console.WriteLine("Please enter your response to the following prompt:");
                    string prompt = journal.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.CreateJournalEntry(prompt, response);
                    Console.WriteLine("Entry saved.");
                    break;

                case 2:
                    // Display the journal
                    journal.DisplayJournalEntries();
                    break;

                case 3:
                    // Load the journal from a file
                    Console.WriteLine("Please enter the filename to load:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromCSV(loadFilename);
                    Console.WriteLine("Journal loaded.");
                    break;

                case 4:
                    // Save the journal to a file
                    Console.WriteLine("Please enter the filename to save:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToCSV(saveFilename);
                    Console.WriteLine("Journal saved.");
                    break;

                case 5:
                    // Quit the program
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }
        }
    }
}