using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        string[] listOfEvents = {"Lectures", "Receptions", "Outdoors"};
        string logo = """
                ╔═╗┬  ┬┌─┐┌┐┌┌┬┐  ╔═╗┬  ┌─┐┌┐┌┌┐┌┬┌┐┌┌─┐
                ║╣ └┐┌┘├┤ │││ │   ╠═╝│  ├─┤│││││││││││ ┬
                ╚═╝ └┘ └─┘┘└┘ ┴   ╩  ┴─┘┴ ┴┘└┘┘└┘┴┘└┘└─┘
                      "PLAN YOUR EVENTS WITH US"
            """;
        Console.WriteLine(logo);
        Console.WriteLine("");
        Console.WriteLine($"Which event would you like to plan: 1.{listOfEvents[0]}  |  2.{listOfEvents[1]}  |  3.{listOfEvents[2]}");
        string theEvent = Console.ReadLine().ToLower();
        Console.WriteLine("");

        void StandardMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Standard Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void FulldMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Full Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void ShortMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Short Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }

        switch (theEvent)
        {
           
        }
    }
}