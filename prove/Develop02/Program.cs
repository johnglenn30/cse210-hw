using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Save Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Display Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    Console.Write("Enter a file name to save the journal entries: ");
                    string fileName = Console.ReadLine();
                    SaveManager.SaveJournal(myJournal.GetJournal(), fileName);
                    break;
                case "3":
                    myJournal.Load();
                    break;
                case "4":
                    myJournal.Display();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
