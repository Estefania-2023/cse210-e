using System;

namespace DailyScripture
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Welcome to this game!");
            Console.Write("Put the book's name: ");
            string name = Console.ReadLine();
            Console.Write("Put the number of chapter: ");
            string chapt = Console.ReadLine();
            int chap =Int32.Parse(chapt);
            Console.Write("Put the number of verse: ");
            string vers = Console.ReadLine();
            int ver =Int32.Parse(vers);
            Console.Write("Put the verse: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(name, chap, ver, text);
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}
