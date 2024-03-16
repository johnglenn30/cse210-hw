using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a scripture instance
        Scripture scripture = new Scripture();
        scripture.Initialize("In the beginning God created the heavens and the earth", "Genesis 1:1-3");

        bool allWordsHidden = false;
        int hiddenWordCount = 1;

        while (!allWordsHidden)
        {
            // Display the scripture
            Console.Clear();
            scripture.Display();

            // Prompt the user
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide random words
            scripture.HideRandomWords(hiddenWordCount);
            hiddenWordCount++;

            // Check if all words are hidden
            allWordsHidden = scripture.checkAllWordsHidden();
        }
        Console.Clear();
        scripture.Display();
        //Console.WriteLine(hiddenWordCount);
    }
}