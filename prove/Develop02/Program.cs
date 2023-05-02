using System;

class Program
{
    static void Main(string[] args)
    {
        // Crete menu and user input variables
        Journal           journal = new Journal();
        int               menuuserinput = 0;

        List<string>      menu = new List<string>
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
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
        }
        //While user input is not 5
        //Switch sttement for user input
    }
}